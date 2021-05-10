using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDzialania = ' ';

        private void bwyczysc_Click(object sender, EventArgs e)
        {
            tbwynik.Text = "0";
        }

        

        private void brazy_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '*';
            tbwynik.Text = "";
        }

        private void bdziel_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '/';
            tbwynik.Text = "";
        }

        private void bwynik_Click(object sender, EventArgs e)
        {
            switch(RodzajDzialania)
            {
                case ('+'):
                    tbwynik.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('-'):
                    tbwynik.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    tbwynik.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    tbwynik.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;
            }

            LiczbaPierwsza = "";
            LiczbaDruga = "";
            RodzajDzialania = ' ';
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '-';
            tbwynik.Text = "";
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '+';
            tbwynik.Text = "";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }

        private void bprzecinek_Click(object sender, EventArgs e)
        {
            tbwynik.Text = tbwynik.Text + ",";
            tbwynik.Text = Convert.ToString(tbwynik.Text);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        
        private void button9_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void tbwynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dzialanie(int liczba)
        {
            if (RodzajDzialania == ' ')
            {
                LiczbaPierwsza += liczba;
                tbwynik.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                tbwynik.Text = LiczbaDruga;
            }
        }


    }
}
