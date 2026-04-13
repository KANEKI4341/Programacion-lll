namespace Gestión_de_Inventario_de_Productos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.numStockInicial = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblIVA = new System.Windows.Forms.GroupBox();
            this.rbReducido = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbExento = new System.Windows.Forms.RadioButton();
            this.chkEsPerecedero = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblValidar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();
            this.lblIVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(27, 54);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(157, 22);
            this.txtNombreProducto.TabIndex = 0;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Electrónica",
            "Alimentos",
            "Ropa"});
            this.cmbCategoria.Location = new System.Drawing.Point(291, 52);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(157, 24);
            this.cmbCategoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "CATEGORIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Llenar campo";
            this.label3.Visible = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(301, 79);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(89, 16);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Llenar campo";
            this.lblCategoria.Visible = false;
            // 
            // numStockInicial
            // 
            this.numStockInicial.Location = new System.Drawing.Point(27, 153);
            this.numStockInicial.Name = "numStockInicial";
            this.numStockInicial.Size = new System.Drawing.Size(157, 22);
            this.numStockInicial.TabIndex = 7;
            this.numStockInicial.ValueChanged += new System.EventHandler(this.numStockInicial_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "STOCK INICIAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "STOCK MINIMO";
            // 
            // numStockMinimo
            // 
            this.numStockMinimo.Location = new System.Drawing.Point(291, 153);
            this.numStockMinimo.Name = "numStockMinimo";
            this.numStockMinimo.Size = new System.Drawing.Size(157, 22);
            this.numStockMinimo.TabIndex = 10;
            this.numStockMinimo.ValueChanged += new System.EventHandler(this.numStockMinimo_ValueChanged);
            // 
            // lblIVA
            // 
            this.lblIVA.Controls.Add(this.rbReducido);
            this.lblIVA.Controls.Add(this.rbGeneral);
            this.lblIVA.Controls.Add(this.rbExento);
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(27, 205);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(327, 100);
            this.lblIVA.TabIndex = 11;
            this.lblIVA.TabStop = false;
            this.lblIVA.Text = "IVA";
            this.lblIVA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbReducido
            // 
            this.rbReducido.AutoSize = true;
            this.rbReducido.Location = new System.Drawing.Point(217, 46);
            this.rbReducido.Name = "rbReducido";
            this.rbReducido.Size = new System.Drawing.Size(62, 29);
            this.rbReducido.TabIndex = 2;
            this.rbReducido.TabStop = true;
            this.rbReducido.Text = "5%";
            this.rbReducido.UseVisualStyleBackColor = true;
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Location = new System.Drawing.Point(109, 46);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(73, 29);
            this.rbGeneral.TabIndex = 1;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "19%";
            this.rbGeneral.UseVisualStyleBackColor = true;
            // 
            // rbExento
            // 
            this.rbExento.AutoSize = true;
            this.rbExento.Location = new System.Drawing.Point(13, 46);
            this.rbExento.Name = "rbExento";
            this.rbExento.Size = new System.Drawing.Size(62, 29);
            this.rbExento.TabIndex = 0;
            this.rbExento.TabStop = true;
            this.rbExento.Text = "0%";
            this.rbExento.UseVisualStyleBackColor = true;
            // 
            // chkEsPerecedero
            // 
            this.chkEsPerecedero.AutoSize = true;
            this.chkEsPerecedero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEsPerecedero.Location = new System.Drawing.Point(40, 351);
            this.chkEsPerecedero.Name = "chkEsPerecedero";
            this.chkEsPerecedero.Size = new System.Drawing.Size(170, 29);
            this.chkEsPerecedero.TabIndex = 12;
            this.chkEsPerecedero.Text = "PERECEDERO";
            this.chkEsPerecedero.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "ARTICULO";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(300, 351);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaVencimiento.TabIndex = 14;
            this.dtpFechaVencimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(295, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "FECHA VENCIMIENTO";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(40, 407);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(153, 31);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "CODIGO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(362, 233);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(157, 22);
            this.txtCodigo.TabIndex = 19;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(37, 178);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(89, 16);
            this.lblStock.TabIndex = 20;
            this.lblStock.Text = "Llenar campo";
            this.lblStock.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(383, 264);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(89, 16);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "Llenar campo";
            this.lblCodigo.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Llenar campo";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(164, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Llenar campo";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Llenar campo";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Llenar campo";
            this.label15.Visible = false;
            // 
            // lblValidar
            // 
            this.lblValidar.AutoSize = true;
            this.lblValidar.Location = new System.Drawing.Point(199, 417);
            this.lblValidar.Name = "lblValidar";
            this.lblValidar.Size = new System.Drawing.Size(222, 16);
            this.lblValidar.TabIndex = 26;
            this.lblValidar.Text = "REGISTRADO CORRECTAMENTE";
            this.lblValidar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValidar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkEsPerecedero);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.numStockMinimo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numStockInicial);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtNombreProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).EndInit();
            this.lblIVA.ResumeLayout(false);
            this.lblIVA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.NumericUpDown numStockInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numStockMinimo;
        private System.Windows.Forms.GroupBox lblIVA;
        private System.Windows.Forms.RadioButton rbReducido;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbExento;
        private System.Windows.Forms.CheckBox chkEsPerecedero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblValidar;
    }
}

