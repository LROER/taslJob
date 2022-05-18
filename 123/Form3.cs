using System.IO;
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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "login.txt";
            string path2 = "password.txt";
            String login = Lbox.Text;
            String password = passBox.Text;
            if(login == "" || password == "")
            {
                MessageBox.Show("Незаполенное поле");
                return;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLineAsync(login);
                    writer.Close();
                }
                using (StreamWriter writer2 = new StreamWriter(path2, false))
                {
                    writer2.WriteLineAsync(password);
                    writer2.Close();
                }
            }
            this.Close();
        }
    }
}
