using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameUtility
{
    public partial class FormSave : Form
    {
        private FolderBrowserDialog folder;
        public FormSave(FolderBrowserDialog openFoler)
        {
            InitializeComponent();
            folder = openFoler;
        }

        private void FormSave_Shown(object sender, EventArgs e)
        {
            new Methods().SaveIn(folder, this);
            Close();
        }
    }
}
