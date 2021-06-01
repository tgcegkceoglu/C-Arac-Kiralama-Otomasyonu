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

namespace ArabaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NJBL7FSC;Initial Catalog=müsteri;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
               
                baglanti.Open();
                string sql = "Select * from tablo where kullanici_adi=@adi AND sifre=@sifresi AND mail=@maili";
                SqlParameter prm1 = new SqlParameter("adi", txtadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtsifre.Text.Trim());
                SqlParameter prm3 = new SqlParameter("maili", txtmail.Text.Trim());
                SqlCommand komut = new SqlCommand(sql,baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                komut.Parameters.Add(prm3);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    this.Hide();
                    AnaSayfa anasayfa = new AnaSayfa();
                    
                    anasayfa.ShowDialog();
                    
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
         }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btngiris.BackColor = Color.LightBlue;
        }

        private void btngiris_MouseLeave(object sender, EventArgs e)
        {
            btngiris.BackColor = Color.Gainsboro;
        }

        private void btnkayıtol_MouseLeave(object sender, EventArgs e)
        {
            btnkayıtol.BackColor = Color.Gainsboro;
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sifreunut sifre = new sifreunut();
            sifre.ShowDialog();
           
         
        }

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayıtol kayıt = new Kayıtol();
            kayıt.ShowDialog();
        }
    }
}
