using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaOtomasyonu
{
    public partial class arabalistele : Form
    {
        public arabalistele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NJBL7FSC;Initial Catalog=Arac_Kiralama;Integrated Security=True");
        
        void göster()
        {

            baglanti.Open();
            string cümle = "select * from arackayıt";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update arackayıt set plaka=@plaka, marka=@marka, seri=@seri, yil=@yil, renk=@renk ,km=@km, yakit=@yakit, fiyat=@fiyat ,resim=@resim , durumu=@durumu  where arac_id=@arac_id";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
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
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            göster();
        }

        private void arabalistele_Load(object sender, EventArgs e)
        {
            göster();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "Select *from arackayıt where plaka like '%" + txtara.Text + "%'";
            SqlDataAdapter adtr = new SqlDataAdapter();
            AracKiralama arac = new AracKiralama();
            dataGridView1.DataSource = arac.listele(adtr, cümle);
            if (txtara.Text == "")
            {
                göster();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtplaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            markacombo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sericombo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtrenk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtkm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            yakitcombo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            pictureBox1.ImageLocation= dataGridView1.CurrentRow.Cells[9].Value.ToString();
            durumcombo.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

      
        private void markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (markacombo.Text== "Opel")
                {
                    sericombo.Items.Add("Astra");
                    sericombo.Items.Add("Vectra");
                    sericombo.Items.Add("Corsa");
                }
                else if (markacombo.Text == "Renault")
                {
                    sericombo.Items.Add("Megane");
                    sericombo.Items.Add("Clio");
                }
                else if (markacombo.Text == "Fort")
                {
                    sericombo.Items.Add("Linea");
                    sericombo.Items.Add("Egea");
                }
                else if (markacombo.Text == "Fiat")
                {
                    sericombo.Items.Add("Fiesta");
                    sericombo.Items.Add("Focus");
                }
            }
            catch
            {

            }
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Sil", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string sorgu = "delete from arackayıt where plaka=@plaka";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@plaka", txtplaka.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                göster();
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
