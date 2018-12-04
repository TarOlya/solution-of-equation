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
            int p = Decimal.ToInt32(selectPower.Value);
            double[] arr = new double[p+1];
            // { double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text) };
            for (int i = 0; i <= p; i++)
            {
                arr[i] = double.Parse(Controls["textBox" + (i+1)].Text);
            }

            Equation eq = new Equation(arr);

            Graph(eq);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p = Decimal.ToInt32(selectPower.Value);
            double[] arr = new double[p+1];
            for (int i = 0; i <= p; i++)
            {
                arr[i] = double.Parse(Controls["textBox" + (i+1)].Text);
            }

            Equation eq = new Equation(arr);
            
            List<Complex> resh=eq.Solve();
            
            Print(resh);
            
        }
        public void Print(List<Complex> a) {

            dataGridView1.Rows.Clear();
            for (int i = 0; i < a.Count; i++)
            {
                dataGridView1.Rows.Add(a[i]);
            }
        }


        public void Graph(Equation eq)
        {
            double x =0, y = 0;
            chart1.Series["graf"].Points.Clear();
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            for ( x = -10; x < 10; x++)
            {
                y = 0;
                for (int i = 0; i < eq.coef.Length; i++)
                {
                    y += Math.Pow(x,i)*eq.coef[i];
                }
                chart1.Series["graf"].Points.AddXY(x, y);
            }
        }

        public static double Sqrt3(double x)
        {
            return Math.Sign(x) * Math.Pow(Math.Abs(x), 1 / 3.0);
        }

        
    }
}
