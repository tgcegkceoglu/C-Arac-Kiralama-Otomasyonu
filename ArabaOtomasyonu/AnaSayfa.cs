using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnmusekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            musteriekle musteriekle = new musteriekle();
            musteriekle.ShowDialog();
        }

        private void btnmuslist_Click(object sender, EventArgs e)
        {
            this.Hide();
            MüsteriListeleme müsteri = new MüsteriListeleme();
            müsteri.ShowDialog();
        }

        private void btnarabaekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            arabaekle ekle = new arabaekle();
            ekle.ShowDialog();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnarabalist_Click(object sender, EventArgs e)
        {
            this.Hide();
            arabalistele araba = new arabalistele();
            araba.ShowDialog();
            
        }
    }
}
