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
    public partial class FormTagsSettings : Form
    {
        public static string TagPhoto { get; set; }
        public static string TagVideo { get; set; }
        public static string TagSelf { get; set; }

        public FormTagsSettings()
        {
            InitializeComponent();
        }

        private void FormTagsSettings_Load(object sender, EventArgs e)
        {
            TextBoxTagPhoto.Text = TagPhoto;
            TextBoxTagVideo.Text = TagVideo;
            TextBoxTagSelf.Text = TagSelf;
        }

        private void FormTagsSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            TagPhoto = TextBoxTagPhoto.Text;
            TagVideo = TextBoxTagVideo.Text;
            TagSelf = TextBoxTagSelf.Text;
        }
    }
}
