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
            this.components = new System.ComponentModel.Container();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnAutocompletarVendedor = new System.Windows.Forms.Button();
            this.btnAutocompletarDueño = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblErrorIngreso = new System.Windows.Forms.Label();
            this.picInicioVendedor = new System.Windows.Forms.PictureBox();
            this.tmrContadorTiempo = new System.Windows.Forms.Timer(this.components);
            this.picInicioDueño = new System.Windows.Forms.PictureBox();
            this.chkAnimaciones = new System.Windows.Forms.CheckBox();
            this.btnContador = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInicioVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInicioDueño)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(444, 193);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(106, 35);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnAutocompletarVendedor
            // 
            this.btnAutocompletarVendedor.BackColor = System.Drawing.Color.DarkRed;
            this.btnAutocompletarVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutocompletarVendedor.FlatAppearance.BorderSize = 0;
            this.btnAutocompletarVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAutocompletarVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnAutocompletarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutocompletarVendedor.ForeColor = System.Drawing.Color.White;
            this.btnAutocompletarVendedor.Location = new System.Drawing.Point(518, 252);
            this.btnAutocompletarVendedor.Name = "btnAutocompletarVendedor";
            this.btnAutocompletarVendedor.Size = new System.Drawing.Size(157, 33);
            this.btnAutocompletarVendedor.TabIndex = 3;
            this.btnAutocompletarVendedor.Text = "Autocompletar Vendedor";
            this.btnAutocompletarVendedor.UseVisualStyleBackColor = false;
            this.btnAutocompletarVendedor.Click += new System.EventHandler(this.btnAutocompletarVendedor_Click);
            // 
            // btnAutocompletarDueño
            // 
            this.btnAutocompletarDueño.BackColor = System.Drawing.Color.DarkRed;
            this.btnAutocompletarDueño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutocompletarDueño.FlatAppearance.BorderSize = 0;
            this.btnAutocompletarDueño.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAutocompletarDueño.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnAutocompletarDueño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutocompletarDueño.ForeColor = System.Drawing.Color.White;
            this.btnAutocompletarDueño.Location = new System.Drawing.Point(310, 252);
            this.btnAutocompletarDueño.Name = "btnAutocompletarDueño";
            this.btnAutocompletarDueño.Size = new System.Drawing.Size(157, 33);
            this.btnAutocompletarDueño.TabIndex = 4;
            this.btnAutocompletarDueño.Text = "Autocompletar Dueño";
            this.btnAutocompletarDueño.UseVisualStyleBackColor = false;
            this.btnAutocompletarDueño.Click += new System.EventHandler(this.btnAutocompletarDueño_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(310, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(365, 30);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "EMAIL";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(310, 141);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(365, 30);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 7;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::FrmParcial.Properties.Resources._545427038;
            this.picLogo.Location = new System.Drawing.Point(42, 81);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(160, 160);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(310, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 2);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(310, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 2);
            this.panel3.TabIndex = 9;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblLogin.Location = new System.Drawing.Point(459, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(95, 33);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 28);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCerrar.BackgroundImage = global::FrmParcial.Properties.Resources.application_exit_icon_181084;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(755, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnMinimizar.BackgroundImage = global::FrmParcial.Properties.Resources.window_minimize_icon_181229;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(727, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblErrorIngreso
            // 
            this.lblErrorIngreso.AutoSize = true;
            this.lblErrorIngreso.Font = new System.Drawing.Font("Myanmar Text", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblErrorIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblErrorIngreso.Location = new System.Drawing.Point(310, 170);
            this.lblErrorIngreso.Name = "lblErrorIngreso";
            this.lblErrorIngreso.Size = new System.Drawing.Size(0, 20);
            this.lblErrorIngreso.TabIndex = 16;
            // 
            // picInicioVendedor
            // 
            this.picInicioVendedor.Image = global::FrmParcial.Properties.Resources.gifIngresoVendedor;
            this.picInicioVendedor.Location = new System.Drawing.Point(250, 25);
            this.picInicioVendedor.Name = "picInicioVendedor";
            this.picInicioVendedor.Size = new System.Drawing.Size(530, 305);
            this.picInicioVendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInicioVendedor.TabIndex = 17;
            this.picInicioVendedor.TabStop = false;
            this.picInicioVendedor.Visible = false;
            // 
            // tmrContadorTiempo
            // 
            this.tmrContadorTiempo.Tick += new System.EventHandler(this.tmrContadorTiempo_Tick);
            // 
            // picInicioDueño
            // 
            this.picInicioDueño.Image = global::FrmParcial.Properties.Resources.gifIngresoDueño;
            this.picInicioDueño.Location = new System.Drawing.Point(250, 22);
            this.picInicioDueño.Name = "picInicioDueño";
            this.picInicioDueño.Size = new System.Drawing.Size(530, 305);
            this.picInicioDueño.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInicioDueño.TabIndex = 18;
            this.picInicioDueño.TabStop = false;
            this.picInicioDueño.Visible = false;
            // 
            // chkAnimaciones
            // 
            this.chkAnimaciones.AutoSize = true;
            this.chkAnimaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkAnimaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAnimaciones.ForeColor = System.Drawing.Color.Transparent;
            this.chkAnimaciones.Location = new System.Drawing.Point(625, 300);
            this.chkAnimaciones.Name = "chkAnimaciones";
            this.chkAnimaciones.Size = new System.Drawing.Size(149, 19);
            this.chkAnimaciones.TabIndex = 9;
            this.chkAnimaciones.Text = "Desactivar Animaciones";
            this.chkAnimaciones.UseVisualStyleBackColor = true;
            // 
            // btnContador
            // 
            this.btnContador.BackColor = System.Drawing.Color.DarkRed;
            this.btnContador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContador.FlatAppearance.BorderSize = 0;
            this.btnContador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnContador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnContador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContador.ForeColor = System.Drawing.Color.White;
            this.btnContador.Location = new System.Drawing.Point(423, 291);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(157, 33);
            this.btnContador.TabIndex = 19;
            this.btnContador.Text = "Autocompletar Contador";
            this.btnContador.UseVisualStyleBackColor = false;
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.picInicioVendedor);
            this.Controls.Add(this.picInicioDueño);
            this.Controls.Add(this.lblErrorIngreso);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAutocompletarDueño);
            this.Controls.Add(this.btnAutocompletarVendedor);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.chkAnimaciones);
            this.Controls.Add(this.btnContador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInicioVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInicioDueño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnIngresar;
        private Button btnAutocompletarVendedor;
        private Button btnAutocompletarDueño;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private Panel panel1;
        private PictureBox picLogo;
        private Panel panel2;
        private Panel panel3;
        private Label lblLogin;
        private PictureBox pictureBox1;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Label lblErrorIngreso;
        private PictureBox picInicioVendedor;
        private System.Windows.Forms.Timer tmrContadorTiempo;
        private PictureBox picInicioDueño;
        private CheckBox chkAnimaciones;
        private Button btnContador;
    }
}