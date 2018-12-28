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

            try
            {

                PloteGraph graph = new PloteGraph(eq, chart1);

                if (autosizeX.Checked && autosizeY.Checked)
                {
                    List<Complex> Responce_X_Min_Max = eq.Solve();

                    double xMin = double.NaN;
                    double xMax = double.NaN;

                    for (int i = 0; i < Responce_X_Min_Max.Count; i++)
                    {
                        if (Responce_X_Min_Max[i]._im == 0)
                        {
                            xMin = Responce_X_Min_Max[i]._real;
                            xMax = Responce_X_Min_Max[i]._real;
                            break;
                        }
                    }

                    if (!Double.IsNaN(xMin))
                        for (int i = 0; i < Responce_X_Min_Max.Count; i++)
                        {
                            if (xMin > Responce_X_Min_Max[i]._real && Responce_X_Min_Max[i]._im == 0)
                            {
                                xMin = Responce_X_Min_Max[i]._real;
                            }

                            if (xMax < Responce_X_Min_Max[i]._real && Responce_X_Min_Max[i]._im == 0)
                            {
                                xMax = Responce_X_Min_Max[i]._real;
                            }
                        }

                    if (xMin == xMax || Double.IsNaN(xMin) || Double.IsNaN(xMax)) { xMin = -10; xMax = 10; }

                    graph.AutoSize(xMin, xMax);
                }

                if (!autosizeX.Checked && !autosizeY.Checked)
                {
                    graph.SizeXandY(Convert.ToDouble(X_min.Text), Convert.ToDouble(X_max.Text), Convert.ToDouble(Y_min.Text), Convert.ToDouble(Y_max.Text));
                }

                if (!autosizeX.Checked && autosizeY.Checked)
                {
                    graph.SizeX(Convert.ToDouble(X_min.Text), Convert.ToDouble(X_max.Text));
                }

                if (autosizeX.Checked && !autosizeY.Checked)
                {
                    

                    

                    List<Complex> Responce_X_Min_Max = eq.Solve();

                    double xMin = double.NaN;
                    double xMax = double.NaN;

                    for (int i = 0; i < Responce_X_Min_Max.Count; i++)
                    {
                        if (Responce_X_Min_Max[i]._im == 0)
                        {
                            xMin = Responce_X_Min_Max[i]._real;
                            xMax = Responce_X_Min_Max[i]._real;
                            break;
                        }
                    }

                    if (!Double.IsNaN(xMin))
                        for (int i = 0; i < Responce_X_Min_Max.Count; i++)
                        {
                            if (xMin > Responce_X_Min_Max[i]._real && Responce_X_Min_Max[i]._im == 0)
                            {
                                xMin = Responce_X_Min_Max[i]._real;
                            }

                            if (xMax < Responce_X_Min_Max[i]._real && Responce_X_Min_Max[i]._im == 0)
                            {
                                xMax = Responce_X_Min_Max[i]._real;
                            }
                        }

                    if (xMin == xMax || Double.IsNaN(xMin) || Double.IsNaN(xMax)) { xMin = -10; xMax = 10; }

                    graph.SizeY(xMin, xMax, Convert.ToDouble(Y_min.Text), Convert.ToDouble(Y_max.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: {0}",ex.Message);
            }

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
            Print(resh,eq);
                
            
        }
        public void Print(List<Complex> a,Equation eq) {

            dataGridView1.Rows.Clear();

            for (int i = 0; i < a.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0,i].Value=$"x({i+1})={a[i]}";
                dataGridView1[1, i].Value = $"f({a[i]})={eq.FunctionValue(a[i])}";
            }
        }
        
        public void Print(String a) {

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(a);
            
        }

        

        private void autosizeX_CheckedChanged(object sender, EventArgs e)
        {
            if (!autosizeX.Checked)
            {
                X_min.Enabled = true;
                X_max.Enabled = true;
            }
            else
            {
                X_min.Enabled = false;
                X_max.Enabled = false;
            }
        }

        private void autosizeY_CheckedChanged(object sender, EventArgs e)
        {
            if (!autosizeY.Checked)
            {
                Y_min.Enabled = true;
                Y_max.Enabled = true;
            }
            else
            {
                Y_min.Enabled = false;
                Y_max.Enabled = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number!=127)
            {
                e.Handled = true;
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 127)
            {
                e.Handled = true;
            }
        }

        

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void Y_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void Y_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void X_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void X_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45 && number != 127)
            {
                e.Handled = true;
            }
        }
    }
}
