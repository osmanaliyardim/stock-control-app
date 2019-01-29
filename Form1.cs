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

namespace PetrolOfisi_Stok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-N9EER84;Initial Catalog=PetrolOfisi_Stok;Integrated Security=True");

        void listele()
        {
            //Kurşunsuz95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLBENZIN where petroltur='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKur95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                lblKursunsuz95Lit.Text = dr[4].ToString();
            }
            baglanti.Close();

            //Kurşunsuz97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from TBLBENZIN where petroltur='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblKur97.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                lblKursunsuz97Lit.Text = dr2[4].ToString();
            }
            baglanti.Close();

            //EuroDizel
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from TBLBENZIN where petroltur='EuroDizel'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblEuroDiz.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                lblEuroDizelLit.Text = dr3[4].ToString();
            }
            baglanti.Close();

            //YeniProDizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from TBLBENZIN where petroltur='YeniProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblYeniPro.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                lblYeniProLit2.Text = dr4[4].ToString();
            }
            baglanti.Close();

            //Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from TBLBENZIN where petroltur='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblGaz.Text = dr5[3].ToString();
                progressBar5.Value = int.Parse(dr5[4].ToString());
                lblGazLit.Text = dr5[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from TBLKASA", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while(dr6.Read())
            {
                lblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lblKur95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            txtKursunsuz95Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lblKur97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;
            txtKursunsuz97Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel, litre, tutar;
            eurodizel = Convert.ToDouble(lblEuroDiz.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = eurodizel * litre;
            txtEuroDizelFiyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double yeniprodizel, litre, tutar;
            yeniprodizel = Convert.ToDouble(lblYeniPro.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = yeniprodizel * litre;
            txtYeniProFiyat.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblGaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;
            txtGazFiyat.Text = tutar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value!=0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tblhareket (plaka,benzInturu,LITRE,FIYAT) values (@P1,@P2,@P3,@P4)", baglanti);
                komut.Parameters.AddWithValue("@P1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@P2", "Kurşunsuz 95");
                komut.Parameters.AddWithValue("@P3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@P4", decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tblkasa set MIKTAR=MIKTAR+@P1", baglanti);
                komut2.Parameters.AddWithValue("@P1", decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@P1 where petroltur='kurşunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@P1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Satış yapıldı!");
                listele();
            }
        }
    }
}
