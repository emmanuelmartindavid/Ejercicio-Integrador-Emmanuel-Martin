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
        /*  public static bool ValidatesConvertion(string firstOperand, string secondOperand, IsSystem isSystem)
          {
              return (isSystem == IsSystem.Binary && !firstOperand.All(c => c == '0' || c == '1') || isSystem == IsSystem.Binary && !secondOperand.All(c => c == '0' || c == '1'));
          }*/

        public static bool ValidatesConvertion(string operand)
        {
            if (!string.IsNullOrWhiteSpace(operand))
            {
                foreach (var item in operand)
                {
                    if (item > 48 && item < 57)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ValidatesBinaryConvertion(string result, IsSystem isSystem)
        {
           double number = double.Parse(result);
           return (isSystem == IsSystem.Binary && number < 0); 
        }
    }
}
