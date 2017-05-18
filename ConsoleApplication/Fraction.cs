using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public struct Fraction : IEquatable<Fraction>
    {


        long _numerator;
        
        public long Numerator
        {
            get { return _numerator; }
            private set { _numerator = value; }
        }



        long _denominator;
        
        public long Denominator
        {
            get { return _denominator == 0 ? 1 : _denominator; }
            private set
            {
                if (value == 0)
                    throw new InvalidOperationException("Denominator cannot be assigned a 0 Value.");

                _denominator = value;
            }
        }



        public Fraction(long value)
        {
            _numerator = value;
            _denominator = 1;
            Reduce();
        }

    }
}
