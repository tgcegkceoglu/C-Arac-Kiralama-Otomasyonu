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
using System.Net.Mail;
using System.Net;

namespace ArabaOtomasyonu
{
    public partial class Kayıtol : Form
    {
        public Kayıtol()
        {
            InitializeComponent();
        }

        string kullanici,sifre,mail;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NJBL7FSC;Initial Catalog=müsteri;Integrated Security=True");

        private void txtadi1_TextChanged(object sender, EventArgs e)
        {
            string metin = txtadi1.Text;
            if (metin.Length < 1)
            {
                errorProvider1.SetError(txtadi1, "Boş Bırakmayınız");
            }

        }

        private void txtmail1_TextChanged(object sender, EventArgs e)
        {
            string metin = txtmail1.Text;
            if (metin.Length < 1)
            {
                errorProvider1.SetError(txtmail1, "Boş Bırakmayınız");
            }

        }

        private void txtsifre1_TextChanged(object sender, EventArgs e)
        {
            string metin = txtsifre1.Text;
            if (metin.Length < 1)
            {
                errorProvider1.SetError(txtsifre1, "Boş Bırakmayınız");
            }

        }

        public static bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);                
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            kullanici = txtadi1.Text;
            sifre = txtsifre1.Text;
            Email_Format_Kontrol(txtmail1.Text);
            if(txtadi1.Text!="")
            {
                if(txtsifre1.Text !="")
                {
                    if (Email_Format_Kontrol(txtmail1.Text) == true)
                    {
                        SqlCommand komut = new SqlCommand("Select *from tablo where kullanici_adi='" + kullanici + "'", baglanti);
                        SqlDataReader oku = komut.ExecuteReader();
                        if (oku.Read() == false)
                        {

                            oku.Close();
                            String kayıt = "insert into tablo(kullanici_adi,sifre,mail) values (@kullanici_adi,@sifre,@mail)";
                            SqlCommand komut1 = new SqlCommand(kayıt, baglanti);
                            komut1.Parameters.AddWithValue("@kullanici_adi", txtadi1.Text);
                            komut1.Parameters.AddWithValue("@sifre", txtsifre1.Text);
                            komut1.Parameters.AddWithValue("@mail", txtmail1.Text);
                            komut1.ExecuteNonQuery();
                            MessageBox.Show("Kaydınız oluşturulmuştur");
                            this.Hide();
                            Form1 frm = new Form1();
                            frm.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Bu kullanıcı kullanılmaktadır.Lütfen başka kullanıcı adı seçiniz");
                        }
                        
                    }
                    
                    else
                    {
                        MessageBox.Show("Geçerli Bir E-Mail Giriniz", "Hata");
                    }
                }
                else
                {
                    MessageBox.Show("Şifre Alanını boş bırakmayınız", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı alanını boş bırakmayınız", "Hata");
            }
            


        }      
    }
}
