namespace Sistema_de_Reserva_de_Hotel
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.clbServicios = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbResumen = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcularReserva = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.LbLSalida = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(42, 61);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(206, 22);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENTE";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(48, 151);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(200, 22);
            this.dtpEntrada.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTREDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "SALIDA";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(364, 126);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 22);
            this.dtpSalida.TabIndex = 5;
            // 
            // numPersonas
            // 
            this.numPersonas.Location = new System.Drawing.Point(46, 233);
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(200, 22);
            this.numPersonas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "NUMERO DE PERSONAS";
            // 
            // clbServicios
            // 
            this.clbServicios.FormattingEnabled = true;
            this.clbServicios.Items.AddRange(new object[] {
            "WiFi Premium",
            "Desayuno Buffet",
            "Estacionamiento",
            "Spa"});
            this.clbServicios.Location = new System.Drawing.Point(364, 218);
            this.clbServicios.Name = "clbServicios";
            this.clbServicios.Size = new System.Drawing.Size(200, 72);
            this.clbServicios.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "SERVICIO";
            // 
            // rtbResumen
            // 
            this.rtbResumen.Location = new System.Drawing.Point(46, 326);
            this.rtbResumen.Name = "rtbResumen";
            this.rtbResumen.ReadOnly = true;
            this.rtbResumen.Size = new System.Drawing.Size(199, 112);
            this.rtbResumen.TabIndex = 10;
            this.rtbResumen.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "RESUMEN";
            // 
            // btnCalcularReserva
            // 
            this.btnCalcularReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularReserva.Location = new System.Drawing.Point(364, 333);
            this.btnCalcularReserva.Name = "btnCalcularReserva";
            this.btnCalcularReserva.Size = new System.Drawing.Size(154, 35);
            this.btnCalcularReserva.TabIndex = 12;
            this.btnCalcularReserva.Text = "RESUMEN";
            this.btnCalcularReserva.UseVisualStyleBackColor = true;
            this.btnCalcularReserva.Click += new System.EventHandler(this.btnCalcularReserva_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(43, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 18);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "OBLIGATORIO";
            this.lblNombre.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "OBLIGATORIO";
            this.label8.Visible = false;
            // 
            // LblEntrada
            // 
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrada.Location = new System.Drawing.Point(45, 176);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(109, 18);
            this.LblEntrada.TabIndex = 15;
            this.LblEntrada.Text = "OBLIGATORIO";
            this.LblEntrada.Visible = false;
            // 
            // LbLSalida
            // 
            this.LbLSalida.AutoSize = true;
            this.LbLSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLSalida.Location = new System.Drawing.Point(361, 155);
            this.LbLSalida.Name = "LbLSalida";
            this.LbLSalida.Size = new System.Drawing.Size(109, 18);
            this.LbLSalida.TabIndex = 16;
            this.LbLSalida.Text = "OBLIGATORIO";
            this.LbLSalida.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "OBLIGATORIO";
            this.label11.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LbLSalida);
            this.Controls.Add(this.LblEntrada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCalcularReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbResumen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clbServicios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbServicios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbResumen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcularReserva;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.Label LbLSalida;
        private System.Windows.Forms.Label label11;
    }
}

