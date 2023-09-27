using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum IsSystem
    {
        Decimal,
        Binary,
    }
    public class Numeration
    {
        private IsSystem _isSystem;
        private double _numericValue;

        public IsSystem IsSystem
        {
            get
            {
                return this._isSystem;
            }
        }

        public string Value
        {
            get
            {
                return ConvertTo(this._isSystem);
            }
        }
        public Numeration(double numericValue, IsSystem isSystem) : this(numericValue.ToString(), isSystem)
        {
        }
        public Numeration(string numericValue, IsSystem isSystem)
        {
            InitializeValues(numericValue, isSystem);
        }
        public string ConvertDecimalToBinary(double number)
        {
            string binary = "";
            if (number == 0)
            {
                binary = "0";
            }
            while ((int)number > 0)
            {
                int rest = (int)number % 2;
                binary = rest + binary;
                number /= 2;
            }
            return binary;
        }

        public double ConvertBinaryToDecimal(string number)
        {
            double decimalNumber = 0;
            double convertedNumber;
            double baseNumber = 1;

            if (IsBinary(number))
            {
                convertedNumber = double.Parse(number);
                while (convertedNumber > 0)
                {
                    double digit = convertedNumber % 10;
                    decimalNumber += digit * baseNumber;
                    convertedNumber /= 10;
                    baseNumber *= 2;
                }
            }
            return decimalNumber;
        }

        public string ConvertTo(IsSystem isSystem)
        {
            string result = string.Empty;
            switch (isSystem)
            {
                case IsSystem.Binary:
                    result = ConvertDecimalToBinary(this._numericValue);
                    break;
                case IsSystem.Decimal:
                    result = this._numericValue.ToString();
                    break;
            }
            return result;
        }
        private bool IsBinary(string number)
        {
            bool result = true;
            foreach (char item in number)
            {
                if (item != '0' && item != '1')
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private void InitializeValues(string stringValue, IsSystem isSystem)
        {

            if (IsBinary(stringValue) && isSystem == IsSystem.Binary)
            {
                this._numericValue = ConvertBinaryToDecimal(stringValue);
            }
            else if (double.TryParse(stringValue, out double numericValue))
            {
                this._numericValue = numericValue;
            }
            else
            {
                this._numericValue = double.MinValue;
            }

            this._isSystem = isSystem;
        }

        public static explicit operator double(Numeration numeration)
        {
            return numeration._numericValue;
        }

        public static explicit operator string(Numeration numeration)
        {
            return numeration._numericValue.ToString();
        }

        public static implicit operator Numeration(double numericValue)
        {
            return new Numeration(numericValue, IsSystem.Decimal);
        }

        public static implicit operator Numeration(string numericValue)
        {
            return new Numeration(double.Parse(numericValue), IsSystem.Decimal);
        }

        public static Numeration operator +(Numeration numeration1, Numeration numeration2)
        {
            return new Numeration((double)numeration1 + (double)numeration2, IsSystem.Decimal);
        }

        public static Numeration operator -(Numeration numeration1, Numeration numeration2)
        {
            return new Numeration((double)numeration1 - (double)numeration2, IsSystem.Decimal);
        }

        public static Numeration operator *(Numeration numeration1, Numeration numeration2)
        {
            return new Numeration((double)numeration1 * (double)numeration2, IsSystem.Decimal);
        }

        public static Numeration operator /(Numeration numeration1, Numeration numeration2)
        {
            return new Numeration((double)numeration1 / (double)numeration2, IsSystem.Decimal);
        }

        public static bool operator ==(Numeration numeration1, Numeration numeration2)
        {
            return numeration1._numericValue == numeration2._numericValue;
        }

        public static bool operator !=(Numeration numeration1, Numeration numeration2)
        {
            return !(numeration1 == numeration2);
        }
    }
}
