namespace _09._01._19
{
    partial class MainWindow
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
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.inputGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.OutputSectionGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputTextLbl = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).BeginInit();
            this.OutputSectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadFileDialog
            // 
            this.LoadFileDialog.FileName = "openFileDialog1";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(771, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileOpen,
            this.MainMenuFileSave,
            this.MainMenuFileClose});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MainMenuFileOpen
            // 
            this.MainMenuFileOpen.Name = "MainMenuFileOpen";
            this.MainMenuFileOpen.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileOpen.Text = "Открыть";
            this.MainMenuFileOpen.Click += new System.EventHandler(this.MainMenuFileOpen_Click);
            // 
            // MainMenuFileSave
            // 
            this.MainMenuFileSave.Name = "MainMenuFileSave";
            this.MainMenuFileSave.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileSave.Text = "Сохранить";
            this.MainMenuFileSave.Click += new System.EventHandler(this.MainMenuFileSave_Click);
            // 
            // MainMenuFileClose
            // 
            this.MainMenuFileClose.Name = "MainMenuFileClose";
            this.MainMenuFileClose.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileClose.Text = "Закрыть";
            this.MainMenuFileClose.Click += new System.EventHandler(this.MainMenuFileClose_Click);
            // 
            // inputGridView
            // 
            this.inputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.inputGridView.Location = new System.Drawing.Point(12, 27);
            this.inputGridView.Name = "inputGridView";
            this.inputGridView.Size = new System.Drawing.Size(747, 239);
            this.inputGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(12, 273);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(747, 57);
            this.ProcessBtn.TabIndex = 2;
            this.ProcessBtn.Text = "Выполнить";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // OutputSectionGroupBox
            // 
            this.OutputSectionGroupBox.Controls.Add(this.OutputTextLbl);
            this.OutputSectionGroupBox.Location = new System.Drawing.Point(13, 337);
            this.OutputSectionGroupBox.Name = "OutputSectionGroupBox";
            this.OutputSectionGroupBox.Size = new System.Drawing.Size(746, 129);
            this.OutputSectionGroupBox.TabIndex = 3;
            this.OutputSectionGroupBox.TabStop = false;
            this.OutputSectionGroupBox.Text = "Результат вычислений:";
            // 
            // OutputTextLbl
            // 
            this.OutputTextLbl.AutoSize = true;
            this.OutputTextLbl.Location = new System.Drawing.Point(15, 25);
            this.OutputTextLbl.Name = "OutputTextLbl";
            this.OutputTextLbl.Size = new System.Drawing.Size(0, 13);
            this.OutputTextLbl.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 476);
            this.Controls.Add(this.OutputSectionGroupBox);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.inputGridView);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load_1);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).EndInit();
            this.OutputSectionGroupBox.ResumeLayout(false);
            this.OutputSectionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog LoadFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileClose;
        private System.Windows.Forms.DataGridView inputGridView;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.GroupBox OutputSectionGroupBox;
        private System.Windows.Forms.Label OutputTextLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

