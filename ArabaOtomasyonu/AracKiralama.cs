using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaOtomasyonu
{
    class AracKiralama
    {

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-NJBL7FSC;Initial Catalog=Arac_Kiralama;Integrated Security=True");
        DataTable tablo;
       

        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;

        }


    }
}
