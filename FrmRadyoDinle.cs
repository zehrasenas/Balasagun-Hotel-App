using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balasagun_Pansiyon_ve_Dinlenme_Tesisleri
{
    public partial class FrmRadyoDinle : Form
    {
        public FrmRadyoDinle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL="http://yayin1.yayindakiler.com:3156/";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL="http://yayin2.yayindakiler.com:4202/";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL="http://yayin2.yayindakiler.com:4204/";
        }
    }
}
