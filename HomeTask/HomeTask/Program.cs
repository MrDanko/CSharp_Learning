using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class ComplexNumber
    {
        int real, imaginary;
        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            if (c1.real == c2.real && c1.imaginary == c2.imaginary)
                return true;
            return false;
        }
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            if (c1.real == c2.real && c1.imaginary == c2.imaginary)
                return false;
            return true;
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real+c1.real, c1.imaginary+c2.imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real - c1.real, c1.imaginary - c2.imaginary); 
        }
        public static bool operator <(ComplexNumber c1, ComplexNumber c2)
        {
            if (c1.real > c2.real && c1.imaginary > c2.imaginary)
                return false;
            return true;
        }
        public static bool operator >(ComplexNumber c1, ComplexNumber c2)
        {
            if (c1.real > c2.real && c1.imaginary > c2.imaginary)
                return true;
            return false;
        }
        public static explicit operator ComplexNumber( string str)
        {
            int a, b;
            string strA, strB;
            strA = str.Substring(0,str.IndexOf('+'));
            strB = str.Substring(str.IndexOf('+')+1, str.Length- str.IndexOf('+')-2);
            return int.TryParse(strA, out a) && int.TryParse(strB, out b) ? new ComplexNumber(a,b) :  new ComplexNumber(0, 0);
        }
        public static implicit operator String (ComplexNumber c1)
        {
            if (c1.imaginary < 0)
                return String.Format($"{c1.real}{c1.imaginary}i");
            else if (c1.real == 0)
                return c1.imaginary.ToString() + "i";
            else if (c1.imaginary == 0)
                return c1.real.ToString();
            return  c1.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber&& obj!=null)
            {
                ComplexNumber c1 = obj as ComplexNumber;
                if (real == c1.real && imaginary == c1.imaginary)
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            if (imaginary < 0)
                return String.Format($"{real}{imaginary}i");
            else if (real==0&&imaginary==0) return "0";
            return String.Format($"{real}+{imaginary}i");
        }
        public override int GetHashCode()
        {
            return real.GetHashCode() + imaginary.GetHashCode();
        }
        class ComplexSet : IEnumerable
        {
            ArrayList cSet = new ArrayList();

            public ComplexNumber this[int index]
            {
                get { return (ComplexNumber)cSet[index]; }
                set { cSet.Insert(index, value); }
            }
            public ComplexNumber this[string str]
            {
                get
                {
                    foreach (ComplexNumber c in cSet)
                    {
                        if (c.ToString() == str)
                            return c;
                       
                    }
                    return new ComplexNumber(0,0);
                }
            }
            public IEnumerator GetEnumerator()
            {
                return cSet.GetEnumerator();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "23+5i";
            ComplexNumber complexNumber = (ComplexNumber)text;
            ComplexNumber c2=new ComplexNumber(23,-5);
            Console.WriteLine(c2);
            Console.ReadKey();
        }
    }
}
