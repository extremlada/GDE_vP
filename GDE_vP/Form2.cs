using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GDE_vP
{
    public partial class Form2 : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Form2()
        {
            server = "localhost";
            database = "regisztracio";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            conn = new MySqlConnection(connString);

            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox4.Text;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(password);

            //itt már ascii



            string[] special = { "#", "$", "_", "-", "}", ">", "ß", "*", ".", "×" };

            string[] modifiedArray = new string[asciiBytes.Length];

            for (int i = 0; i < asciiBytes.Length; i++)
            {

                string byteString = asciiBytes[i].ToString();
                foreach (char digitChar in byteString)
                {
                    int digit = int.Parse(digitChar.ToString());
                    if (digit >= 0 && digit < special.Length)
                    {
                        modifiedArray[i] += special[digit];
                    }
                    else
                    {
                        Console.WriteLine($"Invalid digit: {digit}");
                        return;
                    }
                }
            } // ez a kódolt ascii jelszó

            int[] modifiedAsciiValues = new int[modifiedArray.Length];

            for (int i = 0; i < modifiedArray.Length; i++)
            {
                char[] chars = modifiedArray[i].ToCharArray();
                int sum = 0;
                foreach (char c in chars)
                {
                    sum += (int)c;
                }
                modifiedAsciiValues[i] = sum + 50;
            }


            //ez itt már a kódolt jelszó ascii

            string modifiedAsciiString = string.Join("", modifiedArray);

            byte[] modifiedBytes = Encoding.ASCII.GetBytes(modifiedAsciiString);
            string base64String = Convert.ToBase64String(modifiedBytes);

            string passwd = base64String;

            if (register(username, passwd))
            {
                MessageBox.Show($"The user {username} has been created!");
            }
            else
            {
                MessageBox.Show($"The user {username} has not been created!");
            }
        }
        public void button4_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox4.Text;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(password);

            //itt már ascii



            string[] special = { "#", "$", "_", "-", "}", ">", "ß", "*", ".", "×" };

            string[] modifiedArray = new string[asciiBytes.Length];

            for (int i = 0; i < asciiBytes.Length; i++)
            {

                string byteString = asciiBytes[i].ToString();
                foreach (char digitChar in byteString)
                {
                    int digit = int.Parse(digitChar.ToString());
                    if (digit >= 0 && digit < special.Length)
                    {
                        modifiedArray[i] += special[digit];
                    }
                    else
                    {
                        Console.WriteLine($"Invalid digit: {digit}");
                        return;
                    }
                }
            } // ez a kódolt ascii jelszó

            int[] modifiedAsciiValues = new int[modifiedArray.Length];

            for (int i = 0; i < modifiedArray.Length; i++)
            {
                char[] chars = modifiedArray[i].ToCharArray();
                int sum = 0;
                foreach (char c in chars)
                {
                    sum += (int)c;
                }
                modifiedAsciiValues[i] = sum + 50;
            }


            //ez itt már a kódolt jelszó ascii

            string modifiedAsciiString = string.Join("", modifiedArray);

            byte[] modifiedBytes = Encoding.ASCII.GetBytes(modifiedAsciiString);
            string base64String = Convert.ToBase64String(modifiedBytes);

            string passwd = base64String;
            MessageBox.Show(passwd);

            if (IsLogin(username, passwd))
            {
                MessageBox.Show($"Welcome {username}");
                
            }
            else
            {
                MessageBox.Show($"Username or Password is incorrect!");
            }
        }
        public bool register(string username, string passwd)
        {
            string query = $"INSERT INTO users (passwd, felhnev) VALUES ('{passwd}', '{username}');";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close() ;
                return false;
            }
            
        }
        public bool IsLogin(string username, string passwd)
        {
            string query = $"SELECT * FROM users WHERE felhnev = '{username}' AND passwd = '{passwd}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }

                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch(Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed");
                        break;
                    case 1045:
                        MessageBox.Show("user name or password is incorrect");
                        break;
                }
                return false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
    







}
