using System;
using System.Windows.Forms;

namespace RenameUtility
{
    public partial class FormSave : Form
    {
        private FolderBrowserDialog folder { get; set; }
        public FormSave(FolderBrowserDialog openFoler)
        {
            InitializeComponent();
            folder = openFoler;
        }

        private void FormSave_Show(object sender, EventArgs e)
        {
            new Methods().SaveIn(folder, this);
            Close();
        }
    }
}
