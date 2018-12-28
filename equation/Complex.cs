using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation
{
    public class Complex:IEqualityComparer<Complex>
    {
        public double _real;
        public double _im;

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
            if (a._im == 0.000) { return Math.Pow(a._real,b);}
            double z = Abs(a);
            double degree = arg(a);
            Complex answer = new Complex(Math.Cos(b * degree), Math.Sin(b * degree));
            answer *= Math.Pow(z, b);
            return answer;
        }

        public static implicit operator Complex(double x) {
            return new Complex(x, 0.0);
        }

        public override string ToString() {
            return this._im != 0.000 ? $"{this._real:0.###}{(this._im < 0 ? '-' : '+')}{Math.Abs(this._im):0.###}*i" : $"{this._real:0.###}";
        }
        

        public static double Abs(Complex a) {
            return Math.Sqrt(a._real * a._real + a._im * a._im);
        }

        public static double arg(Complex a) {
            return Math.PI-Math.Atan(a._im / Math.Abs(a._real));
        }

        public bool Equals(Complex a, Complex b)
        {
            return a._real == b._real && a._im == b._im ? true : false;
        }

        public int GetHashCode(Complex obj)
        {
            return obj.GetHashCode();
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
        
        public static explicit operator double(Complex a)
        {
            return a._real;
        }

        

    }
}
