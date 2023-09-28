using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Operation calculator;
        private Numeration firstOperand;
        private Numeration secondOperand;
        private Numeration result;
        private IsSystem isSystem;
        bool flag = false;
        public FrmCalculadora()
        {
            InitializeComponent();

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.rbDecimal.Checked = true;
            this.cboOperations.SelectedIndex = 0;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtFirstOperand.Text = string.Empty;
            txtSecondOperand.Text = string.Empty;
            lblResultShowed.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flag = true;
                this.Close();
            }
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag && MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDecimal.Checked)
            {
                isSystem = IsSystem.Decimal;
                SetResult();
            }
        }

        private void rbBinary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBinary.Checked)
            {
                isSystem = IsSystem.Binary;
                SetResult();
            }
        }

        private void txtFirstOperand_TextChanged(object sender, EventArgs e)
        {
            firstOperand = new Numeration(txtFirstOperand.Text, isSystem);
        }

        private void txtSecondOperand_TextChanged(object sender, EventArgs e)
        {
            secondOperand = new Numeration(txtSecondOperand.Text, isSystem);
        }

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
                    MessageBox.Show("No se pudo realizar la operación. \nNo se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operación. \nDebe completar los operandos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetResult()
        {
            if (result is not null)
            {
                 lblResultShowed.Text = result.ConvertTo(isSystem);
               /* if (Validator.ValidatesBinaryConvertion(result.ConvertTo(isSystem), isSystem))
                {
                    lblResultShowed.Text = result.ConvertTo(isSystem);

                }
                else
                {
                    lblResultShowed.Text = "Valor inválido. No hay numeros binarios negativos.";
                }*/

            }

        }
    }
}