namespace Entidades
{
    /// <summary>
    /// Clase que representa una operación matemática entre dos números.
    /// </summary>
    public class Operation
    {
        private Numeration _firstOperand;
        private Numeration _secondOperand;

        /// <summary>
        /// Propiedad primer operando de la operación.
        /// </summary>
        public Numeration FirstOperand
        {
            get
            {
                return this._firstOperand;
            }
            set
            {
                this._firstOperand = value;
            }
        }

        /// <summary>
        /// Propiedad segundo operando de la operación.
        /// </summary>
        public Numeration SecondOperand
        {
            get
            {
                return this._secondOperand;
            }
            set
            {
                this._secondOperand = value;
            }
        }

        /// <summary>
        /// Constructor de la clase Operation.
        /// </summary>
        /// <param name="firstOperand">El primer operando de la operación.</param>
        /// <param name="secondOperand">El segundo operando de la operación.</param>
        public Operation(Numeration firstOperand, Numeration secondOperand)
        {
            this._firstOperand = firstOperand;
            this._secondOperand = secondOperand;
        }

        /// <summary>
        /// Realiza la operación matemática especificada entre los operandos de la instancia de la clase Operation.
        /// </summary>
        /// <param name="operand">El operador de la operación.</param>
        /// <returns>El resultado de la operación.</returns>
        public Numeration Operate(char operand)
        {
            Numeration result;

            if (operand == '-')
            {
                result = _firstOperand - _secondOperand;
            }
            else if (operand == '/')
            {
                result = _firstOperand / _secondOperand;
            }
            else if (operand == '*')
            {
                result = _firstOperand * _secondOperand;
            }
            else
            {
                result = _firstOperand + _secondOperand;
            }
            return result;
        }
    }
}