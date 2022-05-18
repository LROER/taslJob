namespace _123
{
    partial class Reg
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
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordL = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.Lbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 81);
            this.button1.TabIndex = 14;
            this.button1.Text = "Регестрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordL
            // 
            this.PasswordL.Location = new System.Drawing.Point(145, 173);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(100, 23);
            this.PasswordL.TabIndex = 13;
            this.PasswordL.Text = "Пароль";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(145, 104);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 23);
            this.UserName.TabIndex = 12;
            this.UserName.Text = "Логин";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(60, 199);
            this.passBox.Multiline = true;
            this.passBox.Name = "passBox";
            this.passBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passBox.Size = new System.Drawing.Size(212, 34);
            this.passBox.TabIndex = 11;
            // 
            // Lbox
            // 
            this.Lbox.Location = new System.Drawing.Point(60, 129);
            this.Lbox.Multiline = true;
            this.Lbox.Name = "Lbox";
            this.Lbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Lbox.Size = new System.Drawing.Size(211, 34);
            this.Lbox.TabIndex = 10;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.Lbox);
            this.Name = "Reg";
            this.Tag = "Reg";
            this.Text = "Регестрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox Lbox;
    }
}