namespace FrmParcial
{
    partial class FrmLogin
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnAutocompletarVendedor = new System.Windows.Forms.Button();
            this.btnAutocompletarDueño = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(82, 151);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(82, 208);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(39, 15);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(116, 269);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnAutocompletarVendedor
            // 
            this.btnAutocompletarVendedor.Location = new System.Drawing.Point(73, 357);
            this.btnAutocompletarVendedor.Name = "btnAutocompletarVendedor";
            this.btnAutocompletarVendedor.Size = new System.Drawing.Size(157, 33);
            this.btnAutocompletarVendedor.TabIndex = 3;
            this.btnAutocompletarVendedor.Text = "Autocompletar Vendedor";
            this.btnAutocompletarVendedor.UseVisualStyleBackColor = true;
            // 
            // btnAutocompletarDueño
            // 
            this.btnAutocompletarDueño.Location = new System.Drawing.Point(73, 318);
            this.btnAutocompletarDueño.Name = "btnAutocompletarDueño";
            this.btnAutocompletarDueño.Size = new System.Drawing.Size(157, 33);
            this.btnAutocompletarDueño.TabIndex = 4;
            this.btnAutocompletarDueño.Text = "Autocompletar Dueño";
            this.btnAutocompletarDueño.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(82, 226);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(148, 23);
            this.txtClave.TabIndex = 6;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAutocompletarDueño);
            this.Controls.Add(this.btnAutocompletarVendedor);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblEmail);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmail;
        private Label lblClave;
        private Button btnIngresar;
        private Button btnAutocompletarVendedor;
        private Button btnAutocompletarDueño;
        private TextBox txtEmail;
        private TextBox txtClave;
    }
}