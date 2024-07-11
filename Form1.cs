using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        char _Islem;
        bool _ekrantemzileme;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrakam1_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text=="0") hesaplabel.Text=" ";
            hesaplabel.Text += "1";
        }

        private void btnrakam2_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text == "0") hesaplabel.Text = " ";
            hesaplabel.Text += "2";
        }

        private void btnrakam3_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text == "0") hesaplabel.Text = " ";
            hesaplabel.Text += "3";
        }

        private void btnrakam4_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text == "0") hesaplabel.Text = " ";
            hesaplabel.Text += "4";
        }

        private void btnrakam5_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text == "0") hesaplabel.Text = " ";
            hesaplabel.Text += "5";
        }

        private void btnrakam6_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text == "0") hesaplabel.Text = " ";
            hesaplabel.Text += "6";
        }

        private void btnrakam7_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text == "0") hesaplabel.Text = " ";
            hesaplabel.Text += "7";
        }

        private void btnrakam8_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text == "0") hesaplabel.Text = " ";
            hesaplabel.Text += "8";
        }

        private void btnrakam9_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text == "0") hesaplabel.Text = " ";
            hesaplabel.Text += "9";
        }

        private void btnrakam0_Click(object sender, EventArgs e)
        {
            if (_ekrantemzileme)
            {
                hesaplabel.Text = "";
                _ekrantemzileme = false;
            }
            if (hesaplabel.Text == "0") hesaplabel.Text = " ";
            hesaplabel.Text += "0";
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            _Islem = '+';
            _ekrantemzileme = true;
            _ilksayi=Convert.ToInt32(hesaplabel.Text);
        }

        private void btnesittir_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(hesaplabel.Text);
            int sonuc;
            switch(_Islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    sonuc =0;
                    break;

            }
            hesaplabel.Text=Convert.ToString(sonuc);
        }

        private void brncikar_Click(object sender, EventArgs e)
        {
            _Islem = '-';
            _ekrantemzileme = true;
            _ilksayi = Convert.ToInt32(hesaplabel.Text);
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            _Islem = '*';
            _ekrantemzileme = true;
            _ilksayi = Convert.ToInt32(hesaplabel.Text);
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            _Islem = '/';
            _ekrantemzileme = true;
            _ilksayi = Convert.ToInt32(hesaplabel.Text);
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            hesaplabel.Text = "0";
        }
    }
}
