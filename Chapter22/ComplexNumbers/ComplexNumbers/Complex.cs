using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Complex
    {
        public int Real { get; set; }
        public int Imeginary { get; set; }

        public Complex(int real, int imeginary)
        {
            Real = real;
            Imeginary = imeginary;
        }

        public Complex(int real)
        {
            this.Real = real;
            this.Imeginary = 0;
        }
        public static implicit operator Complex(int from)
        {
            return new Complex(from);
        }

        public static explicit operator int(Complex from)
        {
            return from.Real;
        }
        public override string ToString()
        {
            return $"({this.Real} + {this.Imeginary}i)";
        }

        public static Complex operator +(Complex lhs, Complex rhs) => new Complex(lhs.Real + rhs.Real, lhs.Imeginary + rhs.Imeginary);

        public static Complex operator -(Complex lhs, Complex rhs) => new Complex(lhs.Real - rhs.Real, lhs.Imeginary - rhs.Imeginary);

        public static Complex operator *(Complex lhs, Complex rhs) => new Complex((lhs.Real * rhs.Real - lhs.Imeginary * rhs.Imeginary), (lhs.Imeginary * rhs.Real + lhs.Real * rhs.Imeginary));
        public static Complex operator /(Complex lhs, Complex rhs)
        {
            int denominator = rhs.Real * rhs.Real + rhs.Imeginary * rhs.Imeginary;
            int leftNumerator = lhs.Real * rhs.Real + lhs.Imeginary * rhs.Imeginary;
            int rightNumerator = lhs.Imeginary * rhs.Real - lhs.Real * rhs.Imeginary;

            return new Complex(leftNumerator / denominator, rightNumerator / denominator);
        }

        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return !(lhs.Equals(rhs));
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                Complex compare = (Complex)obj;
                return (this.Real == compare.Real && this.Imeginary == compare.Imeginary);
            }
            else
            {
                return false;
            }

            //if (obj as Complex != null)
            //{
            //    Complex compare = (Complex)obj;
            //    return (this.Real == compare.Real && this.Imeginary == compare.Imeginary);
            //}
            //else
            //{
            //    return false;
            //}
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
