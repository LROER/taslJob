namespace _123
{
    partial class Main
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
            this.connect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sql_command = new System.Windows.Forms.TextBox();
            this.Command = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BigButton = new System.Windows.Forms.Button();
            this.lessButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(12, 12);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(170, 92);
            this.connect.TabIndex = 0;
            this.connect.Text = "Подключится к БД";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(844, 670);
            this.dataGridView1.TabIndex = 1;
            // 
            // Sql_command
            // 
            this.Sql_command.CausesValidation = false;
            this.Sql_command.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sql_command.Location = new System.Drawing.Point(12, 558);
            this.Sql_command.Multiline = true;
            this.Sql_command.Name = "Sql_command";
            this.Sql_command.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Sql_command.Size = new System.Drawing.Size(170, 94);
            this.Sql_command.TabIndex = 2;
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(12, 658);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(170, 92);
            this.Command.TabIndex = 3;
            this.Command.Text = "SQL Command";
            this.Command.UseVisualStyleBackColor = true;
            this.Command.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL Запрос";
            // 
            // BigButton
            // 
            this.BigButton.Location = new System.Drawing.Point(15, 440);
            this.BigButton.Name = "BigButton";
            this.BigButton.Size = new System.Drawing.Size(170, 92);
            this.BigButton.TabIndex = 5;
            this.BigButton.Text = "От большего к меньшему";
            this.BigButton.UseVisualStyleBackColor = true;
            this.BigButton.Click += new System.EventHandler(this.BigButton_Click);
            // 
            // lessButton
            // 
            this.lessButton.Location = new System.Drawing.Point(15, 342);
            this.lessButton.Name = "lessButton";
            this.lessButton.Size = new System.Drawing.Size(170, 92);
            this.lessButton.TabIndex = 6;
            this.lessButton.Text = "От меньшего к большему";
            this.lessButton.UseVisualStyleBackColor = true;
            this.lessButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 244);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(170, 92);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 146);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 92);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.lessButton);
            this.Controls.Add(this.BigButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.Sql_command);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.connect);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Sql_command;
        private System.Windows.Forms.Button Command;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BigButton;
        private System.Windows.Forms.Button lessButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button addButton;
    }
}

