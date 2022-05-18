using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _123
{
    internal class BD
    {
        public static string uid="root";
        public static string pwd="";
        MySqlConnection connection = new MySqlConnection($"server=127.0.0.1;uid={uid};pwd={pwd};database=kurs");
        
        public void start() 
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка Подключения");
                return;
            }
        }
        public List<string[]> getvalues(string Command)
        {
            start();
            MySqlCommand mycom = new MySqlCommand(Command,connection);
            try
            {
                MySqlDataReader reader = mycom.ExecuteReader();
                List<string[]> Data = new List<string[]>();
                while (reader.Read())
                {
                    Data.Add(new string[5]);

                    Data[Data.Count - 1][0] = reader[0].ToString();
                    Data[Data.Count - 1][1] = reader[1].ToString();
                    Data[Data.Count - 1][2] = reader[2].ToString();
                    Data[Data.Count - 1][3] = reader[3].ToString();
                    Data[Data.Count - 1][4] = reader[4].ToString();
                }
                reader.Close();
                return Data;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
