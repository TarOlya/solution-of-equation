using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation
{
    public class Equation
    {
        public double[] coef;

        public Equation(double[] coef)
        {
            this.coef = coef;
        }

        public List<Complex> Solve()
        {
            int p = this.coef.Length - 1;
            return p == 1 ? FirstPower(this) :
                p == 2 ? SecondPower(this) :
                p == 3 ? ThirdPower(this) :
                p == 4 ? FourthPower(this) : new List<Complex>();
        }

        private List<Complex> FirstPower(Equation eq)
        {
            List<Complex> solution = new List<Complex>();
            solution.Add(new Complex(eq.coef[0] / (-1 * eq.coef[1]), 0.0));
            return solution;
        }

        private List<Complex> SecondPower(Equation eq)
        {
            List<Complex> solution = new List<Complex>();
            double d = eq.coef[1] * eq.coef[1] - 4 * eq.coef[0] * eq.coef[2];
            if (d >= 0)
            {
                solution.Add(new Complex((-1 * eq.coef[1] - Math.Sqrt(d)) / (2 * eq.coef[2]), 0.0));
                solution.Add(new Complex((-1 * eq.coef[1] + Math.Sqrt(d)) / (2 * eq.coef[2]), 0.0));
            }
            else
            {
                solution.Add(new Complex((-1 * eq.coef[1] / (2 * eq.coef[2])), (Math.Sqrt(-1 * d)) / (2 * eq.coef[2])));
                solution.Add(new Complex((-1 * eq.coef[1] / (2 * eq.coef[2])), (-1 * Math.Sqrt(-1 * d)) / (2 * eq.coef[2])));
            }

            return solution;
        }

        private List<Complex> ThirdPower(Equation eq)
        {
            List<Complex> solution = new List<Complex>();

            double p = (3 * eq.coef[3] * eq.coef[1] - eq.coef[2] * eq.coef[2]) / (3 * eq.coef[3] * eq.coef[3]);
            double q = (2 * eq.coef[2] * eq.coef[2] * eq.coef[2] - 9 * eq.coef[3] * eq.coef[2] * eq.coef[1] +
                        27 * eq.coef[3] * eq.coef[3] * eq.coef[0]) / (27 * eq.coef[3] * eq.coef[3] * eq.coef[3]);
            double Q = Math.Pow((p / 3.0), 3.0) + Math.Pow((q / 2.0), 2.0);
            double zam = -(eq.coef[2] / (3 * eq.coef[3]));
            string[] a = new string[3];
            if (Q < 0)
            {
                Q = Q * (-108);
                double alfa = Sqrt3(-1 * q / 2 + Math.Sqrt(Q));
                double beta = Sqrt3(-1 * q / 2 - Math.Sqrt(Q));
                double y1 = alfa + beta;

                solution.Add(new Complex(y1 + zam, 0.0));
                double y2a = -1 * (alfa + beta) / 2;
                double y2b = ((alfa - beta) / 2) * Math.Sqrt(3);
                solution.Add(new Complex(y2a + y2b + zam, 0.0));
                solution.Add(new Complex(y2a - y2b + zam, 0.0));
            }
            else if (Q > 0)
            {
                double alfa = Sqrt3(-1 * q / 2 + Math.Sqrt(Q));
                double beta = Sqrt3(-1 * q / 2 - Math.Sqrt(Q));
                double y1 = alfa + beta;
                solution.Add(new Complex(y1 + zam, 0.0));
                double real = -1 * (alfa + beta) / 2 + zam;
                double im = ((alfa - beta) / 2) * Math.Sqrt(3);

                solution.Add(new Complex(real, im));
                solution.Add(new Complex(real, -1 * im));
            }
            else if (Math.Round(Q) == 0)
            {
                double alfa = Sqrt3(-1 * q / 2 + Math.Sqrt(Q)) + zam;
                solution.Add(new Complex(2 * alfa, 0.0));
                solution.Add(new Complex(-1 * alfa, 0.0));
                solution.Add(new Complex(-1 * alfa, 0.0));
            }

            return solution;
        }
        //TODO try another method
        private List<Complex> FourthPower(Equation eq)
        {
            List<Complex> solution = new List<Complex>();

            double x1 = -100, x2 = 100, e = 0.001,  c = 0;
            int i = 0;
            //for (int j = 0; j < 4; j++)
            {
                while (Math.Abs(c - x2) > e || i < 100)
                {
                    c = (x1+x2)/2;
                    if (eq.FunctionValue(x1) * eq.FunctionValue(c) < 0)
                        x2 = c;
                    else if (eq.FunctionValue(c) * eq.FunctionValue(x2) < 0)
                        x1 = c;
                    else
                    {
                        solution.Add((x1 + x2) / 2);
                        break;
                    }
                    i++;
                }
            }

           // solution=solution.Distinct() as List<Complex>;
            
            
            return solution;
        }

        public static double Sqrt3(double x)
        {
            return Math.Sign(x) * Math.Pow(Math.Abs(x), 1 / 3.0);
        }


        public Complex Check(List<Complex> answer, Equation eq)
        {
            Complex check = 0.0;
            for (int i = 0; i < answer.Count; i++)
            {
                check = 0.0;
                for (int j = 0; j < eq.coef.Length; j++)
                {
                    check += eq.coef[j] *( answer[i] ^ j);
                }
                
            }

            return check;
        }

        public Complex FunctionValue(Complex x)
        {
            Complex a = 0.0;
            for (int j = 0; j < this.coef.Length; j++)
            {
                a += this.coef[j] * (x^j);
            }

            return a;
        }

        /*
        private Complex DivideInHalf(double x1, double x2, double e)
        {

            do
            {
                double c = (x1 + x2) / 2;
                if (this.FunctionValue(x1) * this.FunctionValue(c) < 0)
                {
                    x2 = c;
                }
                else
                {
                    x1 = c;
                }
            }
            while (Math.Abs(x2 - x1) < e);
            return (x1 + x2) / 2;
        }*/
    }
}



