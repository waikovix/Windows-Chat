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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.OnFormClosing 
        }
        void Reg(string username,string password,string email)
        {

        }
    }
}
