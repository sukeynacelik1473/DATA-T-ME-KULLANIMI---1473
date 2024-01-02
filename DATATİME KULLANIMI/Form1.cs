using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATATİME_KULLANIMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tarihSaat = new DateTime();
            tarihSaat = DateTime.Now;

            DateTime tarih = new DateTime();
            tarih = DateTime.Today;

            label1.Text = tarihSaat.ToString();
            label2.Text = tarih.ToString();
        }
    }
}
