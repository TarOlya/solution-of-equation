using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            selectPower.ReadOnly = true;
            selectPower.Minimum = 1;
            selectPower.Maximum = 5;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

        }
        

        private void selectPower_ValueChanged(object sender, EventArgs e)
        {
            int p = Decimal.ToInt32(selectPower.Value);
            switch (p)
            {
                case 1:
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;

                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;
                        break;
                    }

                case 2:
                    {
                        textBox3.Visible = true;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;

                        label4.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        break;
                    }
                case 3:
                    {
                        textBox4.Visible = true;
                        textBox5.Visible = false;
                        textBox6.Visible = false;

                        label5.Visible = true;
                        label6.Visible = false;
                        label7.Visible = false;
                        break;
                    }
                case 4:
                    {
                        textBox5.Visible = true;
                        textBox6.Visible = false;
                        
                        label6.Visible = true;
                        label7.Visible = false;
                        break;
                    }
                case 5:
                    {
                        textBox6.Visible = true;
                        
                        label7.Visible = true;
                        break;
                    }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Decimal.ToInt32(selectPower.Value)+1;
            double[] arr = new double[p];
            // { double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text) };
            for (int i = 0; i < p; i++)
            {
                arr[i] = double.Parse(Controls["textBox" + (i+1)].Text);
            }
            double x =0, y = 0;
            chart1.Series["graf"].Points.Clear();
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            for ( x = -10; x < 10; x++)
            {
                y = 0;
                for (int i = 0; i < p; i++)
                {
                    y += Math.Pow(x,i)*arr[i];
                }
                chart1.Series["graf"].Points.AddXY(x, y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p = Decimal.ToInt32(selectPower.Value)+1;
            double[] arr = new double[p];
            string[] resh = new string[p];
            for (int i = 0; i < p; i++)
            {
                arr[i] = double.Parse(Controls["textBox" + (i+1)].Text);
            }
            if (p == 2)
            {
                resh = solve1PEq(arr);
            }
            else if (p == 3)
            {
                resh = solve2PEq(arr);
            }
            else if (p == 4)
            {
                resh = Solve3Eq(arr);
            }

            Print(resh);
            
        }
        public void Print(string[] a) {

            dataGridView1.Rows.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                dataGridView1.Rows.Add(a[i]);
            }
        }
        

        static public string[] solve2PEq(double[] arr)
        {
            string[] a = new string[2];
            double d = arr[1] * arr[1] - 4 * arr[0] * arr[2];
            if (d >= 0)
            {
                a[0] = (-1 * arr[1] - Math.Sqrt(d) / (2 * arr[2])).ToString();
                a[1] = (-1 * arr[1] + Math.Sqrt(d) / (2 * arr[2])).ToString();
            }
            else {
                double real =-1 * arr[1] / (2 * arr[2]);
                double im = Math.Sqrt(-1 * d) / (2 * arr[2]);
                if (im < 0)
                {
                    im = im * (-1);
                }
                if (im > 0) { 
                    a[0] = String.Format("{0:0.###} + {1:0.###}*i", real, im);
                    a[1] = String.Format("{0:0.###} - {1:0.###}*i", real, im);
                }
            }
            return a;
            
        }

        static string[] Solve3Eq(double[] arr) 
        {
            double p = (3 * arr[3] * arr[1] - arr[2] * arr[2]) / (3 * arr[3] * arr[3]);
            double q = (2 * arr[2] * arr[2] * arr[2] - 9 * arr[3] * arr[2] * arr[1] + 27 * arr[3] * arr[3] * arr[0]) / (27 * arr[3] * arr[3] * arr[3]);
            double Q = Math.Pow((p / 3.0), 3.0) + Math.Pow((q / 2.0), 2.0);
            double zam = -(arr[2] / (3 * arr[3]));
            string[] a = new string[3];
            if (Q < 0) {
                Q = Q * (-108);
                double alfa = Sqrt3(-1 * q / 2 + Math.Sqrt(Q));
                double beta = Sqrt3(-1 * q / 2 - Math.Sqrt(Q));
                double y1 = alfa + beta;

                a[0] = String.Format("{0:0.###}", y1+zam); 
                double y2a = -1 * (alfa + beta) / 2;
                double y2b = ((alfa - beta) / 2) * Math.Sqrt(3);
                a[1]= String.Format("{0:0.###}", y2a + y2b+zam);
                a[2]= String.Format("{0:0.###}", y2a - y2b+zam);
            }
            else 
            {
                double alfa = Sqrt3(-1 * q / 2 + Math.Sqrt(Q));
                double beta = Sqrt3(-1 * q / 2 - Math.Sqrt(Q));
                double y1 = alfa + beta - (arr[2] / (3 * arr[3]));
                a[0] = String.Format("{0:0.###}", y1);
                double real = -1 * (alfa + beta) / 2+zam;
                double im = ((alfa - beta) / 2) * Math.Sqrt(3);
                if (im < 0) {
                    im = im * (-1);
                }
                if (im > 0)
                {
                    a[1] = String.Format("{0:0.###} - {1:0.###}*i", real, im);
                    a[2] = String.Format("{0:0.###} + {1:0.###}*i", real, im);
                }
            }
            return a;
        }
        
        public static double Sqrt3(double x)
        {
            return Math.Sign(x) * Math.Pow(Math.Abs(x), 1 / 3.0);
        }


        public static double Arch(double x) {
            return Math.Log(x + Math.Sqrt(x * x - 1));
        }

        public static double Sgn(double x) {
            return x > 0 ? 1 : x < 0 ? -1 : 0;
        }
    }
}
