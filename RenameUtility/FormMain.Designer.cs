namespace RenameUtility
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonOpenFolder = new System.Windows.Forms.Button();
            this.TextBoxFolder = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReference = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNameNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFileExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridRename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ButtonStartRename = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonSaveIn = new System.Windows.Forms.Button();
            this.CheckBoxTags = new System.Windows.Forms.CheckBox();
            this.MenuItemTagsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonOpenFolder
            // 
            this.ButtonOpenFolder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOpenFolder.Location = new System.Drawing.Point(32, 49);
            this.ButtonOpenFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOpenFolder.Name = "ButtonOpenFolder";
            this.ButtonOpenFolder.Size = new System.Drawing.Size(165, 30);
            this.ButtonOpenFolder.TabIndex = 0;
            this.ButtonOpenFolder.Text = "Выбрать папку...";
            this.ButtonOpenFolder.UseVisualStyleBackColor = true;
            this.ButtonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolder_Click);
            // 
            // TextBoxFolder
            // 
            this.TextBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFolder.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFolder.Location = new System.Drawing.Point(213, 49);
            this.TextBoxFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxFolder.Multiline = true;
            this.TextBoxFolder.Name = "TextBoxFolder";
            this.TextBoxFolder.ReadOnly = true;
            this.TextBoxFolder.Size = new System.Drawing.Size(592, 29);
            this.TextBoxFolder.TabIndex = 1;
            this.TextBoxFolder.TabStop = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFolder,
            this.MenuItemReference});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(839, 30);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuItemFolder
            // 
            this.MenuItemFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTagsSettings,
            this.MenuItemExit});
            this.MenuItemFolder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuItemFolder.Name = "MenuItemFolder";
            this.MenuItemFolder.Size = new System.Drawing.Size(59, 26);
            this.MenuItemFolder.Text = "Файл";
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(224, 26);
            this.MenuItemExit.Text = "Выход";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemReference
            // 
            this.MenuItemReference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChanges,
            this.MenuItemAboutProgram});
            this.MenuItemReference.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuItemReference.Name = "MenuItemReference";
            this.MenuItemReference.Size = new System.Drawing.Size(82, 26);
            this.MenuItemReference.Text = "Справка";
            // 
            // MenuItemChanges
            // 
            this.MenuItemChanges.Name = "MenuItemChanges";
            this.MenuItemChanges.Size = new System.Drawing.Size(185, 26);
            this.MenuItemChanges.Text = "Изменения";
            this.MenuItemChanges.Click += new System.EventHandler(this.MenuItemChanges_Click);
            // 
            // MenuItemAboutProgram
            // 
            this.MenuItemAboutProgram.Name = "MenuItemAboutProgram";
            this.MenuItemAboutProgram.Size = new System.Drawing.Size(185, 26);
            this.MenuItemAboutProgram.Text = "О программе";
            this.MenuItemAboutProgram.Click += new System.EventHandler(this.MenuItemAboutProgram_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridName,
            this.GridNameNew,
            this.GridFileExtension,
            this.GridExtension,
            this.GridRename});
            this.DataGrid.Location = new System.Drawing.Point(213, 98);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.Size = new System.Drawing.Size(594, 325);
            this.DataGrid.TabIndex = 4;
            this.DataGrid.TabStop = false;
            // 
            // GridName
            // 
            this.GridName.DataPropertyName = "FileName";
            this.GridName.FillWeight = 89.0863F;
            this.GridName.HeaderText = "Имя";
            this.GridName.MinimumWidth = 50;
            this.GridName.Name = "GridName";
            this.GridName.ReadOnly = true;
            this.GridName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GridNameNew
            // 
            this.GridNameNew.DataPropertyName = "FileNameNew";
            this.GridNameNew.FillWeight = 89.0863F;
            this.GridNameNew.HeaderText = "Новое имя";
            this.GridNameNew.MinimumWidth = 50;
            this.GridNameNew.Name = "GridNameNew";
            this.GridNameNew.ReadOnly = true;
            this.GridNameNew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GridFileExtension
            // 
            this.GridFileExtension.DataPropertyName = "FileExtension";
            this.GridFileExtension.FillWeight = 40F;
            this.GridFileExtension.HeaderText = "Расширение";
            this.GridFileExtension.MinimumWidth = 50;
            this.GridFileExtension.Name = "GridFileExtension";
            this.GridFileExtension.ReadOnly = true;
            this.GridFileExtension.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GridExtension
            // 
            this.GridExtension.DataPropertyName = "FileDirectory";
            this.GridExtension.HeaderText = "Директория";
            this.GridExtension.MinimumWidth = 6;
            this.GridExtension.Name = "GridExtension";
            this.GridExtension.ReadOnly = true;
            this.GridExtension.Visible = false;
            // 
            // GridRename
            // 
            this.GridRename.DataPropertyName = "FileRename";
            this.GridRename.HeaderText = "Rename";
            this.GridRename.MinimumWidth = 6;
            this.GridRename.Name = "GridRename";
            this.GridRename.ReadOnly = true;
            this.GridRename.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(32, 246);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(165, 30);
            this.ProgressBar.TabIndex = 5;
            // 
            // ButtonStartRename
            // 
            this.ButtonStartRename.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStartRename.Location = new System.Drawing.Point(32, 98);
            this.ButtonStartRename.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStartRename.Name = "ButtonStartRename";
            this.ButtonStartRename.Size = new System.Drawing.Size(165, 30);
            this.ButtonStartRename.TabIndex = 1;
            this.ButtonStartRename.Text = "Переименовать";
            this.ButtonStartRename.UseVisualStyleBackColor = true;
            this.ButtonStartRename.Click += new System.EventHandler(this.ButtonStartRename_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(32, 148);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(165, 30);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonSaveIn
            // 
            this.ButtonSaveIn.Location = new System.Drawing.Point(32, 197);
            this.ButtonSaveIn.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSaveIn.Name = "ButtonSaveIn";
            this.ButtonSaveIn.Size = new System.Drawing.Size(165, 30);
            this.ButtonSaveIn.TabIndex = 3;
            this.ButtonSaveIn.Text = "Сохранить в...";
            this.ButtonSaveIn.UseVisualStyleBackColor = true;
            this.ButtonSaveIn.Click += new System.EventHandler(this.ButtonSaveIn_Click);
            // 
            // CheckBoxTags
            // 
            this.CheckBoxTags.AutoSize = true;
            this.CheckBoxTags.Location = new System.Drawing.Point(32, 296);
            this.CheckBoxTags.Name = "CheckBoxTags";
            this.CheckBoxTags.Size = new System.Drawing.Size(196, 21);
            this.CheckBoxTags.TabIndex = 6;
            this.CheckBoxTags.Text = "Теги в конце названия";
            this.CheckBoxTags.UseVisualStyleBackColor = true;
            // 
            // MenuItemTagsSettings
            // 
            this.MenuItemTagsSettings.Name = "MenuItemTagsSettings";
            this.MenuItemTagsSettings.Size = new System.Drawing.Size(224, 26);
            this.MenuItemTagsSettings.Text = "Настройки тегов";
            this.MenuItemTagsSettings.Click += new System.EventHandler(this.MenuItemTagsSettings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.CheckBoxTags);
            this.Controls.Add(this.ButtonSaveIn);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonStartRename);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.TextBoxFolder);
            this.Controls.Add(this.ButtonOpenFolder);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(394, 358);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenameUtility";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonOpenFolder;
        private System.Windows.Forms.TextBox TextBoxFolder;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFolder;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReference;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAboutProgram;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button ButtonStartRename;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonSaveIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridNameNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridFileExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridRename;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChanges;
        private System.Windows.Forms.CheckBox CheckBoxTags;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTagsSettings;
    }
}

