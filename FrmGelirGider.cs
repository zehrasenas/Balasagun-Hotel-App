using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Balasagun_Pansiyon_ve_Dinlenme_Tesisleri
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=BalasagunPansiyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {


            int personel;
            personel=Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text=(personel*4253).ToString();


            int sonuc;
            sonuc=Convert.ToInt32(LblKasaToplam.Text)-(Convert.ToInt32(LblPersonelMaas.Text)+Convert.ToInt32(LblAlinanUrunler1.Text)+Convert.ToInt32(LblAlinanUrunler2.Text)+Convert.ToInt32(LblAlinanUrunler3.Text));
            LblSonuc.Text=sonuc.ToString();

        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {

            //Kasa da ki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text=oku["toplam"].ToString();
            }
            baglanti.Close();


            //gıda giderleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gıda) as toplam1 from AlinanUrunler", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrunler1.Text=oku2["toplam1"].ToString();
            }
            baglanti.Close();


            //içecek giderleri
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(İcecek) as toplam2 from AlinanUrunler", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrunler2.Text=oku3["toplam2"].ToString();
            }
            baglanti.Close();

            //cerez giderleri
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from AlinanUrunler", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrunler3.Text=oku4["toplam3"].ToString();
            }
            baglanti.Close();

        }
    }
}
