using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Scientific_Calculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, iKevin;
        char iOperation;

        public Form1()
        {
            InitializeComponent();
        }


       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 326;
            txtDisplay.Width = 286;
        }

        private void standardniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 326;
            txtDisplay.Width = 286;
            label5.Visible = false;
        }

        private void znanstveniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 644;
            txtDisplay.Width = 587;
            label5.Visible = true;
            Odabir.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pretvraračTemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 970;
            txtDisplay.Width = 587;
            label5.Visible = false;
            Odabir.Visible = true;
            label7.Visible = false;
        }

        private void višekratniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 961;
            txtDisplay.Width = 587;
            label5.Visible = false;
            Odabir.Visible = false;
            label7.Visible = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;

            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
            if (txtDisplay.Text == "0")
            label6.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            label1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length >0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Aritmethic_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            label1.Text = System.Convert.ToString(results) + "  " + operation;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "×":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {

            double i = Double.Parse(txtDisplay.Text);
            double q;
            q = (results);
            txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3,14159265358979323846";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("'Nije definirano'" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            txtDisplay.Text = System.Convert.ToString(qTanh);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double a;

            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            label1.Text = System.Convert.ToString("X×X" + "(" + (txtDisplay.Text) + ")");
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("Sqrt" + "(" + (txtDisplay.Text) + ")");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Double a;

            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            label1.Text = System.Convert.ToString("X×X×X" + "(" + (txtDisplay.Text) + ")");
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double qsin = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
            qsin = Math.Sin(qsin);
            txtDisplay.Text = System.Convert.ToString(qsin);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("Sinh" + "(" + (txtDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtDisplay.Text = System.Convert.ToString(qSinh);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double qcos = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")");
            qcos = Math.Cos(qcos);
            txtDisplay.Text = System.Convert.ToString(qcos);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double qcosh = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")");
            qcosh = Math.Cosh(qcosh);
            txtDisplay.Text = System.Convert.ToString(qcosh);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")");
            qTan = Math.Tan(qTan);
            txtDisplay.Text = System.Convert.ToString(qTan);
        }

        private void promjenaBojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button40.Show();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
        }

        private void očistiPorukeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void vratiPorukeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible = true;
        }

        private void promjenaBojauputeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button41.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            label5.BackColor = colorDialog2.Color;
            label6.BackColor = colorDialog2.Color;
        }

        private void mojaRodicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblKamenje.Visible = true;
            lblGit.Visible = true;
        }

        private void lblGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            switch(iOperation)
            {

                case 'C':
                    //C° to F°
                    iCelsius = float.Parse(txtConvert.Text);
                    label4.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;

                case 'F':
                    //F° to C°
                    iFahrenheit = float.Parse(txtConvert.Text);
                    label4.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;

                case 'K':
                    //U Kevine
                    iKevin = float.Parse(txtConvert.Text);
                    label4.Text = (((((9 * iCelsius) / 5) + 32) +273.15.ToString()));
                    break;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            txtConvert.Clear();
            label4.Text = "Load...";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            
        }

        private void sakrijBojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button40.Visible = false;
            button41.Visible = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }
    }
}