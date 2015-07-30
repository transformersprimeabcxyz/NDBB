using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace NDBB
{
    public partial class formMain
    {
        // List of natives
        private List<NativeNamespace> natives;

        bool nativesHasChanged = false;

        // Loads natives from native manager
        void LoadNatives(String path)
        {
            natives = NativeManager.LoadFromFile(path);
            if (natives == null) return;

            ClearAll();
            int numnatives = 0;
            foreach (NativeNamespace _namespace in natives)
            {
                namespaceListBox.Items.Add(_namespace.Name + " (" + _namespace.Functions.Count.ToString() + ")");
                numnatives += (int)_namespace.Functions.Count;
            }
            grpNamespace.Text = "Namespaces (" + numnatives.ToString() + ")";
        }

        // Show natives for specified namespace
        void ShowNativesFor(String namespaceName, bool cleanStuff = false)
        {
            if (natives == null) return;

            if (cleanStuff)
            {
                ClearSearch();
                ClearDetails();
            }

            ClearNatives();
            foreach (NativeNamespace _namespace in natives)
                if (_namespace.Name == namespaceName)
                {
                    foreach (NativeFunction _function in _namespace.Functions)
                    {
                        var item = new ListViewItem(new[]{
                            _function.Hash,
                            _function.Name,
                            _function.Result
                        });
                        nativesListView.Items.Add(item);
                    }
                    break;
                }
        }

        // Exports natives!
        enum ExportFormat { CPPHeader, JSON }
        bool DoExport(ExportFormat format)
        {
            if (natives == null) return false;

            bool ret = false;
            ShowFileChangedBox = false;

            switch (format)
            {
                case ExportFormat.JSON:
                    exportDialog.DefaultExt = "json";
                    exportDialog.FileName = "natives";
                    exportDialog.Filter = "JSON|*.json";
                    if (exportDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        NativeManager.ExportJSON(natives, exportDialog.FileName);
                        nativesHasChanged = false;
                        ret = true;
                    }
                    break;
                case ExportFormat.CPPHeader:
                    exportDialog.DefaultExt = "h";
                    exportDialog.FileName = "natives";
                    exportDialog.Filter = "C++ Header|*.h";
                    if (exportDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        NativeManager.ExportHeader(natives, exportDialog.FileName);
                        ret = true;
                    }
                    break;
            }

            ShowFileChangedBox = true;
            return ret;
        }

        // Search!
        void DoSearch(String filter, bool byName = true)
        {
            if (natives == null) return;

            if (filter.Length == 0)
            {
                ShowNativesFor(SelectedNamespaceName, true);
                RefreshNatiesListView();
                return;
            }

            List<NativeFunction> found = null;
            NativeNamespace ns = null;

            String sn = SelectedNamespaceName;
            foreach (NativeNamespace n in natives)
                if (sn == n.Name)
                {
                    ns = n;
                    break;
                }

            filter = filter.Replace(' ', '_');

            if (byName)
                found = SearchByName(ns, filter.ToUpper());
            else
                found = SearchByHash(ns, filter.ToUpper());
            if (found == null) return;

            ClearNatives();
            foreach (NativeFunction _function in found)
            {
                var item = new ListViewItem(new[]{
                            _function.Hash,
                            _function.Name,
                            _function.Result
                        });
                nativesListView.Items.Add(item);
            }

            RefreshNatiesListView(false);
        }

        // Search in natives by name
        List<NativeFunction> SearchByName(NativeNamespace ns, String filter)
        {
            if (natives == null) return null;

            List<NativeFunction> found = new List<NativeFunction>();

            foreach (NativeFunction _function in ns.Functions)
            {
                if (_function.Name.Contains(filter))
                    found.Add(_function);
            }

            return found;
        }

        // Search in natives by hash
        List<NativeFunction> SearchByHash(NativeNamespace ns, String filter)
        {
            if (natives == null) return null;

            List<NativeFunction> found = new List<NativeFunction>();

            foreach (NativeFunction _function in ns.Functions)
            {
                if (_function.Hash.Contains(filter))
                    found.Add(_function);
            }

            return found;
        }

        // Refreshes the natives list view and selects the first index
        void RefreshNatiesListView(bool resetNamespace = true)
        {
            if (natives == null) return;

            if (resetNamespace)
                namespaceListBox.SelectedIndex = 0;

            if (nativesListView.Items.Count > 0)
            {
                nativesListView.Items[0].Selected = true;
                nativesListView.Items[0].Focused = true;
            }

            nativesListView.Select();
        }

        // Shows details for selected function
        void ShowDocs()
        {
            if (natives == null) return;

            ClearDetails();
            descriptionRTB.Text = Docs(SelectedHash);
        }

        // Clear all lists, textboxes, etc
        void ClearAll()
        {
            if (natives == null) return;

            ClearNamespaces();
            ClearNatives();
            ClearDetails();
            ClearSearch();
        }

        // Clears namespaces list box
        void ClearNamespaces()
        {
            if (natives == null) return;

            namespaceListBox.Items.Clear();
        }

        // Clears natives list view
        void ClearNatives()
        {
            if (natives == null) return;

            nativesListView.Items.Clear();
        }

        // Clears details textbox
        void ClearDetails()
        {
            if (natives == null) return;

            descriptionRTB.Text = String.Empty;
        }

        // Resets the search
        void ClearSearch()
        {
            if (natives == null) return;

            searchTextBox.Text = String.Empty;
            sbnRadioButton.Checked = true;
        }

        public Boolean ShowFileChangedBox { get; set; }
        public void OnNativesFileChange(object sender, FileSystemEventArgs e)
        {
            if (ShowFileChangedBox)
            {
                this.Invoke((Action)delegate()
                {
                    try
                    {
                        if (natives == null) return;

                        NativeManager.fw.EnableRaisingEvents = false; // To avoid being triggered twice

                        MessageBox.Show("natives.json has been changed externally. It will be reloaded", "File change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNatives(NativeManager.LocalNatives);
                        RefreshNatiesListView();
                    }
                    finally
                    {
                        NativeManager.fw.EnableRaisingEvents = true; // To avoid being triggered twice
                    }
                });
            }
        }
    }
}
