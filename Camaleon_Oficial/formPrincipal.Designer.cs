namespace Presentacion
{
    partial class formPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncargo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ventas_reg = new System.Windows.Forms.Button();
            this.btn_compras_reg = new System.Windows.Forms.Button();
            this.btn_registros = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_usu = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_anadirCliente = new System.Windows.Forms.Button();
            this.btn_perfilUsu = new System.Windows.Forms.Button();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.pnl_contenido = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnprov = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            this.pnl_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(219, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 28);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.btnprov);
            this.panel2.Controls.Add(this.btncargo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_registros);
            this.panel2.Controls.Add(this.btn_producto);
            this.panel2.Controls.Add(this.lbl_cargo);
            this.panel2.Controls.Add(this.lbl_usu);
            this.panel2.Controls.Add(this.lbl_nom);
            this.panel2.Controls.Add(this.btn_cerrar);
            this.panel2.Controls.Add(this.btn_empleados);
            this.panel2.Controls.Add(this.btn_anadirCliente);
            this.panel2.Controls.Add(this.btn_perfilUsu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 546);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btncargo
            // 
            this.btncargo.BackColor = System.Drawing.Color.SlateGray;
            this.btncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btncargo.Location = new System.Drawing.Point(34, 414);
            this.btncargo.Name = "btncargo";
            this.btncargo.Size = new System.Drawing.Size(166, 35);
            this.btncargo.TabIndex = 10;
            this.btncargo.Text = "Cargo";
            this.btncargo.UseVisualStyleBackColor = false;
            this.btncargo.Click += new System.EventHandler(this.btncargo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_ventas_reg);
            this.panel3.Controls.Add(this.btn_compras_reg);
            this.panel3.Location = new System.Drawing.Point(58, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 100);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_ventas_reg
            // 
            this.btn_ventas_reg.BackColor = System.Drawing.Color.SlateGray;
            this.btn_ventas_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas_reg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_ventas_reg.Location = new System.Drawing.Point(0, 3);
            this.btn_ventas_reg.Name = "btn_ventas_reg";
            this.btn_ventas_reg.Size = new System.Drawing.Size(142, 35);
            this.btn_ventas_reg.TabIndex = 10;
            this.btn_ventas_reg.Text = "Ventas";
            this.btn_ventas_reg.UseVisualStyleBackColor = false;
            // 
            // btn_compras_reg
            // 
            this.btn_compras_reg.BackColor = System.Drawing.Color.SlateGray;
            this.btn_compras_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compras_reg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_compras_reg.Location = new System.Drawing.Point(0, 44);
            this.btn_compras_reg.Name = "btn_compras_reg";
            this.btn_compras_reg.Size = new System.Drawing.Size(142, 35);
            this.btn_compras_reg.TabIndex = 11;
            this.btn_compras_reg.Text = "Compras";
            this.btn_compras_reg.UseVisualStyleBackColor = false;
            // 
            // btn_registros
            // 
            this.btn_registros.BackColor = System.Drawing.Color.SlateGray;
            this.btn_registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_registros.Location = new System.Drawing.Point(34, 283);
            this.btn_registros.Name = "btn_registros";
            this.btn_registros.Size = new System.Drawing.Size(166, 35);
            this.btn_registros.TabIndex = 9;
            this.btn_registros.Text = "Registros";
            this.btn_registros.UseVisualStyleBackColor = false;
            // 
            // btn_producto
            // 
            this.btn_producto.BackColor = System.Drawing.Color.SlateGray;
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_producto.Location = new System.Drawing.Point(33, 242);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(167, 35);
            this.btn_producto.TabIndex = 8;
            this.btn_producto.Text = "Productos";
            this.btn_producto.UseVisualStyleBackColor = false;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(34, 81);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(60, 20);
            this.lbl_cargo.TabIndex = 7;
            this.lbl_cargo.Text = "Cargo:";
            // 
            // lbl_usu
            // 
            this.lbl_usu.AutoSize = true;
            this.lbl_usu.Location = new System.Drawing.Point(33, 61);
            this.lbl_usu.Name = "lbl_usu";
            this.lbl_usu.Size = new System.Drawing.Size(67, 20);
            this.lbl_usu.TabIndex = 6;
            this.lbl_usu.Text = "Usuario:";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(33, 41);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(76, 20);
            this.lbl_nom.TabIndex = 2;
            this.lbl_nom.Text = "Nombre: ";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.SlateGray;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_cerrar.Location = new System.Drawing.Point(34, 498);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(151, 35);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar Sesión";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.BackColor = System.Drawing.Color.SlateGray;
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_empleados.Location = new System.Drawing.Point(33, 201);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(167, 35);
            this.btn_empleados.TabIndex = 4;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = false;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_anadirCliente
            // 
            this.btn_anadirCliente.BackColor = System.Drawing.Color.SlateGray;
            this.btn_anadirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anadirCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_anadirCliente.Location = new System.Drawing.Point(33, 160);
            this.btn_anadirCliente.Name = "btn_anadirCliente";
            this.btn_anadirCliente.Size = new System.Drawing.Size(167, 35);
            this.btn_anadirCliente.TabIndex = 3;
            this.btn_anadirCliente.Text = "Añadir Cliente";
            this.btn_anadirCliente.UseVisualStyleBackColor = false;
            this.btn_anadirCliente.Click += new System.EventHandler(this.btn_anadirCliente_Click);
            // 
            // btn_perfilUsu
            // 
            this.btn_perfilUsu.BackColor = System.Drawing.Color.SlateGray;
            this.btn_perfilUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perfilUsu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_perfilUsu.Location = new System.Drawing.Point(33, 119);
            this.btn_perfilUsu.Name = "btn_perfilUsu";
            this.btn_perfilUsu.Size = new System.Drawing.Size(167, 35);
            this.btn_perfilUsu.TabIndex = 2;
            this.btn_perfilUsu.Text = "Perfil de Usuario";
            this.btn_perfilUsu.UseVisualStyleBackColor = false;
            this.btn_perfilUsu.Click += new System.EventHandler(this.btn_perfilUsu_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.Controls.Add(this.pnl_contenido);
            this.panelcontenedor.Controls.Add(this.panel1);
            this.panelcontenedor.Controls.Add(this.panel2);
            this.panelcontenedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelcontenedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelcontenedor.Location = new System.Drawing.Point(0, -1);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1050, 546);
            this.panelcontenedor.TabIndex = 0;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenedor_Paint);
            // 
            // pnl_contenido
            // 
            this.pnl_contenido.Controls.Add(this.pictureBox1);
            this.pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenido.Location = new System.Drawing.Point(219, 28);
            this.pnl_contenido.Name = "pnl_contenido";
            this.pnl_contenido.Size = new System.Drawing.Size(831, 518);
            this.pnl_contenido.TabIndex = 2;
            this.pnl_contenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_contenido_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.camaleon;
            this.pictureBox1.Location = new System.Drawing.Point(202, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnprov
            // 
            this.btnprov.BackColor = System.Drawing.Color.SlateGray;
            this.btnprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprov.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnprov.Location = new System.Drawing.Point(33, 457);
            this.btnprov.Name = "btnprov";
            this.btnprov.Size = new System.Drawing.Size(166, 35);
            this.btnprov.TabIndex = 11;
            this.btnprov.Text = "Proveedor";
            this.btnprov.UseVisualStyleBackColor = false;
            this.btnprov.Click += new System.EventHandler(this.btnprov_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 544);
            this.Controls.Add(this.panelcontenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrincipal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            this.pnl_contenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_producto;
        private Label lbl_cargo;
        private Label lbl_usu;
        private Label lbl_nom;
        private Button btn_cerrar;
        private Button btn_empleados;
        private Button btn_anadirCliente;
        private Button btn_perfilUsu;
        private Panel panelcontenedor;
        private Panel pnl_contenido;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btn_ventas_reg;
        private Button btn_compras_reg;
        private Button btn_registros;
        private Button btncargo;
        private Button btnprov;
    }
}