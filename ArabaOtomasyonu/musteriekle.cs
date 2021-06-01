using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace ArabaOtomasyonu
{
    public partial class musteriekle : Form
    {
        AracKiralama arac = new AracKiralama();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NJBL7FSC;Initial Catalog=Arac_Kiralama;Integrated Security=True");
        public musteriekle()
        {
            InitializeComponent();
        }


        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ana Sayfaya Geri Dönmek İstediğinize Emin Misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Dispose();
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.ShowDialog();
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

        private void btnekle_Click(object sender, EventArgs e)
        {
            Email_Format_Kontrol(txtemail.Text);
            if (txtadsoyad.Text !="")
            {
                baglanti.Close();
                baglanti.Open();
                string kullanici = txtadsoyad.Text;
                string cümle = "Select *from müsteri_ekle where adsoyad like '%" + txtadsoyad.Text + "%'";
                SqlCommand komut2 = new SqlCommand(cümle, baglanti);
                SqlDataReader oku = komut2.ExecuteReader();
                if (oku.Read() == false)
                {
                    oku.Read();
                    if(txtkimlik.Text!="")
                    {
                        if (txttel.Text != "")
                        {
                            if (txtadres.Text != "")
                            {
                                if (Email_Format_Kontrol(txtemail.Text) == true)
                                {
                                    baglanti.Close();
                                    baglanti.Open();
                                    SqlCommand komut = new SqlCommand("insert into müsteri_ekle(tc_kimlik,adsoyad,telefon,adres,mail) values (@tc_kimlik,@adsoyad,@telefon,@adres,@mail)", baglanti);
                                    komut.Parameters.AddWithValue("@tc_kimlik", txtkimlik.Text);
                                    komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                                    komut.Parameters.AddWithValue("@telefon", txttel.Text);
                                    komut.Parameters.AddWithValue("@adres", txtadres.Text);
                                    komut.Parameters.AddWithValue("@mail", txtemail.Text);                                   
                                    komut.ExecuteNonQuery();
                                    baglanti.Close();
                                    MessageBox.Show("Müşteri Başarıyla Eklendi");
                                    DialogResult dialog = new DialogResult();
                                    dialog = MessageBox.Show("Yeni Bir Müşteri Eklemek İster Misiniz?", "Müşteri Ekleme", MessageBoxButtons.YesNo);
                                    if (dialog == DialogResult.Yes)
                                    {
                                        foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                                    }
                                   
                                }
                                else
                                {
                                    MessageBox.Show("Geçerli Bir E-posta Yazınız");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Adres Alanını Boş Bırakmayınız");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Telefon Alanını Boş Bırakmayınız");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tc Kimlik Alanını Boş Bırakmayınız");
                    }                    
                }
                else
                {
                    MessageBox.Show("Bu Ad Soyadı ile Müşteri Bulunmaktadır");
                }
                baglanti.Close();
                
            }
            else
            {
                MessageBox.Show("Ad Soyad Alanını Boş Bırakmayınız");
            }



        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtadsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void göster()
        {

            baglanti.Open();
            string cümle = "select * from arackayıt where durumu='Boş'";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();


        }

        private void musteriekle_Load(object sender, EventArgs e)
        {
            göster();
        }

        private void txtkimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
