namespace _07._02._19
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
            this.resultheader = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.result_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultheader
            // 
            this.resultheader.AutoSize = true;
            this.resultheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultheader.Location = new System.Drawing.Point(33, 176);
            this.resultheader.Name = "resultheader";
            this.resultheader.Size = new System.Drawing.Size(67, 20);
            this.resultheader.TabIndex = 0;
            this.resultheader.Text = "Ответ:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(150, 112);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(348, 20);
            this.input.TabIndex = 1;
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run.Location = new System.Drawing.Point(191, 228);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(106, 66);
            this.run.TabIndex = 2;
            this.run.Text = "Start";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input your Array:";
            // 
            // result_1
            // 
            this.result_1.AutoSize = true;
            this.result_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_1.Location = new System.Drawing.Point(106, 176);
            this.result_1.Name = "result_1";
            this.result_1.Size = new System.Drawing.Size(0, 20);
            this.result_1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 444);
            this.Controls.Add(this.result_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.run);
            this.Controls.Add(this.input);
            this.Controls.Add(this.resultheader);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultheader;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result_1;
    }
}

