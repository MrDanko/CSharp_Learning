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
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return true;
        }
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return true;
        }
        public static int operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return 1;
        }
        public static int operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return 1;
        }
        public static bool operator <(ComplexNumber c1, ComplexNumber c2)
        {
            return true;
        }
        public static bool operator >(ComplexNumber c1, ComplexNumber c2)
        {
            return true;
        }
        public static explicit operator ComplexNumber( string str)
        {
            return new ComplexNumber();
        }
        public static implicit operator String (ComplexNumber c1)
        {
            return  c1.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }
        class ComplexSet : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
