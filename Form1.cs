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

        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 328;
            textBox1.Width = 268;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 624;
            textBox1.Width = 587;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 328;
            textBox1.Width = 268;
        }

        private void button_Click(object sender, EventArgs e)
        {
            

            Button num = (Button)sender;
            if ((textBox1.Text == "0") || (enter_value))
            {     
                if(num.Text == ".")
                {
                    textBox1.Text = "0" + ".";
                }
                else
                    textBox1.Text = "";
            }
            
            
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;

            enter_value = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblShowOp.Text = "";
            results = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblShowOp.Text = "";
            results = 0;

        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
                textBox1.Text = "0";
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            operation = op.Text;
            enter_value = true;
            lblShowOp.Text += textBox1.Text + " " + operation + " ";
            if (!(results == 0)){
                switch (operation)
                {
                    case "+":
                        textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "−":
                        textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "÷":
                        textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
            results = Double.Parse(textBox1.Text);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            lblShowOp.Text += textBox1.Text + " = " ;
            switch (operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "−":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q = results;
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
                default:
                    break;
            }
            results = 0;

        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.1415926535897932384626433832795";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            ilog = Math.Log10(ilog);            
            lblShowOp.Text = "log" + "(" + textBox1.Text + ")";
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(textBox1.Text);
            sqrt = Math.Sqrt(sqrt);
            lblShowOp.Text = "√" + textBox1.Text;
            textBox1.Text = System.Convert.ToString(sqrt);
        }

        private void button_Squared_Cubed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double result = Double.Parse(textBox1.Text);
            double pwr = 0;
            if (button.Text == "x^2")
            {
                pwr = 2;
                lblShowOp.Text = textBox1.Text + "²";
            }
            else
            {
                pwr = 3;
                lblShowOp.Text = textBox1.Text + "³";
            }                
            result = Math.Pow(result, pwr);
            textBox1.Text = System.Convert.ToString(result);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(textBox1.Text);
            lblShowOp.Text = "sinh(" + qSinh.ToString() + ")";
            qSinh = Math.Sinh(qSinh);
            textBox1.Text = qSinh.ToString();
            
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(textBox1.Text);
            lblShowOp.Text = "cosh(" + qCosh.ToString() + ")";
            qCosh = Math.Cosh(qCosh);
            textBox1.Text = qCosh.ToString();
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(textBox1.Text);
            lblShowOp.Text = "tanh(" + qTanh.ToString() + ")";
            qTanh = Math.Tanh(qTanh);
            textBox1.Text = qTanh.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(textBox1.Text);
            lblShowOp.Text = "sin(" + qSin.ToString() + ")";
            qSin = Math.Sin(qSin);
            textBox1.Text = qSin.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(textBox1.Text);
            lblShowOp.Text = "cos(" + qCos.ToString() + ")";
            qCos = Math.Sin(qCos);
            textBox1.Text = qCos.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(textBox1.Text);
            lblShowOp.Text = "tan(" + qTan.ToString() + ")";
            qTan = Math.Sin(qTan);
            textBox1.Text = qTan.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "bin(" + textBox1.Text + ")";
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "bin(" + textBox1.Text + ")";
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "bin(" + textBox1.Text + ")";
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "bin(" + textBox1.Text + ")";
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double inverse = Double.Parse(textBox1.Text);
            inverse = 1.0 / inverse;
            lblShowOp.Text = "1 / " + textBox1.Text;
            textBox1.Text = System.Convert.ToString(inverse);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            ilog = Math.Log(ilog);
            lblShowOp.Text = "log" + "(" + textBox1.Text + ")";
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lblShowOp.Text += " " + textBox1.Text + " % ";
            double percent = Double.Parse(textBox1.Text) * 0.01;
            double operand = Double.Parse(results.ToString());
            switch (operation)
            {
                case "+":
                    textBox1.Text = (operand + operand * percent).ToString();
                    break;
                case "−":
                    textBox1.Text = (operand - operand * percent).ToString();
                    break;
                case "÷":
                    textBox1.Text = (operand / (operand * percent)).ToString();
                    break;
                case "*":
                    textBox1.Text = (operand * (operand * percent)).ToString();
                    break;
                default:
                    textBox1.Text = "0";
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.First() == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else if (!(textBox1.Text == "0")) // No negative zeroes allowed (still allows for zeroes with decimal point eg. 0.000)
                textBox1.Text = textBox1.Text.Insert(0, "-");
        }
    }
}
