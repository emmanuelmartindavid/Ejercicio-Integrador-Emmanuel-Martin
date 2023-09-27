using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        Operation calculator;
        Numeration firstOperand;
        Numeration secondOperand;
        Numeration result;
        IsSystem isSystem;
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
                this.Close();
            }
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDecimal.Checked)
            {
                isSystem = IsSystem.Decimal;
            }
            else
            {
                isSystem = IsSystem.Binary;
            }
        }

        private void rbBinary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBinary.Checked) 
            {
                isSystem = IsSystem.Binary; 
            }
            else
            {
                isSystem = IsSystem.Decimal; 
            }
        }

        private void txtFirstOperand_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFirstOperand.Text))
            {
                firstOperand = new Numeration(txtFirstOperand.Text, isSystem);
            }
        }

        private void txtSecondOperand_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSecondOperand.Text))
            {
                secondOperand = new Numeration(txtSecondOperand.Text, isSystem);
            }
        }

        private void btnOperate_Click(object sender, EventArgs e)
        {
            char operand = char.Parse(cboOperations.SelectedItem.ToString()!);
            calculator = new Operation(firstOperand, secondOperand);
            result = new ((double)calculator.Operate(operand), isSystem);
            lblResultShowed.Text = result.Value;
        }
    }
}