using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadMethods
{
    public sealed class Complex
    {
        public int Real { get; set; }

        public int Imaginary { get; set; }

        public Complex(int real,int imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static bool operator ==(Complex c1,Complex c2)
        {
            return c1.Real == c2.Real & c1.Imaginary == c2.Imaginary;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return c1.Real != c2.Real || c1.Imaginary != c2.Imaginary;
        }


        public static implicit operator double(Complex c1)
        {
            return Math.Sqrt(c1.Real * c1.Real + c1.Imaginary * c1.Imaginary);
        }

        public static explicit operator Complex(string str)
        {
            return new Complex(1, 1);
        }
    }
}
