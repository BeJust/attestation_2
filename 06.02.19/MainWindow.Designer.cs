namespace _06._02._19
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
            this.run = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.getX = new System.Windows.Forms.Label();
            this.inputee = new System.Windows.Forms.Label();
            this.inputx = new System.Windows.Forms.TextBox();
            this.inpute = new System.Windows.Forms.TextBox();
            this.result1 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.result3 = new System.Windows.Forms.Label();
            this.result4 = new System.Windows.Forms.Label();
            this.headerN = new System.Windows.Forms.Label();
            this.resultN = new System.Windows.Forms.Label();
            this.resulte10 = new System.Windows.Forms.Label();
            this.resultediv10 = new System.Windows.Forms.Label();
            this.resultsum = new System.Windows.Forms.Label();
            this.resultsume = new System.Windows.Forms.Label();
            this.resultsume10 = new System.Windows.Forms.Label();
            this.resultfunction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run.Location = new System.Drawing.Point(59, 291);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(171, 76);
            this.run.TabIndex = 0;
            this.run.Text = "Start";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(39, 28);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(426, 24);
            this.header.TabIndex = 1;
            this.header.Text = "cos(x) = 1 - (x^2/2!) +   (x^4/4!) - (x^6/6!) + ...\r\n";
            // 
            // getX
            // 
            this.getX.AutoSize = true;
            this.getX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getX.Location = new System.Drawing.Point(100, 105);
            this.getX.Name = "getX";
            this.getX.Size = new System.Drawing.Size(36, 20);
            this.getX.TabIndex = 2;
            this.getX.Text = "X =";
            // 
            // inputee
            // 
            this.inputee.AutoSize = true;
            this.inputee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputee.Location = new System.Drawing.Point(100, 145);
            this.inputee.Name = "inputee";
            this.inputee.Size = new System.Drawing.Size(34, 20);
            this.inputee.TabIndex = 4;
            this.inputee.Text = "e =";
            // 
            // inputx
            // 
            this.inputx.Location = new System.Drawing.Point(142, 107);
            this.inputx.Name = "inputx";
            this.inputx.Size = new System.Drawing.Size(88, 20);
            this.inputx.TabIndex = 6;
            // 
            // inpute
            // 
            this.inpute.Location = new System.Drawing.Point(142, 145);
            this.inpute.Name = "inpute";
            this.inpute.Size = new System.Drawing.Size(88, 20);
            this.inpute.TabIndex = 7;
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result1.Location = new System.Drawing.Point(573, 105);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(57, 20);
            this.result1.TabIndex = 9;
            this.result1.Text = "sum =";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result2.Location = new System.Drawing.Point(577, 145);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(72, 20);
            this.result2.TabIndex = 10;
            this.result2.Text = "sum e =";
            // 
            // result3
            // 
            this.result3.AutoSize = true;
            this.result3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result3.Location = new System.Drawing.Point(580, 181);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(97, 20);
            this.result3.TabIndex = 11;
            this.result3.Text = "sum e/10 =";
            // 
            // result4
            // 
            this.result4.AutoSize = true;
            this.result4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result4.Location = new System.Drawing.Point(580, 212);
            this.result4.Name = "result4";
            this.result4.Size = new System.Drawing.Size(89, 20);
            this.result4.TabIndex = 12;
            this.result4.Text = "function =";
            // 
            // headerN
            // 
            this.headerN.AutoSize = true;
            this.headerN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerN.Location = new System.Drawing.Point(372, 257);
            this.headerN.Name = "headerN";
            this.headerN.Size = new System.Drawing.Size(297, 20);
            this.headerN.TabIndex = 16;
            this.headerN.Text = "Количество слагаемых больше E:";
            // 
            // resultN
            // 
            this.resultN.AutoSize = true;
            this.resultN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultN.Location = new System.Drawing.Point(675, 257);
            this.resultN.Name = "resultN";
            this.resultN.Size = new System.Drawing.Size(0, 20);
            this.resultN.TabIndex = 17;
            // 
            // resulte10
            // 
            this.resulte10.AutoSize = true;
            this.resulte10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resulte10.Location = new System.Drawing.Point(353, 291);
            this.resulte10.Name = "resulte10";
            this.resulte10.Size = new System.Drawing.Size(322, 20);
            this.resulte10.TabIndex = 18;
            this.resulte10.Text = "Количество слагаемых больше E/10:";
            // 
            // resultediv10
            // 
            this.resultediv10.AutoSize = true;
            this.resultediv10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultediv10.Location = new System.Drawing.Point(681, 291);
            this.resultediv10.Name = "resultediv10";
            this.resultediv10.Size = new System.Drawing.Size(0, 20);
            this.resultediv10.TabIndex = 19;
            // 
            // resultsum
            // 
            this.resultsum.AutoSize = true;
            this.resultsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsum.Location = new System.Drawing.Point(624, 105);
            this.resultsum.Name = "resultsum";
            this.resultsum.Size = new System.Drawing.Size(0, 20);
            this.resultsum.TabIndex = 20;
            // 
            // resultsume
            // 
            this.resultsume.AutoSize = true;
            this.resultsume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsume.Location = new System.Drawing.Point(655, 145);
            this.resultsume.Name = "resultsume";
            this.resultsume.Size = new System.Drawing.Size(0, 20);
            this.resultsume.TabIndex = 21;
            // 
            // resultsume10
            // 
            this.resultsume10.AutoSize = true;
            this.resultsume10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsume10.Location = new System.Drawing.Point(681, 181);
            this.resultsume10.Name = "resultsume10";
            this.resultsume10.Size = new System.Drawing.Size(0, 20);
            this.resultsume10.TabIndex = 22;
            // 
            // resultfunction
            // 
            this.resultfunction.AutoSize = true;
            this.resultfunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultfunction.Location = new System.Drawing.Point(675, 212);
            this.resultfunction.Name = "resultfunction";
            this.resultfunction.Size = new System.Drawing.Size(0, 20);
            this.resultfunction.TabIndex = 23;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 469);
            this.Controls.Add(this.resultfunction);
            this.Controls.Add(this.resultsume10);
            this.Controls.Add(this.resultsume);
            this.Controls.Add(this.resultsum);
            this.Controls.Add(this.resultediv10);
            this.Controls.Add(this.resulte10);
            this.Controls.Add(this.resultN);
            this.Controls.Add(this.headerN);
            this.Controls.Add(this.result4);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.inpute);
            this.Controls.Add(this.inputx);
            this.Controls.Add(this.inputee);
            this.Controls.Add(this.getX);
            this.Controls.Add(this.header);
            this.Controls.Add(this.run);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label getX;
        private System.Windows.Forms.Label inputee;
        private System.Windows.Forms.TextBox inputx;
        private System.Windows.Forms.TextBox inpute;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label result3;
        private System.Windows.Forms.Label result4;
        private System.Windows.Forms.Label headerN;
        private System.Windows.Forms.Label resultN;
        private System.Windows.Forms.Label resulte10;
        private System.Windows.Forms.Label resultediv10;
        private System.Windows.Forms.Label resultsum;
        private System.Windows.Forms.Label resultsume;
        private System.Windows.Forms.Label resultsume10;
        private System.Windows.Forms.Label resultfunction;
    }
}

