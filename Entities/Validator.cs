using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validator
    {
        public static bool ValidatesDivideerZero(char operand, string secondOperand)
        {
            return (operand == '/' && (double.TryParse(secondOperand, out double secondValue) && secondValue == 0));
        }
  
        public static bool ValidatesConvertion(string operand)
        {           
            return !string.IsNullOrWhiteSpace(operand) && (double.TryParse(operand, out _));
        }

        public static bool ValidatesNegativeBinary(string result, IsSystem isSystem)
        {
            return (isSystem == IsSystem.Binary && result =="");
        }
    }
}
