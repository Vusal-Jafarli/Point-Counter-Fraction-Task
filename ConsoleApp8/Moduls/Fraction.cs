using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Moduls
{
    public class Fraction
    {
        private int numerator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }


        private int denominator;

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public Fraction()
        {
            numerator = 0;
            denominator = 0;
        }
        public Fraction(int numerator,int  denominator)
        {

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int EKOB(int num1, int num2)
        {
            int ekob;//En kicik ortaq bolunen
            int oz_num1 = num1;
            int oz_num2 = num2;



            while (true)
            {
                if (num2 > num1)
                {
                    num2 += oz_num2;
                    if (num2 % num1 == 0)
                    {
                        ekob = num2;
                        break;
                    }
                }



                else if (num1 > num2)
                {
                    num1 += oz_num1;
                    if (num1 % num2 == 0)
                    {
                        ekob = num1;
                        break;
                    }
                }
            }

            return ekob;
        }
        public Fraction multiply(Fraction f2)
        {
            Fraction result = new Fraction(0, 0);
            result.numerator = numerator * f2.numerator;
            result.denominator = denominator * f2.denominator;

            result = Simplify(result);
            return result;
        }
        public Fraction add(Fraction f2)
        {
            Fraction result = new Fraction(0, 0);

            // Kesrler beraber mexreclidirse
            if (denominator == f2.denominator)
            {
                result.numerator = numerator + f2.numerator;
                result.denominator = denominator;
            }



            //Kesrlerin mexrecleri ixtisar olunursa
            else if (denominator % f2.denominator == 0 || f2.denominator % denominator == 0)
            {
                if (denominator > f2.denominator)
                {
                    result.denominator = denominator;
                    result.numerator = (denominator / f2.denominator) * f2.numerator + numerator;
                }



                else if (denominator < f2.denominator)
                {
                    result.denominator = f2.denominator;
                    result.numerator = (f2.denominator / denominator) * numerator + f2.numerator;
                }
            }



            //Kesrlerin mexrecleri ixtisar olmursa
            else
            {
                int mexrec = EKOB(denominator, f2.denominator);
                result.denominator = mexrec;
                result.numerator = (mexrec / denominator) * numerator + (mexrec / f2.denominator) * f2.numerator;
            }
            result = Simplify(result);
            return result;
        }
        public Fraction minus(Fraction f2)
        {
            Fraction result = new Fraction(0, 0);


            // Kesrler beraber mexreclidirse
            if (denominator == f2.denominator)
            {
                result.numerator = numerator - f2.numerator;
                result.denominator = denominator;
            }


            //Kesrlerin mexrecleri ixtisar olunursa
            else if (denominator % f2.denominator == 0 || f2.denominator % denominator == 0)
            {
                if (denominator > f2.denominator)
                {
                    result.denominator = denominator;
                    result.numerator = numerator - (denominator / f2.denominator) * f2.numerator;
                }



                else if (denominator < f2.denominator)
                {
                    result.denominator = f2.denominator;
                    result.numerator = (f2.denominator / denominator) * numerator - f2.numerator;
                }
            }



            //Kesrlerin mexrecleri ixtisar olmursa
            else
            {
                int mexrec = EKOB(denominator, f2.denominator);
                result.denominator = mexrec;
                result.numerator = (mexrec / denominator) * numerator - (mexrec / f2.denominator) * f2.numerator;
            }
            result = Simplify(result);
            return result;
        }
        public Fraction divide(Fraction f2)
        {
            Fraction result = new Fraction(0, 0);

            result.numerator = numerator * f2.denominator;
            result.denominator = denominator * f2.numerator;

            result = Simplify(result);
            return result;
        }
        public Fraction Simplify(Fraction result)
        {
            int bolen = 1;

            if (result.denominator > result.numerator)
            {
                while (bolen <= result.numerator)
                {
                    bolen++;
                    if (result.denominator % bolen == 0)
                    {
                        if (result.numerator % bolen == 0)
                        {
                            result.denominator /= bolen;
                            result.numerator /= bolen;
                            bolen = 1;
                        }
                    }
                }
            }




            else if (result.denominator < result.numerator)
            {
                while (bolen <= result.denominator)
                {
                    bolen++;
                    if (result.denominator % bolen == 0)
                    {
                        if (result.numerator % bolen == 0)
                        {
                            result.denominator /= bolen;
                            result.numerator /= bolen;
                            bolen = 1;
                        }
                    }
                }



            }
            return result;
        }

    }
}
