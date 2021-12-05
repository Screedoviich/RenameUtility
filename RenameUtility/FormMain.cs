using System;
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
            //Стандартные значения тегов для изображений и видеофайлов.
            FormTagsSettings.TagPhoto = "_IMG";
            FormTagsSettings.TagVideo = "_VID";
        }

        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            var openFolder = new FolderBrowserDialog();
            openFolder.ShowNewFolderButton = false;
            openFolder.ShowDialog();
            if(methods.CheckedSetFolder(openFolder.SelectedPath, TextBoxFolder))
            {
                ButtonSave.Enabled = true;
                ButtonSaveIn.Enabled = true;
            }
        }

        private void MenuItemAboutProgram_Click(object sender, EventArgs e)
        {
            new FormAboutProgram().Show();
        }

        private void ButtonStartRename_Click(object sender, EventArgs e)
        {
            methods.StartRename(this);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //false - Сохранение в одной и той же папке. SaveChecked ведёт на метод сохранения.
            methods.SaveChecked(false, ButtonSave, ButtonSaveIn);
        }

        private void ButtonSaveIn_Click(object sender, EventArgs e)
        {
            //true - Сохранение в папке, которую укажет пользователь. SaveChecked ведёт на метод сохранения.
            methods.SaveChecked(true, null, null);
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
