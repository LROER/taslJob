using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void DeleteButton2_Click(object sender, EventArgs e)
        {
            try { Convert.ToDouble(textBox1.Text); }
            catch (Exception ex) { MessageBox.Show("Буквам не место в этом поле !"); return; }
            BD Bdn = new BD();
            string command = $"DELETE FROM `сотрудник` WHERE `сотрудник`.`Табельный Номер` = {textBox1.Text}";
            var values = Bdn.getvalues(command);
            MessageBox.Show("Удалено !");
            this.Close();
        }
    }
}
