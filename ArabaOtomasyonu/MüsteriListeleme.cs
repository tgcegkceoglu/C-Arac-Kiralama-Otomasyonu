using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaOtomasyonu
{
    public partial class MüsteriListeleme : Form
    {
        public MüsteriListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NJBL7FSC;Initial Catalog=Arac_Kiralama;Integrated Security=True");

        private void MüsteriListeleme_Load(object sender, EventArgs e)
        {
            göster();
            
        }

        void göster()
        {
           
            baglanti.Open();
            string cümle = "select * from müsteri_ekle";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }
      
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update müsteri_ekle set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,mail=@mail  where tc_kimlik=@tc_kimlik";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("tc_kimlik", txtkimlik.Text);
            komut.Parameters.AddWithValue("adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("telefon", txttel.Text);
            komut.Parameters.AddWithValue("adres", txtadres.Text);
            komut.Parameters.AddWithValue("mail", txtemail.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            göster();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "Select *from müsteri_ekle where adsoyad like '%"+textBox1.Text + "%'";
            SqlDataAdapter adtr = new SqlDataAdapter();
            AracKiralama arac = new AracKiralama();
            dataGridView1.DataSource = arac.listele(adtr, cümle);
            if(textBox1.Text=="")
            {
                göster();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtkimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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

        private void btnsil_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Sil", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string sorgu = "delete from müsteri_ekle where adsoyad=@adsoyad";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                göster();
            }
        }


    }
}
