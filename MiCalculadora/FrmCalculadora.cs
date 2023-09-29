using Entidades;

namespace MiCalculadora
{
    /// <summary>
    /// Clase que representa la ventana principal de la calculadora.
    /// </summary>
    public partial class FrmCalculadora : Form
    {
        private Operation calculator;
        private Numeration firstOperand;
        private Numeration secondOperand;
        private Numeration result;
        private IsSystem isSystem;
        bool flag = false;

        /// <summary>
        /// Constructor de la clase FrmCalculadora.
        /// </summary>
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se carga la ventana de la calculadora.
        /// </summary>
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.rbDecimal.Checked = true;
            this.cboOperations.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento que se ejecuta cuando se presiona el botón "Limpiar".
        /// </summary>
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtFirstOperand.Text = string.Empty;
            txtSecondOperand.Text = string.Empty;
            lblResultShowed.Text = string.Empty;
        }

        /// <summary>
        /// Evento que se ejecuta cuando se presiona el botón "Cerrar".
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flag = true;
                this.Close();
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se intenta cerrar la ventana de la calculadora.
        /// </summary>
        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag && MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se cambia la selección del radio button "Decimal".
        /// </summary>
        private void rbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDecimal.Checked)
            {
                isSystem = IsSystem.Decimal;
                SetResult();
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se cambia la selección del radio button "Binario".
        /// </summary>
        private void rbBinary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBinary.Checked)
            {
                isSystem = IsSystem.Binary;
                SetResult();
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se cambia el texto del primer operando.
        /// </summary>
        private void txtFirstOperand_TextChanged(object sender, EventArgs e)
        {
            firstOperand = new Numeration(txtFirstOperand.Text, isSystem);
        }

        /// <summary>
        /// Evento que se ejecuta cuando se cambia el texto del segundo operando.
        /// </summary>
        private void txtSecondOperand_TextChanged(object sender, EventArgs e)
        {
            secondOperand = new Numeration(txtSecondOperand.Text, isSystem);
        }

        /// <summary>
        /// Evento que se ejecuta cuando se presiona el botón "Operar".
        /// </summary>
        private void btnOperate_Click(object sender, EventArgs e)
        {
            if (Validator.ValidatesConvertion(txtFirstOperand.Text) && Validator.ValidatesConvertion(txtSecondOperand.Text))
            {
                char operand = char.Parse(cboOperations.SelectedItem.ToString()!);
                if (!Validator.ValidatesDivideerZero(operand, txtSecondOperand.Text))
                {
                    calculator = new Operation(firstOperand, secondOperand);
                    result = calculator.Operate(operand);
                    SetResult();
                }
                else
                {
                    lblResultShowed.Text = "No se puede dividir por 0";
                }
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operación. \nDebe completar los operandos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método que actualiza el resultado de la operación en la ventana de la calculadora.
        /// </summary>
        private void SetResult()
        {
            if (result is not null)
            {
                if (Validator.ValidatesNegativeBinary(result.ConvertTo(isSystem), isSystem))
                {
                    lblResultShowed.Text = "No hay binarios negativos.";
                }
                else
                {
                    lblResultShowed.Text = result.ConvertTo(isSystem);
                }
            }
        }
    }
}