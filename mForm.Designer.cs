namespace La2Coding
{
    partial class mForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.iFolderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iExt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вUTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вANSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iOpenFolder = new System.Windows.Forms.Button();
            this.iFolderPath = new System.Windows.Forms.TextBox();
            this.fbdOpen = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.iFolderName,
            this.iFileName,
            this.iExt});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(491, 297);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // iFolderName
            // 
            this.iFolderName.Text = "Имя папки";
            this.iFolderName.Width = 132;
            // 
            // iFileName
            // 
            this.iFileName.Text = "Имя файла";
            this.iFileName.Width = 86;
            // 
            // iExt
            // 
            this.iExt.Text = "Рашрирение";
            this.iExt.Width = 93;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripMenuItem1,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "&Выход";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вUTF8ToolStripMenuItem,
            this.вANSIToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 20);
            this.toolStripMenuItem1.Text = "Перекодировать";
            // 
            // вUTF8ToolStripMenuItem
            // 
            this.вUTF8ToolStripMenuItem.Name = "вUTF8ToolStripMenuItem";
            this.вUTF8ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.вUTF8ToolStripMenuItem.Text = "В UTF-8";
            this.вUTF8ToolStripMenuItem.Click += new System.EventHandler(this.вUTF8ToolStripMenuItem_Click);
            // 
            // вANSIToolStripMenuItem
            // 
            this.вANSIToolStripMenuItem.Name = "вANSIToolStripMenuItem";
            this.вANSIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.вANSIToolStripMenuItem.Text = "В ANSI";
            this.вANSIToolStripMenuItem.Click += new System.EventHandler(this.вANSIToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iOpenFolder);
            this.panel1.Controls.Add(this.iFolderPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 26);
            this.panel1.TabIndex = 2;
            // 
            // iOpenFolder
            // 
            this.iOpenFolder.Location = new System.Drawing.Point(387, 1);
            this.iOpenFolder.Name = "iOpenFolder";
            this.iOpenFolder.Size = new System.Drawing.Size(92, 23);
            this.iOpenFolder.TabIndex = 1;
            this.iOpenFolder.Text = "Открыть";
            this.iOpenFolder.UseVisualStyleBackColor = true;
            this.iOpenFolder.Click += new System.EventHandler(this.iOpenFolder_Click);
            // 
            // iFolderPath
            // 
            this.iFolderPath.Location = new System.Drawing.Point(3, 3);
            this.iFolderPath.Name = "iFolderPath";
            this.iFolderPath.ReadOnly = true;
            this.iFolderPath.Size = new System.Drawing.Size(378, 20);
            this.iFolderPath.TabIndex = 0;
            // 
            // fbdOpen
            // 
            this.fbdOpen.ShowNewFolderButton = false;
            // 
            // mForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 347);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader iFolderName;
        private System.Windows.Forms.ColumnHeader iFileName;
        private System.Windows.Forms.ColumnHeader iExt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button iOpenFolder;
        private System.Windows.Forms.TextBox iFolderPath;
        private System.Windows.Forms.FolderBrowserDialog fbdOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вUTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вANSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
    }
}

