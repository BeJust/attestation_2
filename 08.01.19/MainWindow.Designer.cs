namespace _08._01._19
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
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invitation = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.inputn = new System.Windows.Forms.TextBox();
            this.invitationN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(182, 145);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(267, 20);
            this.input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-5, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            // 
            // invitation
            // 
            this.invitation.AutoSize = true;
            this.invitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invitation.Location = new System.Drawing.Point(12, 145);
            this.invitation.Name = "invitation";
            this.invitation.Size = new System.Drawing.Size(164, 20);
            this.invitation.TabIndex = 2;
            this.invitation.Text = "Input your list here:";
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run.Location = new System.Drawing.Point(570, 259);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(123, 89);
            this.run.TabIndex = 3;
            this.run.Text = "Start";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(67, 259);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 20);
            this.output.TabIndex = 4;
            // 
            // inputn
            // 
            this.inputn.Location = new System.Drawing.Point(67, 185);
            this.inputn.Name = "inputn";
            this.inputn.Size = new System.Drawing.Size(161, 20);
            this.inputn.TabIndex = 5;
            // 
            // invitationN
            // 
            this.invitationN.AutoSize = true;
            this.invitationN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invitationN.Location = new System.Drawing.Point(22, 185);
            this.invitationN.Name = "invitationN";
            this.invitationN.Size = new System.Drawing.Size(39, 20);
            this.invitationN.TabIndex = 6;
            this.invitationN.Text = "n = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 407);
            this.Controls.Add(this.invitationN);
            this.Controls.Add(this.inputn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.run);
            this.Controls.Add(this.invitation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label invitation;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox inputn;
        private System.Windows.Forms.Label invitationN;
    }
}

