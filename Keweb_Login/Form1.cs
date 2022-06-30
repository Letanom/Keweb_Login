using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Keweb_Login
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        private bool mouseDown;
        private Point lastLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=KEVIN;Initial Catalog=LoginApp;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.CommandText = "Select*From logdata where kullanici_adi= '" + textBox1.Text + "'And parola='" + textBox2.Text + "'";
            com.Connection = con; // yukarıdaki tanımladıklarımızı bağlantıya ekle

            dr = com.ExecuteReader();
            if (dr.Read())
               

            {
                MessageBox.Show("Giriş Başarılı");
                KewebleJewellery gecis = new KewebleJewellery();
                gecis.Show();
                this.Hide();
                   
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }


      
        



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinizden eminmisiniz", "Çıkış", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
               
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
    }

