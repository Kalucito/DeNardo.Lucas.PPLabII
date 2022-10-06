namespace FrmParcial
{
    partial class FrmSumarStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCantidadAAgregar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCantidadAAgregar
            // 
            this.txtCantidadAAgregar.Location = new System.Drawing.Point(102, 46);
            this.txtCantidadAAgregar.Name = "txtCantidadAAgregar";
            this.txtCantidadAAgregar.Size = new System.Drawing.Size(118, 23);
            this.txtCantidadAAgregar.TabIndex = 0;
            this.txtCantidadAAgregar.TextChanged += new System.EventHandler(this.txtCantidadAAgregar_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(124, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // FrmSumarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 181);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidadAAgregar);
            this.Name = "FrmSumarStock";
            this.Text = "FrmSumarStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCantidadAAgregar;
        private Button btnAgregar;
    }
}