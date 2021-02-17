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
