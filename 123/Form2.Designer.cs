namespace _123
{
    partial class Login
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
            this.Lbox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbox
            // 
            this.Lbox.Location = new System.Drawing.Point(60, 120);
            this.Lbox.Multiline = true;
            this.Lbox.Name = "Lbox";
            this.Lbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Lbox.Size = new System.Drawing.Size(211, 34);
            this.Lbox.TabIndex = 0;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(60, 190);
            this.passBox.Multiline = true;
            this.passBox.Name = "passBox";
            this.passBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passBox.Size = new System.Drawing.Size(212, 34);
            this.passBox.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(145, 95);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 23);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Логин";
            // 
            // PasswordL
            // 
            this.PasswordL.Location = new System.Drawing.Point(145, 164);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(100, 23);
            this.PasswordL.TabIndex = 3;
            this.PasswordL.Text = "Пароль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "ВХОД!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.Lbox);
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "Login";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lbox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.Button button1;
    }
}