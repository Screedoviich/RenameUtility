namespace RenameUtility
{
    partial class FormSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSave));
            this.ProgressBarSave = new System.Windows.Forms.ProgressBar();
            this.LabelSave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBarSave
            // 
            this.ProgressBarSave.Location = new System.Drawing.Point(16, 16);
            this.ProgressBarSave.Name = "ProgressBarSave";
            this.ProgressBarSave.Size = new System.Drawing.Size(352, 23);
            this.ProgressBarSave.TabIndex = 0;
            // 
            // LabelSave
            // 
            this.LabelSave.AutoSize = true;
            this.LabelSave.Location = new System.Drawing.Point(16, 56);
            this.LabelSave.Name = "LabelSave";
            this.LabelSave.Size = new System.Drawing.Size(0, 13);
            this.LabelSave.TabIndex = 1;
            // 
            // FormSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 115);
            this.Controls.Add(this.LabelSave);
            this.Controls.Add(this.ProgressBarSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 150);
            this.MinimumSize = new System.Drawing.Size(400, 150);
            this.Name = "FormSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сохранение...";
            this.Shown += new System.EventHandler(this.FormSave_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ProgressBar ProgressBarSave;
        public System.Windows.Forms.Label LabelSave;
    }
}