using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keweb_Login
{
    public partial class KewebleJewellery : Form
    {
        public KewebleJewellery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KewebleUrunEkleme gecis2 = new KewebleUrunEkleme();
            gecis2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KewebleKargo gecis3 = new KewebleKargo();
            gecis3.Show();
            this.Hide();
        }
    }
}
