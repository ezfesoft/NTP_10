using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_ntp_03_05_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Temel OLAYLAR------

        private void Form1_Load(object sender, EventArgs e)
        {
            // form açılırken gerçekleşir.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapanmadan hemen önce gerçekleşir
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form kapandıktan sonra gerçekleşir
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Form üzerine tıklandığında gerçekleşir
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label_active.Text = "AKTİF";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Çalıştı");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESC Çalıştı");
        }

        private void btnControlBox_Click(object sender, EventArgs e)
        {
            if (this.ControlBox==true)
            {
                this.ControlBox = false;
            }
            else
            {
                this.ControlBox = true;
            }
        }

        private void btnCenterToScreen_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form2 ekran2 = new Form2();
            ekran2.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            Form2 ekran2 = new Form2();
            ekran2.ShowDialog();
        }

        // Temel OLAYLAR------

    }
}
