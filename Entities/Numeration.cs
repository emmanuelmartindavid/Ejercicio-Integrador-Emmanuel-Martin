using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// <summary>
    /// Clase que representa un número en un sistema numérico determinado.
    /// </summary>
    public class Numeration
    {
        private IsSystem _isSystem;
        private double _numericValue;

        /// <summary>
        /// Propiedad que devuelve el sistema numérico del número.
        /// </summary>
        public IsSystem IsSystem
        {
            get
            {
                return this._isSystem;
            }
        }
        /// <summary>
        /// Propiedad que devuelve el valor del número en formato de cadena.
        /// </summary>
        public string Value
        {
            get
            {
                // return ConvertTo(this._isSystem);
                return this._numericValue.ToString();
            }
        }

        /// <summary>
        /// Constructor de la clase Numeration.
        /// </summary>
        /// <param name="numericValue">El valor del número.</param>
        /// <param name="isSystem">El sistema numérico del número.</param>
        public Numeration(double numericValue, IsSystem isSystem) : this(numericValue.ToString(), isSystem)
        {
            this._isSystem = isSystem;
        }

        /// <summary>
        /// Constructor de la clase Numeration.
        /// </summary>
        /// <param name="numericValue">El valor del número en formato de cadena.</param>
        /// <param name="isSystem">El sistema numérico del número.</param>
        public Numeration(string numericValue, IsSystem isSystem)
        {
            InitializeValues(numericValue, isSystem);
        }

        /// <summary>
        /// Convierte un número decimal a su representación en binario.
        /// </summary>
        /// <param name="number">El número decimal a convertir.</param>
        /// <returns>La representación en binario del número decimal.</returns>
      /*  public static string ConvertDecimalToBinary(int number)
        {
            string binary = "";
            if (number == 0)
            {
                binary = "0";
            }
            while (number > 0)
            {
                int rest = number % 2;
                binary = rest + binary;
                number /= 2;
            }
            return binary;
        }*/
        public static string ConvertDecimalToBinary(int number)
        {
            string binary = "";
            if (number == 0)
            {
                binary = "0";
            }
            if (number < 0)
            {
                binary = "Negative";
            }
            while (number > 0)
            {
                int rest = number % 2;
                binary = rest + binary;
                number /= 2;
            }
            return binary;
        }
        /// <summary>
        /// Convierte un número decimal en formato de cadena a su representación en binario.
        /// </summary>
        /// <param name="stringNumber">El número decimal en formato de cadena a convertir.</param>
        /// <returns>La representación en binario del número decimal.</returns>
        public static string ConvertDecimalToBinary(string stringNumber)
        {
            string binary = "";
            if (int.TryParse(stringNumber, out int number))
            {
                if (number == 0)
                {
                    binary = "0";
                }
                while (number > 0)
                {
                    int rest = number % 2;
                    binary = rest + binary;
                    number /= 2;
                }
            }
            return binary;
        }
        /// <summary>
        /// Convierte un número binario en formato de cadena a su representación decimal.
        /// </summary>
        /// <param name="number">El número binario en formato de cadena a convertir.</param>
        /// <returns>La representación decimal del número binario.</returns>
        public static double ConvertBinaryToDecimal(string number)
        {
            double decimalNumber = 0;
            double convertedNumber;
            double baseNumber = 1;

            if (!string.IsNullOrEmpty(number) && IsBinary(number))
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
        /// <summary>
        /// Convierte el número a su representación en el sistema numérico especificado.
        /// </summary>
        /// <param name="isSystem">El sistema numérico al que se desea convertir el número.</param>
        /// <returns>La representación del número en el sistema numérico especificado.</returns>
        public string ConvertTo(IsSystem isSystem)
        {
            string result;
            if (isSystem == IsSystem.Binary)
            {
                result = ConvertDecimalToBinary((int)this._numericValue);
            }
            else
            {
                result = this._numericValue.ToString();
            }
            return result;
        }
        /// <summary>
        /// Verifica que la cadena pasada por parámetro sea un número binario.
        /// </summary>
        /// <param name="number"></param> La cadena a verificar.
        /// <returns>True si la cadena representa un numero Binario, false en caso contrario.</returns>
        private static bool IsBinary(string number)
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
        /// <summary>
        /// Inicializa los valores de la instancia de la clase Numeration.
        /// </summary>
        /// <param name="stringValue">El valor del número en formato de cadena.</param>
        /// <param name="isSystem">El sistema numérico del número.</param>
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
        }
        /// <summary>
        /// Sobrecarga del operador de suma para la clase Numeration.
        /// </summary>
        /// <param name="numeration1">El primer número a sumar.</param>
        /// <param name="numeration2">El segundo número a sumar.</param>
        /// <returns>La suma de los dos números.</returns>
        public static Numeration operator +(Numeration numeration1, Numeration numeration2)
        {
            return new Numeration(numeration1._numericValue + numeration2._numericValue, IsSystem.Decimal);
        }
        /// <summary>
        /// Sobrecarga del operador de resta para la clase Numeration.
        /// </summary>
        /// <param name="numeration1">El número al que se le resta.</param>
        /// <param name="numeration2">El número que se resta.</param>
        /// <returns>La resta de los dos números.</returns>
        public static Numeration operator -(Numeration numeration1, Numeration numeration2)
        {
            return new Numeration(numeration1._numericValue - numeration2._numericValue, IsSystem.Decimal);
        }
        /// <summary>
        /// Sobrecarga del operador de multiplicación para la clase Numeration.
        /// </summary>
        /// <param name="numeration1">El primer número a multiplicar.</param>
        /// <param name="numeration2">El segundo número a multiplicar.</param>
        /// <returns>El producto de los dos números.</returns>
        public static Numeration operator *(Numeration numeration1, Numeration numeration2)
        {
            return new Numeration(numeration1._numericValue * numeration2._numericValue, IsSystem.Decimal);
        }
        /// <summary>
        /// Sobrecarga del operador de división para la clase Numeration.
        /// </summary>
        /// <param name="numeration1">El número que se divide.</param>
        /// <param name="numeration2">El número por el que se divide.</param>
        /// <returns>El cociente de los dos números.</returns>
        public static Numeration operator /(Numeration numeration1, Numeration numeration2)
        {
            return new Numeration(numeration1._numericValue / numeration2._numericValue, IsSystem.Decimal);
        }
        /// <summary>
        /// Sobrecarga del operador de igualdad para la clase Numeration.
        /// </summary>
        /// <param name="numeration1">El primer número a comparar.</param>
        /// <param name="numeration2">El segundo número a comparar.</param>
        /// <returns>true si los dos números tienen el mismo sistema numérico, false en caso contrario.</returns>
        public static bool operator ==(Numeration numeration1, Numeration numeration2)
        {
            return numeration1.IsSystem == numeration2.IsSystem;
        }
        /// <summary>
        /// Sobrecarga del operador de desigualdad para la clase Numeration.
        /// </summary>
        /// <param name="numeration1">El primer número a comparar.</param>
        /// <param name="numeration2">El segundo número a comparar.</param>
        /// <returns>true si los dos números tienen sistemas numéricos diferentes, false en caso contrario.</returns>
        public static bool operator !=(Numeration numeration1, Numeration numeration2)
        {
            return !(numeration1 == numeration2);
        }
        /// <summary>
        /// Sobrecarga del operador de igualdad para la clase Numeration.
        /// </summary>
        /// <param name="isSystem">El sistema numérico a comparar.</param>
        /// <param name="numeration">El número a comparar.</param>
        /// <returns>true si el número tiene el sistema numérico especificado, false en caso contrario.</returns>
        public static bool operator ==(IsSystem isSystem, Numeration numeration)
        {
            return isSystem == numeration._isSystem;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para la clase Numeration.
        /// </summary>
        /// <param name="isSystem">El sistema numérico a comparar.</param>
        /// <param name="numeration">El número a comparar.</param>
        /// <returns>true si el número no tiene el sistema numérico especificado, false en caso contrario.</returns>
        public static bool operator !=(IsSystem isSystem, Numeration numeration)
        {
            return !(isSystem == numeration);
        }
    }
}
