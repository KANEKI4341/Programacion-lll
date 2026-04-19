namespace Clasificacion_de_estudiantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textNota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listDesaprova = new System.Windows.Forms.GroupBox();
            this.listAprobados = new System.Windows.Forms.ListBox();
            this.listDesaprovados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.listDesaprova.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textNota);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(607, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVO REGISTRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DEL ALUMNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOTA (0.0 - 5.0)";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(13, 81);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(217, 30);
            this.textNombre.TabIndex = 2;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textNota
            // 
            this.textNota.Location = new System.Drawing.Point(350, 81);
            this.textNota.Name = "textNota";
            this.textNota.Size = new System.Drawing.Size(217, 30);
            this.textNota.TabIndex = 3;
            this.textNota.TextChanged += new System.EventHandler(this.textNota_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "GUARDAR ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listAprobados);
            this.groupBox2.Location = new System.Drawing.Point(36, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 211);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "APROBADOS (> = 3.0)";
            // 
            // listDesaprova
            // 
            this.listDesaprova.Controls.Add(this.listDesaprovados);
            this.listDesaprova.Location = new System.Drawing.Point(378, 296);
            this.listDesaprova.Name = "listDesaprova";
            this.listDesaprova.Size = new System.Drawing.Size(265, 211);
            this.listDesaprova.TabIndex = 3;
            this.listDesaprova.TabStop = false;
            this.listDesaprova.Text = "DESAPROBADOS (< 3.0)";
            // 
            // listAprobados
            // 
            this.listAprobados.FormattingEnabled = true;
            this.listAprobados.ItemHeight = 25;
            this.listAprobados.Location = new System.Drawing.Point(13, 45);
            this.listAprobados.Name = "listAprobados";
            this.listAprobados.Size = new System.Drawing.Size(227, 154);
            this.listAprobados.TabIndex = 0;
            this.listAprobados.SelectedIndexChanged += new System.EventHandler(this.listAprobados_SelectedIndexChanged);
            // 
            // listDesaprovados
            // 
            this.listDesaprovados.FormattingEnabled = true;
            this.listDesaprovados.ItemHeight = 25;
            this.listDesaprovados.Location = new System.Drawing.Point(17, 45);
            this.listDesaprovados.Name = "listDesaprovados";
            this.listDesaprovados.Size = new System.Drawing.Size(227, 154);
            this.listDesaprovados.TabIndex = 1;
            this.listDesaprovados.SelectedIndexChanged += new System.EventHandler(this.listDesaprobados_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 703);
            this.Controls.Add(this.listDesaprova);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.listDesaprova.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textNota;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox listDesaprova;
        private System.Windows.Forms.ListBox listAprobados;
        private System.Windows.Forms.ListBox listDesaprovados;
    }
}

