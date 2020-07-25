namespace RenameUtility
{
    partial class FormTagsSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTagsSettings));
            this.GroupBoxTagsSettings1 = new System.Windows.Forms.GroupBox();
            this.LabelPhoto = new System.Windows.Forms.Label();
            this.LabelVideo = new System.Windows.Forms.Label();
            this.GroupBoxTagsSettings2 = new System.Windows.Forms.GroupBox();
            this.LabelSelf = new System.Windows.Forms.Label();
            this.TextBoxTagPhoto = new System.Windows.Forms.TextBox();
            this.TextBoxTagVideo = new System.Windows.Forms.TextBox();
            this.TextBoxTagSelf = new System.Windows.Forms.TextBox();
            this.GroupBoxTagsSettings1.SuspendLayout();
            this.GroupBoxTagsSettings2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxTagsSettings1
            // 
            this.GroupBoxTagsSettings1.Controls.Add(this.TextBoxTagVideo);
            this.GroupBoxTagsSettings1.Controls.Add(this.TextBoxTagPhoto);
            this.GroupBoxTagsSettings1.Controls.Add(this.LabelVideo);
            this.GroupBoxTagsSettings1.Controls.Add(this.LabelPhoto);
            this.GroupBoxTagsSettings1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxTagsSettings1.Location = new System.Drawing.Point(24, 8);
            this.GroupBoxTagsSettings1.Name = "GroupBoxTagsSettings1";
            this.GroupBoxTagsSettings1.Size = new System.Drawing.Size(224, 100);
            this.GroupBoxTagsSettings1.TabIndex = 0;
            this.GroupBoxTagsSettings1.TabStop = false;
            this.GroupBoxTagsSettings1.Text = "Метки для фото и видео";
            // 
            // LabelPhoto
            // 
            this.LabelPhoto.AutoSize = true;
            this.LabelPhoto.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhoto.Location = new System.Drawing.Point(8, 32);
            this.LabelPhoto.Name = "LabelPhoto";
            this.LabelPhoto.Size = new System.Drawing.Size(50, 17);
            this.LabelPhoto.TabIndex = 0;
            this.LabelPhoto.Text = "Фото:";
            // 
            // LabelVideo
            // 
            this.LabelVideo.AutoSize = true;
            this.LabelVideo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVideo.Location = new System.Drawing.Point(8, 64);
            this.LabelVideo.Name = "LabelVideo";
            this.LabelVideo.Size = new System.Drawing.Size(59, 17);
            this.LabelVideo.TabIndex = 0;
            this.LabelVideo.Text = "Видео:";
            // 
            // GroupBoxTagsSettings2
            // 
            this.GroupBoxTagsSettings2.Controls.Add(this.TextBoxTagSelf);
            this.GroupBoxTagsSettings2.Controls.Add(this.LabelSelf);
            this.GroupBoxTagsSettings2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxTagsSettings2.Location = new System.Drawing.Point(24, 120);
            this.GroupBoxTagsSettings2.Name = "GroupBoxTagsSettings2";
            this.GroupBoxTagsSettings2.Size = new System.Drawing.Size(224, 100);
            this.GroupBoxTagsSettings2.TabIndex = 0;
            this.GroupBoxTagsSettings2.TabStop = false;
            this.GroupBoxTagsSettings2.Text = "Свои теги";
            // 
            // LabelSelf
            // 
            this.LabelSelf.AutoSize = true;
            this.LabelSelf.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelf.Location = new System.Drawing.Point(8, 24);
            this.LabelSelf.Name = "LabelSelf";
            this.LabelSelf.Size = new System.Drawing.Size(199, 34);
            this.LabelSelf.TabIndex = 0;
            this.LabelSelf.Text = "Введите собственный тег \r\nв конце файла:";
            // 
            // TextBoxTagPhoto
            // 
            this.TextBoxTagPhoto.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTagPhoto.Location = new System.Drawing.Point(72, 32);
            this.TextBoxTagPhoto.Name = "TextBoxTagPhoto";
            this.TextBoxTagPhoto.Size = new System.Drawing.Size(136, 23);
            this.TextBoxTagPhoto.TabIndex = 0;
            // 
            // TextBoxTagVideo
            // 
            this.TextBoxTagVideo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTagVideo.Location = new System.Drawing.Point(72, 64);
            this.TextBoxTagVideo.Name = "TextBoxTagVideo";
            this.TextBoxTagVideo.Size = new System.Drawing.Size(136, 23);
            this.TextBoxTagVideo.TabIndex = 1;
            // 
            // TextBoxTagSelf
            // 
            this.TextBoxTagSelf.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTagSelf.Location = new System.Drawing.Point(8, 64);
            this.TextBoxTagSelf.Name = "TextBoxTagSelf";
            this.TextBoxTagSelf.Size = new System.Drawing.Size(200, 23);
            this.TextBoxTagSelf.TabIndex = 2;
            // 
            // FormTagsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 223);
            this.Controls.Add(this.GroupBoxTagsSettings2);
            this.Controls.Add(this.GroupBoxTagsSettings1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 270);
            this.MinimumSize = new System.Drawing.Size(290, 270);
            this.Name = "FormTagsSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Настройки тегов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTagsSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormTagsSettings_Load);
            this.GroupBoxTagsSettings1.ResumeLayout(false);
            this.GroupBoxTagsSettings1.PerformLayout();
            this.GroupBoxTagsSettings2.ResumeLayout(false);
            this.GroupBoxTagsSettings2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxTagsSettings1;
        private System.Windows.Forms.Label LabelVideo;
        private System.Windows.Forms.Label LabelPhoto;
        private System.Windows.Forms.GroupBox GroupBoxTagsSettings2;
        private System.Windows.Forms.Label LabelSelf;
        private System.Windows.Forms.TextBox TextBoxTagVideo;
        private System.Windows.Forms.TextBox TextBoxTagPhoto;
        private System.Windows.Forms.TextBox TextBoxTagSelf;
    }
}