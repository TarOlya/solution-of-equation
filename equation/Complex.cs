using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation
{
    public class Complex
    {
        private double _real;
        private double _im;

        public Complex(double real, double im) {
            _real = real;
            _im = im;
        }
        

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a._real + b._real, a._im + b._im);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a._real - b._real, a._im - b._im);
        }

        public static Complex operator *(Complex a, Complex b) {
            return new Complex(a._real*b._real-a._im*b._im, a._real*b._im+b._real*a._im);
        }


        public static Complex operator /(Complex a, Complex b) {
            return new Complex(a._real*b._real+a._im*b._im/(b._real*b._real+b._im*b._im), a._im*b._real-a._real*b._im/(b._real * b._real + b._im * b._im));
        }

        public static Complex operator ^(Complex a, double b) {
            double z = Abs(a);
            double degree = arg(a);
            Complex answer = new Complex(Math.Cos(b * degree), Math.Sin(b * degree));
            answer *= Math.Pow(z, b);
            return answer;
        }

        public static implicit operator Complex(double x) {
            return new Complex(x, 0.0);
        }

        public override string ToString()
        {
            return this._im!=0.0?String.Format("{0:0.###}{1}{2:0.###}*i",this._real,this._im<0?"-":"+",Math.Abs(this._real)):String.Format("{0:0.###}",this._real);
        }
        

        public static double Abs(Complex a) {
            return Math.Sqrt(a._real * a._real + a._im * a._im);
        }

        public static double arg(Complex a) {
            return Math.Atan(a._im / a._real);
        }

        public static bool operator <(Complex a, Complex b){
            return a._real < b._real && a._im < b._im ? true : false;
        }

        public static bool operator <=(Complex a, Complex b){
            return a._real <= b._real && a._im <= b._im ? true : false;
        }
        public static bool operator >(Complex a, Complex b){
            return a._real > b._real && a._im > b._im ? true : false;
        }
        public static bool operator >=(Complex a, Complex b){
            return a._real >= b._real && a._im >= b._im ? true : false;
        }
        public static bool operator ==(Complex a, Complex b){
            return a._real == b._real && a._im == b._im ? true : false;
        }
        public static bool operator !=(Complex a, Complex b){
            return a._real != b._real && a._im != b._im ? true : false;
        }

    }
}
