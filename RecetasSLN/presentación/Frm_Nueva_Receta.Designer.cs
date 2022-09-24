namespace RecetasSLN.presentación
{
    partial class Frm_Nueva_Receta
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
            this.gbUnidad = new System.Windows.Forms.GroupBox();
            this.rbtGramos = new System.Windows.Forms.RadioButton();
            this.rbtKilos = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTotalIngredientes = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboIngrediente = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtCheff = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblProximaReceta = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtCm3 = new System.Windows.Forms.RadioButton();
            this.gbUnidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUnidad
            // 
            this.gbUnidad.Controls.Add(this.rbtCm3);
            this.gbUnidad.Controls.Add(this.rbtGramos);
            this.gbUnidad.Controls.Add(this.rbtKilos);
            this.gbUnidad.Location = new System.Drawing.Point(563, 118);
            this.gbUnidad.Name = "gbUnidad";
            this.gbUnidad.Size = new System.Drawing.Size(123, 83);
            this.gbUnidad.TabIndex = 36;
            this.gbUnidad.TabStop = false;
            // 
            // rbtGramos
            // 
            this.rbtGramos.AutoSize = true;
            this.rbtGramos.Location = new System.Drawing.Point(8, 34);
            this.rbtGramos.Name = "rbtGramos";
            this.rbtGramos.Size = new System.Drawing.Size(61, 17);
            this.rbtGramos.TabIndex = 7;
            this.rbtGramos.TabStop = true;
            this.rbtGramos.Text = "Gramos";
            this.rbtGramos.UseVisualStyleBackColor = true;
            // 
            // rbtKilos
            // 
            this.rbtKilos.AutoSize = true;
            this.rbtKilos.Location = new System.Drawing.Point(8, 11);
            this.rbtKilos.Name = "rbtKilos";
            this.rbtKilos.Size = new System.Drawing.Size(47, 17);
            this.rbtKilos.TabIndex = 6;
            this.rbtKilos.TabStop = true;
            this.rbtKilos.Text = "Kilos";
            this.rbtKilos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "unidad de medida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ingrediente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(368, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(261, 331);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(703, 158);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTotalIngredientes
            // 
            this.lblTotalIngredientes.AutoSize = true;
            this.lblTotalIngredientes.Location = new System.Drawing.Point(539, 336);
            this.lblTotalIngredientes.Name = "lblTotalIngredientes";
            this.lblTotalIngredientes.Size = new System.Drawing.Size(118, 13);
            this.lblTotalIngredientes.TabIndex = 31;
            this.lblTotalIngredientes.Text = "Total de ingredientes: 0";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.col_ingrediente,
            this.col_Cantidad,
            this.colUnidad});
            this.dgvDetalles.Location = new System.Drawing.Point(48, 217);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(685, 108);
            this.dgvDetalles.TabIndex = 32;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(372, 158);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(75, 20);
            this.nudCantidad.TabIndex = 27;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboIngrediente
            // 
            this.cboIngrediente.FormattingEnabled = true;
            this.cboIngrediente.Location = new System.Drawing.Point(84, 160);
            this.cboIngrediente.Name = "cboIngrediente";
            this.cboIngrediente.Size = new System.Drawing.Size(218, 21);
            this.cboIngrediente.TabIndex = 26;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(105, 118);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 25;
            // 
            // txtCheff
            // 
            this.txtCheff.Location = new System.Drawing.Point(105, 92);
            this.txtCheff.Name = "txtCheff";
            this.txtCheff.Size = new System.Drawing.Size(303, 20);
            this.txtCheff.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tipo de Receta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cheff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // LblProximaReceta
            // 
            this.LblProximaReceta.AutoSize = true;
            this.LblProximaReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblProximaReceta.Location = new System.Drawing.Point(101, 36);
            this.LblProximaReceta.Name = "LblProximaReceta";
            this.LblProximaReceta.Size = new System.Drawing.Size(104, 20);
            this.LblProximaReceta.TabIndex = 19;
            this.LblProximaReceta.Text = "Recetas #: 1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // col_ingrediente
            // 
            this.col_ingrediente.HeaderText = "Ingrediente";
            this.col_ingrediente.Name = "col_ingrediente";
            // 
            // col_Cantidad
            // 
            this.col_Cantidad.HeaderText = "Cantidad";
            this.col_Cantidad.Name = "col_Cantidad";
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            // 
            // rbtCm3
            // 
            this.rbtCm3.AutoSize = true;
            this.rbtCm3.Location = new System.Drawing.Point(8, 57);
            this.rbtCm3.Name = "rbtCm3";
            this.rbtCm3.Size = new System.Drawing.Size(46, 17);
            this.rbtCm3.TabIndex = 8;
            this.rbtCm3.TabStop = true;
            this.rbtCm3.Text = "Cm3";
            this.rbtCm3.UseVisualStyleBackColor = true;
            // 
            // Frm_Nueva_Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbUnidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTotalIngredientes);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cboIngrediente);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtCheff);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblProximaReceta);
            this.Name = "Frm_Nueva_Receta";
            this.Text = "Frm_Nueva_Receta";
            this.Load += new System.EventHandler(this.Frm_Nueva_Receta_Load);
            this.gbUnidad.ResumeLayout(false);
            this.gbUnidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUnidad;
        private System.Windows.Forms.RadioButton rbtGramos;
        private System.Windows.Forms.RadioButton rbtKilos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTotalIngredientes;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cboIngrediente;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtCheff;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblProximaReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.RadioButton rbtCm3;
    }
}