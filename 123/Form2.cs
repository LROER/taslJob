using System;
using System.IO;
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

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string TrueLogin;
            string TruePass;
            using (StreamReader reader = new StreamReader("login.txt"))
            {
                TrueLogin = reader.ReadLine();
                Console.WriteLine(TrueLogin);
            }
            using (StreamReader reader = new StreamReader("password.txt"))
            {
                TruePass = reader.ReadLine();
                Console.WriteLine(TruePass);
            }
            String login = Lbox.Text;
            String password = passBox.Text;
            if(login == TrueLogin && password == TruePass)
            {
                Main f2 = new Main();
                f2.Show();
                this.Owner = f2;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Подумой");
            }
        }
    }
}
/*Form1 f2 = new Form1();
f2.Show();
this.Hide();*/