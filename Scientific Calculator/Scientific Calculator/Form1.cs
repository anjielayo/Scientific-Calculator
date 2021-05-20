using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{

    public partial class Form1 : Form
    {
        double op1;
        double op2;
        double ans;
        string oper;
        string percentans;
        string expans;
        string alogans;
        string log10ans;
        string nlogans;
        string randans;
        string factans;
        string sqrtans;
        string invans;
        string tanans;
        string sinans;
        string cosans;
        string taninans;
        string cosinans;
        string sininans;
        string hyptan;
        string hypsin;
        string hypcos;

        public Form1()
        {
            InitializeComponent();
        }
        public double factorial(double x)
        {
            double fact = 1;
            op1 = Convert.ToDouble(disp.Text);

            for (x = op1; op1 > 0; op1--)
            {
                fact *= op1;
            }
            return fact;
        
        }
        private void Two_Click(object sender, EventArgs e)
        {
            disp.Text += "2";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            disp.Text += ".";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            disp.Text += "0";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            disp.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp.Text += "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AC_Click(object sender, EventArgs e)
        {
            disp.Text = String.Empty;
            /*disp.Enabled = true;
            zero.Enabled = true;
            One.Enabled = true;
            Two.Enabled = true;
            Three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            seven.Enabled = true;
            eight.Enabled = true;
            nine.Enabled = true;
            equal.Enabled = true;*/
        }

        private void div_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "/";
            disp.Text = String.Empty;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "l10";
            log10ans = Convert.ToString(Math.Log10(op1));
            disp.Text = log10ans;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oper = "sh";
            if (radian.Checked == true)
            {
                disp.Text = Convert.ToString(Math.Sinh((Convert.ToDouble(disp.Text))));
                taninans = disp.Text;
            }
            else
            {
                disp.Text = Convert.ToString(Math.Sinh(((Math.PI) / 180) * (Convert.ToDouble(disp.Text))));
                taninans = disp.Text;
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "%";
            percentans = Convert.ToString(op1 / 100);
            disp.Text = percentans;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void One_Click(object sender, EventArgs e)
        {
            disp.Text += "1";

        }

        private void Three_Click(object sender, EventArgs e)
        {
            disp.Text += "3";
        }

        private void six_Click(object sender, EventArgs e)
        {
            disp.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            disp.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            disp.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            disp.Text += "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "+";
            disp.Text = String.Empty;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            op2 = Convert.ToDouble(disp.Text);
            switch (oper)
            {
                case "+":
                    ans = op1 + op2;
                    disp.Text = Convert.ToString(ans);
                    break;
                case "-":
                    ans = op1 - op2;
                    disp.Text = Convert.ToString(ans);
                    break;
                case "*":
                    ans = op1 * op2;
                    disp.Text = Convert.ToString(ans);
                    break;
                case "/":
                    ans = op1 / op2;
                    disp.Text = Convert.ToString(ans);
                    break;
                case "%":
                    disp.Text = percentans;
                    break;
                case "exp":
                    disp.Text = expans;
                    break;
                case "l10ans":
                    disp.Text = log10ans;
                    break;
                case "rand":
                    disp.Text = randans;
                    break;
                case "fact":
                    disp.Text = factans;
                    break;
                case "pow":
                    ans = Math.Pow(op1, op2);
                    disp.Text = Convert.ToString(ans);
                    break;
                case "inv":
                    disp.Text = invans;
                    break;
                case "th":
                    disp.Text = hyptan;
                    break;
                case "ti":
                    disp.Text = taninans;
                    break;
                case "tan":
                    disp.Text = tanans;
                    break;
                case "sh":
                    disp.Text = hypsin;
                    break;
                case "si":
                    disp.Text = sininans;
                    break;
                case "sin":
                    disp.Text = sinans;
                    break;
                case "ch":
                    disp.Text = hypcos;
                    break;
                case "ci":
                    disp.Text = cosinans;
                    break;
                case "cos":
                    disp.Text = cosans;
                    break;
                case "perm":
                    double var1, var2;
                    var1 = factorial(op1);
                    var2 = factorial(op1-(Convert.ToDouble(disp.Text)));
                    disp.Text = Convert.ToString(var1 / var2);
                    break;
                case "comb":
                    double var3;
                    var1 = factorial(op1);
                    var2 = factorial(op1 - (Convert.ToDouble(disp.Text)));
                    var3 = factorial(Convert.ToDouble(disp.Text));
                    disp.Text = Convert.ToString(var1 / (var2*var3));
                    break;


            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "-";
            disp.Text = String.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "*";
            disp.Text = String.Empty;
        }

        private void neg_Click(object sender, EventArgs e)
        {
            if (disp.Text.Contains("-"))
            {
                disp.Text = disp.Text.Remove(0, 1);
            }
            else
            {
                disp.Text = "-" + disp.Text;
            }
        }

        private void exp_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "exp";
            expans = Convert.ToString(Math.Exp(op1));
            disp.Text = expans;
        }

        private void PI_Click(object sender, EventArgs e)
        {
            disp.Text = Convert.ToString(Math.PI);
        }

        private void antilog_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "alog";
            alogans = Convert.ToString(Math.Pow(10, op1));
            disp.Text = alogans;
        }

        private void rand_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            oper = "rand";
            double getRand = r.NextDouble();
            randans = Convert.ToString(getRand);
            disp.Text = randans;
        }

        private void fact_Click(object sender, EventArgs e)
        {
            oper = "fact";
            double var1,var2;
            var1 = Convert.ToDouble(disp.Text);
            var2 = factorial(var1);
            factans = Convert.ToString(var2);
            disp.Text = factans;

        }

        private void power_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "pow";
            disp.Text = String.Empty;
        }

        private void ln_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "nlog";
            nlogans = Convert.ToString(Math.Log(op1));
            disp.Text = nlogans;
        }

        private void xin_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "inv";
            invans = Convert.ToString(1/op1);
            disp.Text = invans;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "sqrt";
            sqrtans = Convert.ToString(Math.Sqrt(op1));
            disp.Text = sqrtans;
        }

        private void tan_Click(object sender, EventArgs e)
        {
            oper = "tan";
            if (radian.Checked == true)
            {
                disp.Text = Convert.ToString(Math.Tan((Convert.ToDouble(disp.Text))));
                tanans = disp.Text;
            }
            else
            {
                disp.Text = Convert.ToString(Math.Tan(((Math.PI) / 180) * (Convert.ToDouble(disp.Text))));
                tanans = disp.Text;
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            oper = "sin";
            if (radian.Checked == true)
            {
                disp.Text = Convert.ToString(Math.Sin((Convert.ToDouble(disp.Text))));
                sinans = disp.Text;
            }
            else
            {
                disp.Text = Convert.ToString(Math.Sin(((Math.PI) / 180)*(Convert.ToDouble(disp.Text))));
                sinans = disp.Text;
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            oper = "cos";
            if (radian.Checked == true)
            {
                disp.Text = Convert.ToString(Math.Cos((Convert.ToDouble(disp.Text))));
                cosans = disp.Text;
            }
            else
            {
                disp.Text = Convert.ToString(Math.Cos(((Math.PI) / 180) * (Convert.ToDouble(disp.Text))));
                cosans = disp.Text;
            }
        }

        private void tanin_Click(object sender, EventArgs e)
        {
            oper = "ti";
            if (radian.Checked == true)
            {
                disp.Text = Convert.ToString(Math.Atan((Convert.ToDouble(disp.Text))));
                taninans = disp.Text;
            }
            else
            {
                disp.Text = Convert.ToString(Math.Atan(((Math.PI) / 180) * (Convert.ToDouble(disp.Text))));
                taninans = disp.Text;
            }
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            oper = "th";
            if (radian.Checked == true)
            {
                disp.Text = Convert.ToString(Math.Tanh((Convert.ToDouble(disp.Text))));
                taninans = disp.Text;
            }
            else
            {
                disp.Text = Convert.ToString(Math.Tanh(((Math.PI) / 180) * (Convert.ToDouble(disp.Text))));
                taninans = disp.Text;
            }
        }

        private void cosin_Click(object sender, EventArgs e)
        {
            oper = "ci";
            if (radian.Checked == true)
            {
                disp.Text = Convert.ToString(Math.Acos((Convert.ToDouble(disp.Text))));
                cosinans = disp.Text;
            }
            else
            {
                disp.Text = Convert.ToString(Math.Acos(((Math.PI) / 180) * (Convert.ToDouble(disp.Text))));
                cosinans = disp.Text;
            }
        }

        private void sinin_Click(object sender, EventArgs e)
        {
            oper = "si";
            if (radian.Checked == true)
            {
                disp.Text = Convert.ToString(Math.Asin((Convert.ToDouble(disp.Text))));
                sininans = disp.Text;
            }
            else
            {
                disp.Text = Convert.ToString(Math.Asin(((Math.PI) / 180) * (Convert.ToDouble(disp.Text))));
                sininans = disp.Text;
            }
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            oper = "ch";
            if (radian.Checked == true)
            {
                disp.Text = Convert.ToString(Math.Cosh((Convert.ToDouble(disp.Text))));
                taninans = disp.Text;
            }
            else
            {
                disp.Text = Convert.ToString(Math.Cosh(((Math.PI) / 180) * (Convert.ToDouble(disp.Text))));
                taninans = disp.Text;
            }
        }

        private void comb_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "comb";
            disp.Text = String.Empty;
        }

        private void perm_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(disp.Text);
            oper = "perm";
            disp.Text = String.Empty;
        }
    }
}
    
    

