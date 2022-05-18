using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace _123
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //Кнопочки
        public void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            BD Bdn = new BD();
            string command = "SELECT * FROM `сотрудник`";
            var values = Bdn.getvalues(command);
            setValues(values);
        }
  
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Command = Sql_command.Text;
            BD BdQ = new BD();
            var values = BdQ.getvalues(Command);
            setValues(values);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            BD BdQ = new BD();
            var values = BdQ.getvalues("SELECT * FROM `сотрудник` ORDER BY `Табельный Номер` ASC");
            setValues(values);
        }

        private void BigButton_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            BD BdQ = new BD();
            var values = BdQ.getvalues("SELECT * FROM `сотрудник` ORDER BY `Табельный Номер` DESC");
            setValues(values);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Form add = new Form4();
            add.Show();
            /*Form1 f2 = new Form1();
            f2.Show();
            this.Hide();*/
        }
        //Заполнятель датагрида
        public void setValues(List<string[]> values)
        {
            if (values != null)
            {
                dataGridView1.Columns.Add("1", "Табельный номер");
                dataGridView1.Columns.Add("2", "Имя");
                dataGridView1.Columns.Add("3", "Оклад");
                dataGridView1.Columns.Add("4", "Город");
                dataGridView1.Columns.Add("5", "Должность");
                foreach (string[] s in values)
                {
                    dataGridView1.Rows.Add(s);
                }
            }
            else MessageBox.Show("Ошибка sql запроса");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Form delete = new Form5();
            delete.Show();
        }
        public void restart()
        {
            BD Bdn = new BD();
            string command = "SELECT * FROM `сотрудник`";
            var values = Bdn.getvalues(command);
            setValues(values);
        }
    }
 }
    
