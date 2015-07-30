using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;

namespace NDBB
{
    public partial class formMain
    {
        // Downloads natives from http://www.dev-c.com/nativedb/natives.json
        void DownloadNatives()
        {
            if (MessageBox.Show(
                "Fresh natives.json will be downloaded from http://www.dev-c.com/nativedb/natives.json. Continue?",
                "Download natives.json", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileCompleted += (object sender, System.ComponentModel.AsyncCompletedEventArgs e) =>
                        {
                            if (e.Error == null && !e.Cancelled)
                            {
                                FileInfo downloadedFile = new FileInfo(DownloadNativesGZPath);
                                if (downloadedFile.Exists && downloadedFile.Length > 100)
                                {
                                    try
                                    {
                                        using (FileStream gzFile = downloadedFile.OpenRead())
                                        using (FileStream jsonFile = File.Create(DownloadNativesPath))
                                        using (GZipStream gzStream = new GZipStream(gzFile, CompressionMode.Decompress))
                                            gzStream.CopyTo(jsonFile);

                                        if (File.Exists(DownloadNativesPath))
                                        {
                                            File.Delete(DownloadNativesGZPath);

                                            if (MessageBox.Show("Downloading natives.json has been completed and it\'s been saved as " + DownloadNativesPath + ".\nPress OK to reload the natives",
                                                "Download complete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                                                == System.Windows.Forms.DialogResult.OK)
                                            {
                                                if (NativeManager.LocalNativesExist)
                                                    File.Delete(NativeManager.LocalNatives);
                                                File.Move(DownloadNativesPath, Path.Combine(Directory.GetCurrentDirectory(), "natives.json"));

                                                if (NativeManager.LocalNativesExist)
                                                {
                                                    LoadNatives(NativeManager.LocalNatives);
                                                    RefreshNatiesListView();
                                                }
                                                else
                                                {
                                                    File.Delete(DownloadNativesPath);
                                                    MessageBox.Show("Something went wrong while loading the new natives.json!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("An error occured while updating natives.json:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    File.Delete(DownloadNativesGZPath);
                                    MessageBox.Show("natives.json couldn\'t be downloaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                File.Decrypt(DownloadNativesGZPath);
                                MessageBox.Show("Something went wrong while downloading natives.json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        };

                    File.Delete(DownloadNativesPath);

                    wc.Headers["Accept"] = "text/html, application/xhtml+xml, */*";
                    wc.Headers["Accept-Encoding"] = "gzip, deflate";
                    wc.Headers["Accept-Lanugage"] = "en-US,en;q=0.7,fa;q=0.3";
                    wc.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";
                    wc.DownloadFileAsync(new Uri("http://www.dev-c.com/nativedb/natives.json"), DownloadNativesGZPath);
                }
            }
        }

        String DownloadNativesPath
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "new_natives.json");
            }
        }

        String DownloadNativesGZPath
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "new_natives.json.gz");
            }
        }

        // Updates an existing native function with new data
        public void UpdateNative(String hash, NativeFunction newFunction)
        {
            nativesHasChanged = true;
            NativeFunction function = GetNativeFunction(hash);

            function.Name = newFunction.Name;
            function.Result = newFunction.Result;
            function.Params = newFunction.Params;

            ShowNativesFor(SelectedNamespaceName, true);
            RefreshNatiesListView(false);
        }
    }
}
