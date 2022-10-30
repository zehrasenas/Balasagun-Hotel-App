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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=BalasagunPansiyon;Integrated Security=True");

        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='"+TxtKullaniciAdi.Text+"',Sifre='"+TxtSifre.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
        }
    }
}
