
    struct Complex
    {
        private double re; //дейвительное число

        private double im; //мнимое число

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

        public static Complex Plus(Complex a, Complex b)
        {
            Complex result;

            result.re = a.re + b.re;
            result.im = a.im + b.im;

            return result;
        }

        public static Complex Minus(Complex a, Complex b)
        {       
            Complex result;

            result.re = a.re - b.re;
            result.im = a.im - b.im;

            return result;
        }

    public Complex(double re, double im) //конструктор
        {
            this.re = re; //this.re это переменная в структуре
            this.im = im;
        }

    }

     
        

  
        
    










