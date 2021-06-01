using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArabaOtomasyonu
{
    public partial class sifreunut : Form
    {
        public sifreunut()
        {
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NJBL7FSC;Initial Catalog=müsteri;Integrated Security=True");
            if (txtsifre.Text==txttekrar.Text)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tablo where kullanici_adi='" + txtadi.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    MessageBox.Show(txtmaill1.Text);
                    MessageBox.Show(read["mail"].ToString());
                    if (read["mail"].ToString() != txtmaill1.Text)
                    {
                        baglanti.Close();
                        baglanti.Open();
                        komut = new SqlCommand("update tablo set kullanici_adi='" + txtadi.Text + "', sifre='" + txtsifre.Text + "' where kullanici_adi= '" + txtadi.Text + "'", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("İşlem başarılı");
                    }

                    else
                    {
                        MessageBox.Show("Mail adresinizi kontrol ediniz");
                    }

                }

                else
                {
                    MessageBox.Show("Bilgilerinizi Kontrol Ediniz", "Hata");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmamaktadır.");
            }
           
        }
    }
}
