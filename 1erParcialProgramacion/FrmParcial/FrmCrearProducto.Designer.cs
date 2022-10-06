namespace FrmParcial
{
    partial class FrmCrearProducto
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.grpMemoriaRam = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRamMemoria = new System.Windows.Forms.TextBox();
            this.txtRamVelocidad = new System.Windows.Forms.TextBox();
            this.txtRamTecnologia = new System.Windows.Forms.TextBox();
            this.grpVideo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVideoEnergia = new System.Windows.Forms.TextBox();
            this.txtVideoChipset = new System.Windows.Forms.TextBox();
            this.grpNotebook = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNotebookProcesador = new System.Windows.Forms.TextBox();
            this.txtNotebookAlmacenamiento = new System.Windows.Forms.TextBox();
            this.txtNotebookRam = new System.Windows.Forms.TextBox();
            this.txtVideoMemoria = new System.Windows.Forms.TextBox();
            this.txtProcesadorSocket = new System.Windows.Forms.TextBox();
            this.txtProcesadorNucleos = new System.Windows.Forms.TextBox();
            this.txtProcesadorFrecuencia = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpProcesador = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grpMemoriaRam.SuspendLayout();
            this.grpVideo.SuspendLayout();
            this.grpNotebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpProcesador.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(138, 146);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 23);
            this.txtPrecio.TabIndex = 0;
            this.txtPrecio.Text = "txtPrecio";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(138, 204);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(125, 23);
            this.txtStock.TabIndex = 1;
            this.txtStock.Text = "txtStock";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(138, 88);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(125, 23);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.Text = "txtModelo";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(138, 175);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(125, 23);
            this.txtCategoria.TabIndex = 7;
            this.txtCategoria.Text = "txtCategoria";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(138, 117);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(125, 23);
            this.txtMarca.TabIndex = 6;
            this.txtMarca.Text = "txtMarca";
            // 
            // cmbTipoDeProducto
            // 
            this.cmbTipoDeProducto.FormattingEnabled = true;
            this.cmbTipoDeProducto.Items.AddRange(new object[] {
            "Tipo De Producto",
            "Memoria Ram",
            "Notebook",
            "Placa de Video",
            "Procesador"});
            this.cmbTipoDeProducto.Location = new System.Drawing.Point(138, 59);
            this.cmbTipoDeProducto.Name = "cmbTipoDeProducto";
            this.cmbTipoDeProducto.Size = new System.Drawing.Size(125, 23);
            this.cmbTipoDeProducto.TabIndex = 8;
            this.cmbTipoDeProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeProducto_SelectedIndexChanged);
            // 
            // grpMemoriaRam
            // 
            this.grpMemoriaRam.Controls.Add(this.label7);
            this.grpMemoriaRam.Controls.Add(this.label8);
            this.grpMemoriaRam.Controls.Add(this.label9);
            this.grpMemoriaRam.Controls.Add(this.txtRamMemoria);
            this.grpMemoriaRam.Controls.Add(this.txtRamVelocidad);
            this.grpMemoriaRam.Controls.Add(this.txtRamTecnologia);
            this.grpMemoriaRam.Location = new System.Drawing.Point(0, 4);
            this.grpMemoriaRam.Name = "grpMemoriaRam";
            this.grpMemoriaRam.Size = new System.Drawing.Size(252, 129);
            this.grpMemoriaRam.TabIndex = 9;
            this.grpMemoriaRam.TabStop = false;
            this.grpMemoriaRam.Text = "Memoria Ram";
            this.grpMemoriaRam.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Velocidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tecnologia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "Memoria";
            // 
            // txtRamMemoria
            // 
            this.txtRamMemoria.Location = new System.Drawing.Point(129, 31);
            this.txtRamMemoria.Name = "txtRamMemoria";
            this.txtRamMemoria.Size = new System.Drawing.Size(100, 23);
            this.txtRamMemoria.TabIndex = 0;
            // 
            // txtRamVelocidad
            // 
            this.txtRamVelocidad.Location = new System.Drawing.Point(129, 89);
            this.txtRamVelocidad.Name = "txtRamVelocidad";
            this.txtRamVelocidad.Size = new System.Drawing.Size(100, 23);
            this.txtRamVelocidad.TabIndex = 2;
            // 
            // txtRamTecnologia
            // 
            this.txtRamTecnologia.Location = new System.Drawing.Point(129, 60);
            this.txtRamTecnologia.Name = "txtRamTecnologia";
            this.txtRamTecnologia.Size = new System.Drawing.Size(100, 23);
            this.txtRamTecnologia.TabIndex = 1;
            // 
            // grpVideo
            // 
            this.grpVideo.Controls.Add(this.label13);
            this.grpVideo.Controls.Add(this.label14);
            this.grpVideo.Controls.Add(this.label15);
            this.grpVideo.Controls.Add(this.txtVideoEnergia);
            this.grpVideo.Controls.Add(this.txtVideoChipset);
            this.grpVideo.Controls.Add(this.grpNotebook);
            this.grpVideo.Controls.Add(this.txtVideoMemoria);
            this.grpVideo.Location = new System.Drawing.Point(297, 59);
            this.grpVideo.Name = "grpVideo";
            this.grpVideo.Size = new System.Drawing.Size(252, 129);
            this.grpVideo.TabIndex = 11;
            this.grpVideo.TabStop = false;
            this.grpVideo.Text = "Placa de Video";
            this.grpVideo.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 21);
            this.label13.TabIndex = 36;
            this.label13.Text = "Energia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(6, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 21);
            this.label14.TabIndex = 35;
            this.label14.Text = "Memoria";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(6, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "Chipset";
            // 
            // txtVideoEnergia
            // 
            this.txtVideoEnergia.Location = new System.Drawing.Point(129, 94);
            this.txtVideoEnergia.Name = "txtVideoEnergia";
            this.txtVideoEnergia.Size = new System.Drawing.Size(100, 23);
            this.txtVideoEnergia.TabIndex = 5;
            // 
            // txtVideoChipset
            // 
            this.txtVideoChipset.Location = new System.Drawing.Point(129, 36);
            this.txtVideoChipset.Name = "txtVideoChipset";
            this.txtVideoChipset.Size = new System.Drawing.Size(100, 23);
            this.txtVideoChipset.TabIndex = 3;
            // 
            // grpNotebook
            // 
            this.grpNotebook.Controls.Add(this.grpMemoriaRam);
            this.grpNotebook.Controls.Add(this.label16);
            this.grpNotebook.Controls.Add(this.label17);
            this.grpNotebook.Controls.Add(this.label18);
            this.grpNotebook.Controls.Add(this.txtNotebookProcesador);
            this.grpNotebook.Controls.Add(this.txtNotebookAlmacenamiento);
            this.grpNotebook.Controls.Add(this.txtNotebookRam);
            this.grpNotebook.Location = new System.Drawing.Point(0, 0);
            this.grpNotebook.Name = "grpNotebook";
            this.grpNotebook.Size = new System.Drawing.Size(252, 129);
            this.grpNotebook.TabIndex = 10;
            this.grpNotebook.TabStop = false;
            this.grpNotebook.Text = "Notebook";
            this.grpNotebook.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(6, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 21);
            this.label16.TabIndex = 36;
            this.label16.Text = "Procesador";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(6, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 21);
            this.label17.TabIndex = 35;
            this.label17.Text = "Almacenamiento";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(6, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 21);
            this.label18.TabIndex = 34;
            this.label18.Text = "Memoria";
            // 
            // txtNotebookProcesador
            // 
            this.txtNotebookProcesador.Location = new System.Drawing.Point(129, 93);
            this.txtNotebookProcesador.Name = "txtNotebookProcesador";
            this.txtNotebookProcesador.Size = new System.Drawing.Size(100, 23);
            this.txtNotebookProcesador.TabIndex = 2;
            // 
            // txtNotebookAlmacenamiento
            // 
            this.txtNotebookAlmacenamiento.Location = new System.Drawing.Point(129, 64);
            this.txtNotebookAlmacenamiento.Name = "txtNotebookAlmacenamiento";
            this.txtNotebookAlmacenamiento.Size = new System.Drawing.Size(100, 23);
            this.txtNotebookAlmacenamiento.TabIndex = 1;
            // 
            // txtNotebookRam
            // 
            this.txtNotebookRam.Location = new System.Drawing.Point(129, 35);
            this.txtNotebookRam.Name = "txtNotebookRam";
            this.txtNotebookRam.Size = new System.Drawing.Size(100, 23);
            this.txtNotebookRam.TabIndex = 0;
            // 
            // txtVideoMemoria
            // 
            this.txtVideoMemoria.Location = new System.Drawing.Point(129, 65);
            this.txtVideoMemoria.Name = "txtVideoMemoria";
            this.txtVideoMemoria.Size = new System.Drawing.Size(100, 23);
            this.txtVideoMemoria.TabIndex = 4;
            // 
            // txtProcesadorSocket
            // 
            this.txtProcesadorSocket.Location = new System.Drawing.Point(129, 86);
            this.txtProcesadorSocket.Name = "txtProcesadorSocket";
            this.txtProcesadorSocket.Size = new System.Drawing.Size(100, 23);
            this.txtProcesadorSocket.TabIndex = 5;
            // 
            // txtProcesadorNucleos
            // 
            this.txtProcesadorNucleos.Location = new System.Drawing.Point(129, 29);
            this.txtProcesadorNucleos.Name = "txtProcesadorNucleos";
            this.txtProcesadorNucleos.Size = new System.Drawing.Size(100, 23);
            this.txtProcesadorNucleos.TabIndex = 3;
            // 
            // txtProcesadorFrecuencia
            // 
            this.txtProcesadorFrecuencia.Location = new System.Drawing.Point(129, 57);
            this.txtProcesadorFrecuencia.Name = "txtProcesadorFrecuencia";
            this.txtProcesadorFrecuencia.Size = new System.Drawing.Size(100, 23);
            this.txtProcesadorFrecuencia.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(303, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(188, 258);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
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
            this.btnMinimizar.Location = new System.Drawing.Point(503, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 24;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(534, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tipo de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Categoria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 28);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // grpProcesador
            // 
            this.grpProcesador.Controls.Add(this.label10);
            this.grpProcesador.Controls.Add(this.label11);
            this.grpProcesador.Controls.Add(this.label12);
            this.grpProcesador.Controls.Add(this.txtProcesadorSocket);
            this.grpProcesador.Controls.Add(this.txtProcesadorNucleos);
            this.grpProcesador.Controls.Add(this.txtProcesadorFrecuencia);
            this.grpProcesador.Location = new System.Drawing.Point(297, 59);
            this.grpProcesador.Name = "grpProcesador";
            this.grpProcesador.Size = new System.Drawing.Size(252, 133);
            this.grpProcesador.TabIndex = 10;
            this.grpProcesador.TabStop = false;
            this.grpProcesador.Text = "Procesador";
            this.grpProcesador.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "Socket";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "Frecuencia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 21);
            this.label12.TabIndex = 37;
            this.label12.Text = "Nucleo";
            // 
            // FrmCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 307);
            this.Controls.Add(this.grpVideo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpProcesador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbTipoDeProducto);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearProducto";
            this.Load += new System.EventHandler(this.FrmCrearProducto_Load);
            this.grpMemoriaRam.ResumeLayout(false);
            this.grpMemoriaRam.PerformLayout();
            this.grpVideo.ResumeLayout(false);
            this.grpVideo.PerformLayout();
            this.grpNotebook.ResumeLayout(false);
            this.grpNotebook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpProcesador.ResumeLayout(false);
            this.grpProcesador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPrecio;
        private TextBox txtStock;
        private TextBox txtModelo;
        private TextBox txtCategoria;
        private TextBox txtMarca;
        private ComboBox cmbTipoDeProducto;
        private GroupBox grpMemoriaRam;
        private TextBox txtRamVelocidad;
        private TextBox txtRamTecnologia;
        private TextBox txtRamMemoria;
        private TextBox txtProcesadorSocket;
        private TextBox txtProcesadorFrecuencia;
        private TextBox txtProcesadorNucleos;
        private GroupBox grpVideo;
        private TextBox txtVideoEnergia;
        private TextBox txtVideoChipset;
        private TextBox txtVideoMemoria;
        private GroupBox grpNotebook;
        private TextBox txtNotebookProcesador;
        private TextBox txtNotebookAlmacenamiento;
        private TextBox txtNotebookRam;
        private Button btnSalir;
        private Button btnCrear;
        private Button btnMinimizar;
        private Button btnCerrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private GroupBox grpProcesador;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}