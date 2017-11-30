namespace _08._02._19
{
    partial class Form1
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
            this.invitation = new System.Windows.Forms.Label();
            this.resultheader = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // invitation
            // 
            this.invitation.AutoSize = true;
            this.invitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invitation.Location = new System.Drawing.Point(26, 109);
            this.invitation.Name = "invitation";
            this.invitation.Size = new System.Drawing.Size(123, 20);
            this.invitation.TabIndex = 0;
            this.invitation.Text = "Input your list:";
            // 
            // resultheader
            // 
            this.resultheader.AutoSize = true;
            this.resultheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultheader.Location = new System.Drawing.Point(36, 161);
            this.resultheader.Name = "resultheader";
            this.resultheader.Size = new System.Drawing.Size(66, 20);
            this.resultheader.TabIndex = 1;
            this.resultheader.Text = "Result:";
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run.Location = new System.Drawing.Point(282, 161);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(100, 82);
            this.run.TabIndex = 2;
            this.run.Text = "Start!";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(155, 111);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(251, 20);
            this.input.TabIndex = 3;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(108, 161);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 337);
            this.Controls.Add(this.result);
            this.Controls.Add(this.input);
            this.Controls.Add(this.run);
            this.Controls.Add(this.resultheader);
            this.Controls.Add(this.invitation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label invitation;
        private System.Windows.Forms.Label resultheader;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label result;
    }
}

