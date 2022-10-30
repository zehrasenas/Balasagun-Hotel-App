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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=BalasagunPansiyon;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AlinanUrunler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text=oku["Gıda"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new  SqlCommand("insert into AlinanUrunler(Gıda,İcecek,Cerezler) values ('"+TxtGidalar.Text+"','"+Txtİcecekler.Text+"','"+TxtAtistirmaliklar.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
        }
    }
}
