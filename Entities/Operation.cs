namespace Entidades
{
    public class Operation
    {
        private Numeration _firstOperand;
        private Numeration _secondOperand;
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
        public Operation(Numeration firstOperand, Numeration secondOperand)
        {
            this._firstOperand = firstOperand;
            this._secondOperand = secondOperand;
        }


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