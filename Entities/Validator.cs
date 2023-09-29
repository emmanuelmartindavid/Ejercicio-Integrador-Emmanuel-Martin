using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que contiene métodos para validar operaciones y conversiones numéricas.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Valida si se está intentando dividir entre cero.
        /// </summary>
        /// <param name="operand">El operador de la operación.</param>
        /// <param name="secondOperand">El segundo operando de la operación.</param>
        /// <returns>true si se está intentando dividir entre cero, false en caso contrario.</returns>
        public static bool ValidatesDivideerZero(char operand, string secondOperand)
        {
            return (operand == '/' && (double.TryParse(secondOperand, out double secondValue) && secondValue == 0));
        }

        /// <summary>
        /// Valida si una cadena se puede convertir a un valor numérico.
        /// </summary>
        /// <param name="value">La cadena a validar.</param>
        /// <returns>true si la cadena se puede convertir a un valor numérico, false en caso contrario.</returns>
        public static bool ValidatesConvertion(string value)
        {
            return !string.IsNullOrWhiteSpace(value) && (double.TryParse(value, out _));
        }

        /// <summary>
        /// Valida si un número binario es negativo.
        /// </summary>
        /// <param name="result">El número binario a validar.</param>
        /// <param name="isSystem">El sistema numérico del número.</param>
        /// <returns>true si el número binario es negativo, false en caso contrario.</returns>
        public static bool ValidatesNegativeBinary(string result, IsSystem isSystem)
        {
            return isSystem == IsSystem.Binary && result == "Negative";
        }
    }
}
