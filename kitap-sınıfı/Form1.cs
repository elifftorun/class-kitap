using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap_sınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap1=new Kitap();
            kitap1.adı = "Bronz";
            kitap1.sayfaSayısı = "446";
            kitap1.turu = "Roman";
            kitap1.yazarı = "Özge Naz";
            kitap1.yayınEvi = "Ren YayınEvi";
            label1.Text = kitap1.adı + " " + kitap1.sayfaSayısı + " " + kitap1.turu +
                " " + kitap1.yazarı + " " + kitap1.yayınEvi;
        }

 
        
    }
}
