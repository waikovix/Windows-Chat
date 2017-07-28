using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS_Messenger
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }
        Core core = new Core();
        private void Chat_Load(object sender, EventArgs e)
        {
            core.Receive(listBox1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            core.Receive(listBox1);
        }
    }
}
