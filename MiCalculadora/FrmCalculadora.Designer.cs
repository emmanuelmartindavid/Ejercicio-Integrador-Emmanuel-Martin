namespace MiCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            btnOperate = new Button();
            btnClean = new Button();
            btnClose = new Button();
            txtFirstOperand = new TextBox();
            txtSecondOperand = new TextBox();
            cboOperations = new ComboBox();
            lblFirstOperand = new Label();
            lblSecondOperand = new Label();
            lblOperation = new Label();
            grpTypeResult = new GroupBox();
            rbBinary = new RadioButton();
            rbDecimal = new RadioButton();
            lblResult = new Label();
            lblResultShowed = new Label();
            grpTypeResult.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperate
            // 
            btnOperate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOperate.Location = new Point(12, 317);
            btnOperate.Name = "btnOperate";
            btnOperate.Size = new Size(149, 32);
            btnOperate.TabIndex = 0;
            btnOperate.Text = "Operar";
            btnOperate.UseVisualStyleBackColor = true;
            btnOperate.Click += btnOperate_Click;
            // 
            // btnClean
            // 
            btnClean.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.Location = new Point(214, 317);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(149, 32);
            btnClean.TabIndex = 1;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(423, 317);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 32);
            btnClose.TabIndex = 2;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtFirstOperand
            // 
            txtFirstOperand.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstOperand.Location = new Point(12, 243);
            txtFirstOperand.Multiline = true;
            txtFirstOperand.Name = "txtFirstOperand";
            txtFirstOperand.Size = new Size(149, 41);
            txtFirstOperand.TabIndex = 3;
            txtFirstOperand.TextChanged += txtFirstOperand_TextChanged;
            // 
            // txtSecondOperand
            // 
            txtSecondOperand.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSecondOperand.Location = new Point(423, 243);
            txtSecondOperand.Multiline = true;
            txtSecondOperand.Name = "txtSecondOperand";
            txtSecondOperand.Size = new Size(149, 41);
            txtSecondOperand.TabIndex = 4;
            txtSecondOperand.TextChanged += txtSecondOperand_TextChanged;
            // 
            // cboOperations
            // 
            cboOperations.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOperations.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboOperations.FormattingEnabled = true;
            cboOperations.Items.AddRange(new object[] { "+", "-", "/", "*" });
            cboOperations.Location = new Point(232, 257);
            cboOperations.Name = "cboOperations";
            cboOperations.Size = new Size(122, 27);
            cboOperations.TabIndex = 5;
            // 
            // lblFirstOperand
            // 
            lblFirstOperand.AutoSize = true;
            lblFirstOperand.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstOperand.Location = new Point(12, 218);
            lblFirstOperand.Name = "lblFirstOperand";
            lblFirstOperand.Size = new Size(153, 21);
            lblFirstOperand.TabIndex = 6;
            lblFirstOperand.Text = "Primer Operador: ";
            // 
            // lblSecondOperand
            // 
            lblSecondOperand.AutoSize = true;
            lblSecondOperand.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblSecondOperand.Location = new Point(412, 219);
            lblSecondOperand.Name = "lblSecondOperand";
            lblSecondOperand.Size = new Size(173, 21);
            lblSecondOperand.TabIndex = 7;
            lblSecondOperand.Text = "Segundo Operador: ";
            // 
            // lblOperation
            // 
            lblOperation.AutoSize = true;
            lblOperation.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperation.Location = new Point(241, 233);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(103, 21);
            lblOperation.TabIndex = 8;
            lblOperation.Text = "Operacion: ";
            // 
            // grpTypeResult
            // 
            grpTypeResult.Controls.Add(rbBinary);
            grpTypeResult.Controls.Add(rbDecimal);
            grpTypeResult.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpTypeResult.Location = new Point(175, 158);
            grpTypeResult.Name = "grpTypeResult";
            grpTypeResult.Size = new Size(231, 72);
            grpTypeResult.TabIndex = 9;
            grpTypeResult.TabStop = false;
            grpTypeResult.Text = "Mostrar resultado en: ";
            // 
            // rbBinary
            // 
            rbBinary.AutoSize = true;
            rbBinary.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rbBinary.Location = new Point(145, 35);
            rbBinary.Name = "rbBinary";
            rbBinary.Size = new Size(71, 21);
            rbBinary.TabIndex = 1;
            rbBinary.TabStop = true;
            rbBinary.Text = "Binario";
            rbBinary.UseVisualStyleBackColor = true;
            rbBinary.CheckedChanged += rbBinary_CheckedChanged;
            // 
            // rbDecimal
            // 
            rbDecimal.AutoSize = true;
            rbDecimal.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rbDecimal.Location = new Point(6, 35);
            rbDecimal.Name = "rbDecimal";
            rbDecimal.Size = new Size(80, 21);
            rbDecimal.TabIndex = 0;
            rbDecimal.TabStop = true;
            rbDecimal.Text = "Decimal";
            rbDecimal.UseVisualStyleBackColor = true;
            rbDecimal.CheckedChanged += rbDecimal_CheckedChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(20, 60);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(145, 32);
            lblResult.TabIndex = 10;
            lblResult.Text = "Resultado:";
            // 
            // lblResultShowed
            // 
            lblResultShowed.AutoSize = true;
            lblResultShowed.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultShowed.Location = new Point(181, 63);
            lblResultShowed.Name = "lblResultShowed";
            lblResultShowed.Size = new Size(0, 29);
            lblResultShowed.TabIndex = 11;
            
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(584, 361);
            Controls.Add(lblResultShowed);
            Controls.Add(lblResult);
            Controls.Add(grpTypeResult);
            Controls.Add(lblOperation);
            Controls.Add(lblSecondOperand);
            Controls.Add(lblFirstOperand);
            Controls.Add(cboOperations);
            Controls.Add(txtSecondOperand);
            Controls.Add(txtFirstOperand);
            Controls.Add(btnClose);
            Controls.Add(btnClean);
            Controls.Add(btnOperate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Emmanuel Martin";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpTypeResult.ResumeLayout(false);
            grpTypeResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperate;
        private Button btnClean;
        private Button btnClose;
        private TextBox txtFirstOperand;
        private TextBox txtSecondOperand;
        private ComboBox cboOperations;
        private Label lblFirstOperand;
        private Label lblSecondOperand;
        private Label lblOperation;
        private GroupBox grpTypeResult;
        private RadioButton rbBinary;
        private RadioButton rbDecimal;
        private Label lblResult;
        private Label lblResultShowed;
    }
}