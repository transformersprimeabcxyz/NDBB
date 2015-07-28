using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NDBB
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            NativeManager.OnNativesChange(this.OnNativesFileChange);

            if (NativeManager.LocalNativesExist)
            {
                LoadNatives(NativeManager.LocalNatives);
                RefreshNatiesListView();
            }
            else
                MessageBox.Show("No local natives.json has been found. To load natives, see File menu",
                    "No natives.json!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DoSearch(searchTextBox.Text, sbnRadioButton.Checked);
        }

        private void namespaceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String itemName = SelectedNamespace;
            ShowNativesFor(itemName, true);
            RefreshNatiesListView(false);
            ShowDocs();
        }

        private void nativesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDocs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchButton.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String hash = SelectedHash;
            if (hash.Length == 0) return;

            String copyText = GetFunctionCallString(GetNativeFunction(hash));
            Clipboard.SetText(copyText);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String about =
@"NDBB (Native Database Browser)
Simple GTAV natives browser

Credits:
  ShrewdSpirit (Developer)
  Alexander Blade (Natives Database)

Version: 1.0

GitHub: https://github.com/ShrewdSpirit/NDBB/";
            MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoExport(ExportFormat.JSON);
        }

        private void cHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoExport(ExportFormat.CPPHeader);
        }

        private void updateNativesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownloadNatives();
        }

        private void loadNativesFromDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = loadFromFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                LoadNatives(loadFromFileDialog.FileName);
                RefreshNatiesListView();
            }
        }

        private void editSelectedNativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NativeFunction function = GetNativeFunction(SelectedHash);
            if (function == null) return;

            formEditNative frm = new formEditNative(function, this);
            frm.ShowDialog();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nativesHasChanged)
            {
                if (MessageBox.Show("Native functions has been changed. Do you want to export them now?", "Save changes",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DoExport(ExportFormat.JSON);
                }
            }
        }
    }
}
