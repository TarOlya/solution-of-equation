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

        public static implicit operator Complex(double x) {
            return new Complex(x, 0.0);
        }
    }
}
