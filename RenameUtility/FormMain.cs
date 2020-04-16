using System;
using System.IO;
using System.Windows.Forms;

namespace RenameUtility
{
    public partial class FormMain : Form
    {
        public Methods methods = new Methods();

        public FormMain()
        {
            InitializeComponent();
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            DataGrid.DataSource = FileInfoCount.FileInfoList;
        }

        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            var openFolder = new FolderBrowserDialog();
            openFolder.ShowNewFolderButton = false;
            openFolder.ShowDialog();
            methods.CheckedSetFolder(openFolder, TextBoxFolder, ProgressBar);
        }

        private void MenuItemAboutProgram_Click(object sender, EventArgs e)
        {
            new FormAboutProgram().Show();
        }

        private void ButtonStartRename_Click(object sender, EventArgs e)
        {
            ProgressBar.Maximum = FileInfoCount.FileInfoList.Count;
            for (int i = 0; i < FileInfoCount.FileInfoList.Count; i++)
            {
                if (methods.Checked(FileInfoCount.FileInfoList[i].FileName))
                {
                    FileInfoCount.FileInfoList[i].FileNameNew = methods.ChangeName(FileInfoCount.FileInfoList[i].FileName);
                    FileInfoCount.FileInfoList[i].FileRename = true;
                }
                else
                {
                    FileInfoCount.FileInfoList[i].FileNameNew = "Файл не нуждается в переименовании";
                    FileInfoCount.FileInfoList[i].FileRename = false;
                }
                ProgressBar.Value++;
            }
            Refresh();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileInfoCount.FileInfoList.Count; i++)
            {
                if (FileInfoCount.FileInfoList[i].FileRename)
                {
                    File.Move(FileInfoCount.FileInfoList[i].FileDirectory + FileInfoCount.FileInfoList[i].FileName + FileInfoCount.FileInfoList[i].FileExtension, FileInfoCount.FileInfoList[i].FileDirectory + FileInfoCount.FileInfoList[i].FileNameNew + FileInfoCount.FileInfoList[i].FileExtension);
                }
            }
            MessageBox.Show("Все заданные файлы сохранены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSaveIn_Click(object sender, EventArgs e)
        {
            var openFolder = new FolderBrowserDialog();
            openFolder.ShowNewFolderButton = false;
            openFolder.ShowDialog();
            new FormSave(openFolder).ShowDialog();
            MessageBox.Show("Все заданные файлы сохранены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemChanges_Click(object sender, EventArgs e)
        {
            new FormChanges().Show();
        }
    }
}
