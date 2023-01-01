using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziUgulamalari1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];   // Global Dizi
        int index = 0;                      //Global Değişken
        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler[index]=txtAdSoyad.Text;
            index++;
        }
    }
}
