using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql;
using System.Security.Cryptography;

namespace WS_Messenger
{
     
    public partial class Form1 : Form
    {
        Core core = new Core();
         string user = "";
        string pass = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            core.Connect();
        }
       

        private void password_Enter(object sender, EventArgs e)
        {
            password.Text = pass;
        }

        private void username_Enter(object sender, EventArgs e)
        {
            username.Text = user;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            user = username.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            pass = password.Text;
        }
        
       

        private void logbtn_Click(object sender, EventArgs e)
        {
            core.Login(pass,user);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            Hide();

        }
    }
}
    
    
   

