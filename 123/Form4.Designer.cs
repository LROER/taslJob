namespace _123
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.addButton2 = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Oklad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dolg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton2
            // 
            this.addButton2.Location = new System.Drawing.Point(138, 220);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(170, 92);
            this.addButton2.TabIndex = 4;
            this.addButton2.Tag = "Добавление";
            this.addButton2.Text = "Добавить";
            this.addButton2.UseVisualStyleBackColor = true;
            this.addButton2.Click += new System.EventHandler(this.addButton2_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(12, 50);
            this.IDBox.Multiline = true;
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(120, 60);
            this.IDBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Табельный Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оклад";
            // 
            // Oklad
            // 
            this.Oklad.Location = new System.Drawing.Point(12, 137);
            this.Oklad.Multiline = true;
            this.Oklad.Name = "Oklad";
            this.Oklad.Size = new System.Drawing.Size(120, 60);
            this.Oklad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Должность";
            // 
            // dolg
            // 
            this.dolg.Location = new System.Drawing.Point(12, 220);
            this.dolg.Multiline = true;
            this.dolg.Name = "dolg";
            this.dolg.Size = new System.Drawing.Size(120, 60);
            this.dolg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Имя";
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(150, 50);
            this.NAME.Multiline = true;
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(120, 60);
            this.NAME.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Адрес Проживания";
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(150, 137);
            this.adress.Multiline = true;
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(120, 60);
            this.adress.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dolg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Oklad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.addButton2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Tag = "Form4";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Oklad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dolg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adress;
    }
}