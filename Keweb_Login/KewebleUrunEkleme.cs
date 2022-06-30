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
    public partial class KewebleUrunEkleme : Form
    {
        public KewebleUrunEkleme()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=kevin;Initial Catalog=Urunler;Integrated Security=True");

        private void KewebleUrunEkleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'urunlerDataSet.urunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerTableAdapter.Fill(this.urunlerDataSet.urunler);

            listele();


        }

        private void listele()//Veri tabanındaki kayıtların program açılırken görüntülenmesi için
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select*From Urunler",con);
            DataTable urunlertablosu = new DataTable();
            da.Fill(urunlertablosu);
            dataGridView1.DataSource=urunlertablosu;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String t1 = textBox1.Text;//Urun İd
            String t2 = textBox2.Text;//Urun Ad
            String t3 = textBox3.Text;//Urun Kısa Ad
            String t4 = textBox4.Text;//Kategori
            String t5 = textBox5.Text;//UrunGram
            String t6 = textBox6.Text;//Adet
            String t7 = textBox7.Text;//Hammade
            String t8 = textBox8.Text;//Maaliyet
            String t9 = textBox9.Text;//İşcilik
            String t10 = textBox10.Text;//Fiyat

            con.Open();
            SqlCommand com = new SqlCommand("INSERT INTO Urunler (Urun_Id,Urun_Ad,Kısa_Ad,Kategori,UrunGram,Adet,Hammade,Maaliyet,İşcilik,fiyat) VALUES('" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t5 + "','" + t6 + "','" + t7 + "','" + t8 + "','" + t9 + "','" + t10 + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            listele();//Data Griddde listelensin diye
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text; //seçilen satırın kodu 
            con.Open();
            SqlCommand com = new SqlCommand("DELETE FROM Urunler WHERE  Urun_Id=('"+t1+"')",con); //delete
            com.ExecuteNonQuery();
            con.Close();
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            

           
            String t1 = textBox1.Text;//Urun İd
            String t2 = textBox2.Text;//Urun Ad
            String t3 = textBox3.Text;//Urun Kısa Ad
            String t4 = textBox4.Text;//Kategori
            String t5 = textBox5.Text;//UrunGram
            String t6 = textBox6.Text;//Adet
            String t7 = textBox7.Text;//Hammade
            String t8 = textBox8.Text;//Maaliyet
            String t9 = textBox9.Text;//İşcilik
            String t10 = textBox10.Text;//Fiyat

            con.Open();
            SqlCommand com = new SqlCommand("UPDATE Urunler SET Urun_Id= '"+t1+ "',Urun_Ad= '" + t2 + "',Kısa_Ad= '" + t3 + "',Kategori= '" + t4 + "',UrunGram= '" + t5 + "',Adet= '" + t6 + "',Hammade= '" + t7 + "',Maaliyet= '" + t8 + "',İşcilik= '" + t9 + "',Fiyat= '" + t10 + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            listele();//Data Griddde listelensin diye
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("EĞER HİÇ BİR ŞEY SEÇİLİ DEĞİL İSE GÜNCELLEŞTİRMEYE BASMAYINIZ");
            MessageBox.Show("Bütün Tablonuz Silinir");
            button3.Visible = true;
               
        }
    }
}




