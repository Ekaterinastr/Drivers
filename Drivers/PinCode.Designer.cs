namespace Drivers
{
    partial class PinCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pinCodTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendPibTb = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.Location = new System.Drawing.Point(225, 32);
            this.nameLb.Size = new System.Drawing.Size(72, 20);
            this.nameLb.Text = "Пин-код";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            // 
            // pinCodTb
            // 
            this.pinCodTb.Location = new System.Drawing.Point(184, 127);
            this.pinCodTb.Name = "pinCodTb";
            this.pinCodTb.ReadOnly = true;
            this.pinCodTb.Size = new System.Drawing.Size(159, 24);
            this.pinCodTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите показанный пинкод:";
            // 
            // sendPibTb
            // 
            this.sendPibTb.Location = new System.Drawing.Point(184, 201);
            this.sendPibTb.Name = "sendPibTb";
            this.sendPibTb.Size = new System.Drawing.Size(159, 24);
            this.sendPibTb.TabIndex = 4;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(214, 241);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(102, 25);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // PinCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 329);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.sendPibTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinCodTb);
            this.Name = "PinCode";
            this.Text = "PinCode";
            this.Load += new System.EventHandler(this.PinCode_Load);
            this.Controls.SetChildIndex(this.nameLb, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pinCodTb, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.sendPibTb, 0);
            this.Controls.SetChildIndex(this.SendButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pinCodTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sendPibTb;
        private System.Windows.Forms.Button SendButton;
    }
}