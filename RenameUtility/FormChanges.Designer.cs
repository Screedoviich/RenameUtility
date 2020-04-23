namespace RenameUtility
{
    partial class FormChanges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChanges));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox201 = new System.Windows.Forms.GroupBox();
            this.Label201 = new System.Windows.Forms.Label();
            this.GroupBox202 = new System.Windows.Forms.GroupBox();
            this.Label202 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GroupBox201.SuspendLayout();
            this.GroupBox202.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.GroupBox202);
            this.panel1.Controls.Add(this.GroupBox201);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 264);
            this.panel1.TabIndex = 0;
            // 
            // GroupBox201
            // 
            this.GroupBox201.Controls.Add(this.Label201);
            this.GroupBox201.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBox201.Location = new System.Drawing.Point(8, 88);
            this.GroupBox201.Name = "GroupBox201";
            this.GroupBox201.Size = new System.Drawing.Size(352, 88);
            this.GroupBox201.TabIndex = 0;
            this.GroupBox201.TabStop = false;
            this.GroupBox201.Text = "Версия 2.0.1_GUI";
            // 
            // Label201
            // 
            this.Label201.AutoSize = true;
            this.Label201.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label201.Location = new System.Drawing.Point(8, 24);
            this.Label201.Name = "Label201";
            this.Label201.Size = new System.Drawing.Size(333, 52);
            this.Label201.TabIndex = 0;
            this.Label201.Text = "При нажатии на клавишу \"Сохранить в...\", файлы\r\nбудут скопированы в новую папку н" +
    "е изменяя старые\r\nфайлы. Скопированы будут только те файлы, которые\r\nподлежат ре" +
    "дактированию.";
            // 
            // GroupBox202
            // 
            this.GroupBox202.Controls.Add(this.Label202);
            this.GroupBox202.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBox202.Location = new System.Drawing.Point(8, 8);
            this.GroupBox202.Name = "GroupBox202";
            this.GroupBox202.Size = new System.Drawing.Size(352, 72);
            this.GroupBox202.TabIndex = 0;
            this.GroupBox202.TabStop = false;
            this.GroupBox202.Text = "Версия 2.0.2_GUI";
            // 
            // Label202
            // 
            this.Label202.AutoSize = true;
            this.Label202.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label202.Location = new System.Drawing.Point(8, 24);
            this.Label202.Name = "Label202";
            this.Label202.Size = new System.Drawing.Size(321, 39);
            this.Label202.TabIndex = 0;
            this.Label202.Text = "Теперь появилась возможность устанавливать метки\r\nпосле названия файла.\r\nДля виде" +
    "о VID, для фотографий IMG.";
            // 
            // FormChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 265);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormChanges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменения";
            this.panel1.ResumeLayout(false);
            this.GroupBox201.ResumeLayout(false);
            this.GroupBox201.PerformLayout();
            this.GroupBox202.ResumeLayout(false);
            this.GroupBox202.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GroupBox201;
        private System.Windows.Forms.Label Label201;
        private System.Windows.Forms.GroupBox GroupBox202;
        private System.Windows.Forms.Label Label202;
    }
}