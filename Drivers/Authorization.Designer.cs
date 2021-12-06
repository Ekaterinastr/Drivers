namespace Drivers
{
    partial class Authorization
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
            this.loginLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.sighInButton = new System.Windows.Forms.Button();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.Location = new System.Drawing.Point(294, 29);
            this.nameLb.Size = new System.Drawing.Size(109, 20);
            this.nameLb.Text = "Авторизация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(172, 12);
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(169, 107);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(54, 18);
            this.loginLb.TabIndex = 2;
            this.loginLb.Text = "Логин:";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(158, 154);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(65, 18);
            this.passwordLb.TabIndex = 3;
            this.passwordLb.Text = "Пароль:";
            // 
            // sighInButton
            // 
            this.sighInButton.Location = new System.Drawing.Point(224, 225);
            this.sighInButton.Name = "sighInButton";
            this.sighInButton.Size = new System.Drawing.Size(149, 31);
            this.sighInButton.TabIndex = 4;
            this.sighInButton.Text = "Авторизоваться";
            this.sighInButton.UseVisualStyleBackColor = true;
            this.sighInButton.Click += new System.EventHandler(this.sighInButton_Click);
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(246, 104);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(174, 24);
            this.loginTb.TabIndex = 5;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(246, 154);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(174, 24);
            this.passwordTb.TabIndex = 6;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 354);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.sighInButton);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.loginLb);
            this.Name = "Authorization";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.nameLb, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.loginLb, 0);
            this.Controls.SetChildIndex(this.passwordLb, 0);
            this.Controls.SetChildIndex(this.sighInButton, 0);
            this.Controls.SetChildIndex(this.loginTb, 0);
            this.Controls.SetChildIndex(this.passwordTb, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Button sighInButton;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox passwordTb;
    }
}

