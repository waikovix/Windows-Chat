using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WS_Messenger
{
    class Core
    {
        string user = "";
        string pass = "";
        MySql.Data.MySqlClient.MySqlConnection conn;
        string usr_pwd;
        public void Connect()
        {

            string connection_data = "server='localhost';uid = 'root';pwd = '';database='chat'";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(connection_data);
                conn.Open();
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void Login(string password,string username)
        {
            pass = password;
            user = username;
            if (user != (string)null)
            {
                if (pass != (string)null)
                {

                    MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Select *  from users Where username=@user";
                    cmd.Parameters.AddWithValue("@user", user);
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro" + erro);
                        conn.Close();
                    }
                    MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        usr_pwd = (string)reader.GetValue(2);
                    }

                    MD5Hash(pass);
                    if (pass == usr_pwd)
                    {
                        conn.Close();
                        Chat ch = new Chat();
                        ch.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password");
                        conn.Close();
                    }


                }
            }
        }
        void MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            pass = strBuilder.ToString();

        }
        public void Register()
        {

        }

    }
}
