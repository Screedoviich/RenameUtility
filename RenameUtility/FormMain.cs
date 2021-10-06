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
            FormTagsSettings.TagPhoto = "_IMG";
            FormTagsSettings.TagVideo = "_VID";
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
            if (FileInfoCount.FileInfoList.Count > 0)
            {
                ProgressBar.Maximum = FileInfoCount.FileInfoList.Count;
                ProgressBar.Value = 0;
                for (int i = 0; i < FileInfoCount.FileInfoList.Count; i++)
                {
                    if (methods.Checked(FileInfoCount.FileInfoList[i].FileName))
                    {
                        FileInfoCount.FileInfoList[i].FileNameNew = methods.ChangeName(FileInfoCount.FileInfoList[i].FileName, FormTagsSettings.Tags, FormTagsSettings.TagPhoto, FormTagsSettings.TagVideo, FormTagsSettings.TagSelf);
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
            else
            {
                MessageBox.Show("Нет выбранных файлов для переименования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //Существуют ли вообще файлы для сохранения
            if (FileInfoCount.FileInfoList.Count > 0)
            {
                //Флаг на присутствие хотя бы одного файла для сохранения
                bool renameTrue = false;
                for (int i = 0; i < FileInfoCount.FileInfoList.Count; i++)
                {
                    if (FileInfoCount.FileInfoList[i].FileRename)
                    {
                        File.Move(FileInfoCount.FileInfoList[i].FileDirectory + FileInfoCount.FileInfoList[i].FileName + FileInfoCount.FileInfoList[i].FileExtension, FileInfoCount.FileInfoList[i].FileDirectory + FileInfoCount.FileInfoList[i].FileNameNew + FileInfoCount.FileInfoList[i].FileExtension);
                        renameTrue = true;
                    }
                }
                if (renameTrue)
                {
                    MessageBox.Show("Все заданные файлы сохранены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файлы не нуждаются в переименовании", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Нет выбранных файлов для сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSaveIn_Click(object sender, EventArgs e)
        {
            if (FileInfoCount.FileInfoList.Count > 0)
            {
                if (methods.RenameTrue())
                {
                    var openFolder = new FolderBrowserDialog();
                    openFolder.ShowNewFolderButton = false;
                    openFolder.ShowDialog();
                    new FormSave(openFolder).ShowDialog();
                    MessageBox.Show("Все заданные файлы сохранены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файлы не нуждаются в переименовании", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Нет выбранных файлов для сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemChanges_Click(object sender, EventArgs e)
        {
            new FormChanges().Show();
        }

        private void MenuItemTagsSettings_Click(object sender, EventArgs e)
        {
            new FormTagsSettings().ShowDialog();
        }
    }
}
