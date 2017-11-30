namespace _07._01._19
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
            this.header = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.invitation = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.result3 = new System.Windows.Forms.Label();
            this.resultfirstser = new System.Windows.Forms.Label();
            this.resultlastser = new System.Windows.Forms.Label();
            this.resultmaxser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(152, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(377, 20);
            this.header.TabIndex = 0;
            this.header.Text = "Нахождение и увеличение серий в массиве";
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run.Location = new System.Drawing.Point(703, 346);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(86, 49);
            this.run.TabIndex = 1;
            this.run.Text = "Start!";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(165, 118);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(305, 20);
            this.input.TabIndex = 2;
            // 
            // invitation
            // 
            this.invitation.AutoSize = true;
            this.invitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invitation.Location = new System.Drawing.Point(12, 116);
            this.invitation.Name = "invitation";
            this.invitation.Size = new System.Drawing.Size(153, 20);
            this.invitation.TabIndex = 4;
            this.invitation.Text = "Введите массив:";
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result1.Location = new System.Drawing.Point(12, 188);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(333, 20);
            this.result1.TabIndex = 5;
            this.result1.Text = "Результат(увеличение первой серии):";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result2.Location = new System.Drawing.Point(10, 244);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(365, 20);
            this.result2.TabIndex = 6;
            this.result2.Text = "Результат(увеличение последней серии):";
            // 
            // result3
            // 
            this.result3.AutoSize = true;
            this.result3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result3.Location = new System.Drawing.Point(10, 289);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(386, 20);
            this.result3.TabIndex = 9;
            this.result3.Text = "Реузьтат(увеличние самой длинной серии): ";
            // 
            // resultfirstser
            // 
            this.resultfirstser.AutoSize = true;
            this.resultfirstser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultfirstser.Location = new System.Drawing.Point(351, 188);
            this.resultfirstser.Name = "resultfirstser";
            this.resultfirstser.Size = new System.Drawing.Size(0, 20);
            this.resultfirstser.TabIndex = 10;
            // 
            // resultlastser
            // 
            this.resultlastser.AutoSize = true;
            this.resultlastser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultlastser.Location = new System.Drawing.Point(381, 244);
            this.resultlastser.Name = "resultlastser";
            this.resultlastser.Size = new System.Drawing.Size(0, 20);
            this.resultlastser.TabIndex = 11;
            // 
            // resultmaxser
            // 
            this.resultmaxser.AutoSize = true;
            this.resultmaxser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultmaxser.Location = new System.Drawing.Point(391, 289);
            this.resultmaxser.Name = "resultmaxser";
            this.resultmaxser.Size = new System.Drawing.Size(0, 20);
            this.resultmaxser.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 449);
            this.Controls.Add(this.resultmaxser);
            this.Controls.Add(this.resultlastser);
            this.Controls.Add(this.resultfirstser);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.invitation);
            this.Controls.Add(this.input);
            this.Controls.Add(this.run);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label invitation;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label result3;
        private System.Windows.Forms.Label resultfirstser;
        private System.Windows.Forms.Label resultlastser;
        private System.Windows.Forms.Label resultmaxser;
    }
}

