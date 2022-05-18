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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            BD Bd = new BD();
            var check = Bd.getvalues("SELECT * FROM `сотрудник`");
            string ID = IDBox.Text.ToString();
            string Nave = NAME.Text.ToString();
            string oklad = Oklad.Text.ToString();
            string adres = adress.Text.ToString();
            string dolgn = dolg.Text.ToString();
            try
            {
                double ID1 = Convert.ToDouble(ID);
                double oklad1 = Convert.ToDouble(oklad);
            }
            catch (Exception ex)
            {
                MessageBox.Show("в одно из числовых полей попала буква");
                return;
            }


            try 
            {
                
                foreach(string[] s in check)
                {
                    if(s.Contains(ID))
                    {
                        MessageBox.Show("ID занят");
                        return ;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            BD BdQ = new BD();
            var values = BdQ.getvalues($"INSERT INTO `сотрудник` (`Табельный Номер`, `ФИО`, `Оклад`, `Адрес Проживания`, `Должность`) VALUES ('{ID}', '{Nave}', '{oklad}', '{adres}', '{dolgn}');");
            MessageBox.Show("Добавленно");
        }
    }
}
//BD BdQ = new BD();
//var values = BdQ.getvalues($"INSERT INTO `сотрудник` (`Табельный Номер`, `ФИО`, `Оклад`, `Адрес Проживания`, `Должность`) VALUES ('{ID}', '{Nave}', '{oklad}', '{adres}', '{dolgn}');");