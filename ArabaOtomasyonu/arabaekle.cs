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
    public partial class arabaekle : Form
    {
        public arabaekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NJBL7FSC;Initial Catalog=Arac_Kiralama;Integrated Security=True");
        

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sericombo.Items.Clear();
                if (markacombo.SelectedIndex == 0)
                {
                    sericombo.Items.Add("Astra");
                    sericombo.Items.Add("Vectra");
                    sericombo.Items.Add("Corsa");
                }
                else if(markacombo.SelectedIndex==1)
                {
                    sericombo.Items.Add("Megane");
                    sericombo.Items.Add("Clio");              
                }
                else if (markacombo.SelectedIndex == 2)
                {
                    sericombo.Items.Add("Linea");
                    sericombo.Items.Add("Egea");
                }
                else if (markacombo.SelectedIndex == 3)
                {
                    sericombo.Items.Add("Fiesta");
                    sericombo.Items.Add("Focus");
                }
            }
            catch
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (txtplaka.Text != "")
            {
               if(markacombo.Text !="")
                {
                    if (sericombo.Text != "")
                    {
                        if(txtmodel.Text != "")
                        {
                            if(txtrenk.Text !="")
                            {

                                if (txtkm.Text != "")
                                {
                                    if (yakitcombo.Text != "")
                                    {
                                        if (txtfiyat.Text != "")
                                        {
                                            if (pictureBox1.ImageLocation != "")
                                            {
                                                if (durumcombo.Text != "")
                                                {
                                                    baglanti.Open();
                                                    SqlCommand komut = new SqlCommand("insert into arackayıt(arac_id,plaka,marka,seri,yil,renk,km,yakit,fiyat,resim,durumu) values (@arac_id,@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@fiyat,@resim,@durumu)", baglanti);
                                                    komut.Parameters.AddWithValue("@arac_id", txtid.Text);
                                                    komut.Parameters.AddWithValue("@plaka", txtplaka.Text);
                                                    komut.Parameters.AddWithValue("@marka", markacombo.Text);
                                                    komut.Parameters.AddWithValue("@seri", sericombo.Text);
                                                    komut.Parameters.AddWithValue("@yil", txtmodel.Text);
                                                    komut.Parameters.AddWithValue("@renk", txtrenk.Text);
                                                    komut.Parameters.AddWithValue("@km", txtkm.Text);
                                                    komut.Parameters.AddWithValue("@yakit", yakitcombo.Text);
                                                    komut.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
                                                    komut.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                                                    komut.Parameters.AddWithValue("@durumu", durumcombo.Text);
                                                    komut.ExecuteNonQuery();
                                                    baglanti.Close();

                                                    MessageBox.Show("Araba Başarıyla Eklendi");
                                                    DialogResult dialog = new DialogResult();
                                                    dialog = MessageBox.Show("Yeni Bir Araba Eklemek İster Misiniz?", "Araba Ekleme", MessageBoxButtons.YesNo);
                                                    if (dialog == DialogResult.Yes)
                                                    {
                                                        foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                                                        foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Durumu Alanını Boş Bırakmayınız");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Resim Ekleyiniz");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Fiyat Alanını Boş Bırakmayınız");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Yakıt Alanını Boş Bırakmayınız");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Km Alanını Boş Bırakmayınız");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Renk Alanını Boş Bırakmayınız");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Model(Yıl) Alanını Boş Bırakmayınız");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seri Alanını Boş Bırakmayınız");
                    }
                }
               else
                {
                    MessageBox.Show("Marka Alanını Boş Bırakmayınız");
                }
            }
            else
            {
                MessageBox.Show("Plaka Alanını Boş Bırakmayınız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void txtplaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmodel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtrenk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtkm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
