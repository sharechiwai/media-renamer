using System.Drawing.Imaging;
using Media_Renamer.Helpers;

namespace Media_Renamer
{
    public partial class frmMediaRenamer : Form
    {
        public frmMediaRenamer()
        {
            InitializeComponent();
            string basePath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            txtSourceFolder.Text = Path.Combine(basePath, "Test", "original");
            txtDestination.Text = Path.Combine(basePath, "Test", "processed");
        }

        private void btnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            string basePath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            string defaultFolder = Path.Combine(basePath, "Test", "original");

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select a folder",
                SelectedPath = defaultFolder,
                ShowNewFolderButton = true
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                txtSourceFolder.Text = selectedFolderPath;
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            string basePath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            string defaultFolder = Path.Combine(basePath, "Test", "processed");
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select a folder",
                SelectedPath = defaultFolder,
                ShowNewFolderButton = true
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                txtDestination.Text = selectedFolderPath;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            ProcessRenamFiles(txtSourceFolder.Text, txtDestination.Text);
            MessageBox.Show("Completed");
        }

        private void ProcessRenamFiles(string sourceFolder, string destinationFolder)
        {


            if (!Directory.Exists(sourceFolder))
            {
                MessageBox.Show($"Source folder: {sourceFolder} does not exist!", "Error Soruce Folder not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(destinationFolder))
            {
                MessageBox.Show($"Destination folder: {destinationFolder} does not exist!", "Error Destination Folder not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sourceFiles = Directory.GetFiles(sourceFolder);
            if (sourceFiles.Count() == 0)
            {
                MessageBox.Show($"Source folder: {sourceFolder} does not contain files!", "Error Source Folder does not contain files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var file in sourceFiles)
            {
                string ext = Path.GetExtension(file).ToLower();
                DateTime dateTaken;
                string formattedDate = "";

                var fname = Path.GetFileName(file);
                if (Utils.IsValidFilenameFormatWithDate(fname))
                {
                    formattedDate = Path.GetFileNameWithoutExtension(file);
                }
                else
                {
                    try
                    {
                        if (ext == ".jpg" || ext == ".jpeg" || ext == ".png")
                        {
                            // For images
                            using (var img = Image.FromFile(file))
                            {
                                PropertyItem prop = img.GetPropertyItem(36867); // 36867 is the ID for DateTimeOriginal
                                if (prop != null)
                                {
                                    string dateTakenString = System.Text.Encoding.UTF8.GetString(prop.Value).Trim('\0');

                                    bool success = DateTime.TryParseExact(dateTakenString, "yyyy:MM:dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out dateTaken);
                                    if (success)
                                    {
                                        formattedDate = dateTaken.ToString("yyyyMMdd_HHmmss");

                                    }
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }




                if (formattedDate != "")
                {


                    string newName = $"{formattedDate}.{ext}";
                    string newPath = Path.Combine(destinationFolder, newName);
                    File.Move(file, newPath);

                }
            }
        }

    }
}
