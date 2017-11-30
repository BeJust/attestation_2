namespace _06._01._19
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
            this.Header = new System.Windows.Forms.Label();
            this.invitation = new System.Windows.Forms.Label();
            this.nameresult1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.nameresult2 = new System.Windows.Forms.Label();
            this.resultA = new System.Windows.Forms.Label();
            this.resultE = new System.Windows.Forms.Label();
            this.inputsym = new System.Windows.Forms.Label();
            this.inputSymb1 = new System.Windows.Forms.TextBox();
            this.inputSymb2 = new System.Windows.Forms.TextBox();
            this.inputsym2 = new System.Windows.Forms.Label();
            this.LogicResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header.Location = new System.Drawing.Point(147, 54);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(563, 24);
            this.Header.TabIndex = 0;
            this.Header.Text = "Сounting the amount of special symbols  in submitted string";
            // 
            // invitation
            // 
            this.invitation.AutoSize = true;
            this.invitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invitation.Location = new System.Drawing.Point(67, 197);
            this.invitation.Name = "invitation";
            this.invitation.Size = new System.Drawing.Size(191, 20);
            this.invitation.TabIndex = 1;
            this.invitation.Text = "Input your string here: ";
            // 
            // nameresult1
            // 
            this.nameresult1.AutoSize = true;
            this.nameresult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameresult1.Location = new System.Drawing.Point(78, 314);
            this.nameresult1.Name = "nameresult1";
            this.nameresult1.Size = new System.Drawing.Size(131, 20);
            this.nameresult1.TabIndex = 2;
            this.nameresult1.Text = "Amount of 1\'st:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(264, 197);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(322, 20);
            this.input.TabIndex = 5;
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run.Location = new System.Drawing.Point(623, 363);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(129, 80);
            this.run.TabIndex = 6;
            this.run.Text = "Count!";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // nameresult2
            // 
            this.nameresult2.AutoSize = true;
            this.nameresult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameresult2.Location = new System.Drawing.Point(361, 314);
            this.nameresult2.Name = "nameresult2";
            this.nameresult2.Size = new System.Drawing.Size(141, 20);
            this.nameresult2.TabIndex = 7;
            this.nameresult2.Text = "Amount of 2\'nd: ";
            // 
            // resultA
            // 
            this.resultA.AutoSize = true;
            this.resultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultA.Location = new System.Drawing.Point(211, 314);
            this.resultA.Name = "resultA";
            this.resultA.Size = new System.Drawing.Size(0, 20);
            this.resultA.TabIndex = 8;
            // 
            // resultE
            // 
            this.resultE.AutoSize = true;
            this.resultE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultE.Location = new System.Drawing.Point(499, 314);
            this.resultE.Name = "resultE";
            this.resultE.Size = new System.Drawing.Size(0, 20);
            this.resultE.TabIndex = 9;
            // 
            // inputsym
            // 
            this.inputsym.AutoSize = true;
            this.inputsym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputsym.Location = new System.Drawing.Point(12, 240);
            this.inputsym.Name = "inputsym";
            this.inputsym.Size = new System.Drawing.Size(189, 20);
            this.inputsym.TabIndex = 10;
            this.inputsym.Text = "Input your 1\'st symbol:";
            // 
            // inputSymb1
            // 
            this.inputSymb1.Location = new System.Drawing.Point(207, 240);
            this.inputSymb1.Name = "inputSymb1";
            this.inputSymb1.Size = new System.Drawing.Size(155, 20);
            this.inputSymb1.TabIndex = 11;
            // 
            // inputSymb2
            // 
            this.inputSymb2.Location = new System.Drawing.Point(652, 240);
            this.inputSymb2.Name = "inputSymb2";
            this.inputSymb2.Size = new System.Drawing.Size(135, 20);
            this.inputSymb2.TabIndex = 12;
            // 
            // inputsym2
            // 
            this.inputsym2.AutoSize = true;
            this.inputsym2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputsym2.Location = new System.Drawing.Point(452, 240);
            this.inputsym2.Name = "inputsym2";
            this.inputsym2.Size = new System.Drawing.Size(194, 20);
            this.inputsym2.TabIndex = 13;
            this.inputsym2.Text = "Input your 2\'nd symbol:";
            // 
            // LogicResult
            // 
            this.LogicResult.AutoSize = true;
            this.LogicResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogicResult.Location = new System.Drawing.Point(94, 394);
            this.LogicResult.Name = "LogicResult";
            this.LogicResult.Size = new System.Drawing.Size(0, 20);
            this.LogicResult.TabIndex = 14;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 515);
            this.Controls.Add(this.LogicResult);
            this.Controls.Add(this.inputsym2);
            this.Controls.Add(this.inputSymb2);
            this.Controls.Add(this.inputSymb1);
            this.Controls.Add(this.inputsym);
            this.Controls.Add(this.resultE);
            this.Controls.Add(this.resultA);
            this.Controls.Add(this.nameresult2);
            this.Controls.Add(this.run);
            this.Controls.Add(this.input);
            this.Controls.Add(this.nameresult1);
            this.Controls.Add(this.invitation);
            this.Controls.Add(this.Header);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label invitation;
        private System.Windows.Forms.Label nameresult1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label nameresult2;
        private System.Windows.Forms.Label resultA;
        private System.Windows.Forms.Label resultE;
        private System.Windows.Forms.Label inputsym;
        private System.Windows.Forms.TextBox inputSymb1;
        private System.Windows.Forms.TextBox inputSymb2;
        private System.Windows.Forms.Label inputsym2;
        private System.Windows.Forms.Label LogicResult;
    }
}

