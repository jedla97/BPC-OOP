using System;
namespace cv02
{
    class Complex
    {
        private double real;
        private double imaginary;

        public Complex(double real = 0, double imaginary = 0)
        {
            this.real = real;
            this.imaginary = imaginary;

        }

        // add two comlex number 
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);
        }

        // substract two comlex number 
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.imaginary - b.imaginary);
        }

        // multiply two comlex number 
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.real*b.real-a.imaginary*b.imaginary, a.real*b.imaginary+a.imaginary*b.real);
        }

        // divide two comlex number 
        public static Complex operator /(Complex a, Complex b)
        { // a + b    c + d
            return new Complex((a.real*b.real + b.imaginary*a.imaginary)/(b.real*b.real + b.imaginary * b.imaginary), 
                (b.real*a.imaginary-a.real*b.imaginary)/(b.imaginary*b.imaginary + b.real * b.real)
                );
        }

        // unary- /real and imaginary component multiplied by -1.
        public static Complex operator -(Complex a)
        {
            return new Complex(-a.real, -a.imaginary);
        }

        // real and imaginary componet is equal if are equal return true and otherwise
        public static bool operator ==(Complex a, Complex b)
        {
            if ((a.real == b.real) && (a.imaginary == b.imaginary))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // real and imaginary componet is not equal. if not equal return true and otherwise
        public static bool operator !=(Complex a, Complex b)
        {
            if ((a.real == b.real) && (a.imaginary == b.imaginary))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // do complex conjugate
        public Complex Conjugate()
        {
            return new Complex(real, -imaginary);
        }

        // do complex conjugate
        public double Abs()
        {
            return Math.Sqrt(real*real+imaginary*imaginary);
        }

        public override string ToString()
        {
            if (imaginary >= 0)
            {
                return string.Format("{0}+{1}j", real, imaginary);
            }
            else
            {
                return string.Format("{0}-{1}j", real, -imaginary);
            }

        }

        

        public double Real { get; set; }
        public double Imaginary { get; set; }
    }
}
