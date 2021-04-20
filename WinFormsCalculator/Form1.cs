using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float entry1, entry2;
        private string operation;

        private void CEbtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text = "";
        }

        private void Onebtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 1;
        }


        private void Twobtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 2;
        }

        private void Threebtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 3;
        }

        private void Fourbtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 4;
        }
        private void Fivebtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 5;
        }

        private void Sixbtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 6;
        }

        private void Sevenbtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 7;
        }

        private void Eightbtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 8;
        }

        private void Ninebtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 9;
        }

        private void Zerobtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text += 0;
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            Entrytxt.Text = "";
            entry1 = 0;
            entry2 = 0;
        }

        private void SignChangebtn_Click(object sender, EventArgs e)
        {
            if (!Entrytxt.Text.Contains("-"))
            {
                Entrytxt.Text = "-" + Entrytxt.Text;
            }
            else if (Entrytxt.Text.Contains("-"))
            {
                Entrytxt.Text = Entrytxt.Text.Remove(0, 1);
            }
        }

        private void Decimalbtn_Click(object sender, EventArgs e)
        {
            if(!Entrytxt.Text.Contains("."))
            {
                Entrytxt.Text += ".";
            }
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            entry2 = float.Parse(Entrytxt.Text);
            string result = Calculate(entry1, entry2, operation).ToString();
            Entrytxt.Text = result;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            entry1 = float.Parse(Entrytxt.Text);
            Entrytxt.Text = "";
            operation = "+";
        }

        private void Subtractbtn_Click(object sender, EventArgs e)
        {
            entry1 = float.Parse(Entrytxt.Text);
            Entrytxt.Text = "";
            operation = "-";
        }

        private void Multiplybtn_Click(object sender, EventArgs e)
        {
            entry1 = float.Parse(Entrytxt.Text);
            Entrytxt.Text = "";
            operation = "-";
        }

        private void Dividebtn_Click(object sender, EventArgs e)
        {
            entry1 = float.Parse(Entrytxt.Text);
            Entrytxt.Text = "";
            operation = "/";
        }

        private void Squarebtn_Click(object sender, EventArgs e)
        {
            float entry = float.Parse(Entrytxt.Text);
            Entrytxt.Text = (entry * entry).ToString();
        }

        private void Entrytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            SoundPlayer drum = new SoundPlayer(@"C:\2021\Spring\AppDev\AppDevSln\WinFormsCalculator\resources\drum.wav");
            drum.Play();
        }

        private float Calculate(float entry1, float entry2, string operation)
        {
            switch(operation)
            {
                case "+":
                    return entry1 + entry2;
                case "-":
                    return entry1 - entry2;
                case "*":
                    return entry1 * entry2;
                case "/":
                    return entry1 / entry2;
                default:
                    return 0;
            }
        }
    }
}
