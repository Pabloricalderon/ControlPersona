namespace GestionPersona
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
            this.btingresar = new System.Windows.Forms.Button();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.lbdpi = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbapellido = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.btmostrar = new System.Windows.Forms.Button();
            this.btMayusculas = new System.Windows.Forms.Button();
            this.lbedad = new System.Windows.Forms.Label();
            this.btedad = new System.Windows.Forms.Button();
            this.btCorregirNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btingresar
            // 
            this.btingresar.Location = new System.Drawing.Point(89, 342);
            this.btingresar.Name = "btingresar";
            this.btingresar.Size = new System.Drawing.Size(84, 41);
            this.btingresar.TabIndex = 0;
            this.btingresar.Text = "Ingresar";
            this.btingresar.UseVisualStyleBackColor = true;
            this.btingresar.Click += new System.EventHandler(this.btingresar_Click);
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(180, 26);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(100, 26);
            this.txtDPI.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(180, 114);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 26);
            this.txtnombre.TabIndex = 2;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(180, 207);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 26);
            this.txtapellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "DPI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "APELLIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "FECHA";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(180, 280);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(275, 26);
            this.dtpfecha.TabIndex = 9;
            // 
            // lbdpi
            // 
            this.lbdpi.AutoSize = true;
            this.lbdpi.Location = new System.Drawing.Point(477, 26);
            this.lbdpi.Name = "lbdpi";
            this.lbdpi.Size = new System.Drawing.Size(51, 20);
            this.lbdpi.TabIndex = 10;
            this.lbdpi.Text = "label5";
            this.lbdpi.Visible = false;
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(477, 114);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(51, 20);
            this.lbnombre.TabIndex = 11;
            this.lbnombre.Text = "label6";
            this.lbnombre.Visible = false;
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Location = new System.Drawing.Point(477, 213);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(51, 20);
            this.lbapellido.TabIndex = 12;
            this.lbapellido.Text = "label7";
            this.lbapellido.Visible = false;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(477, 280);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(51, 20);
            this.lbfecha.TabIndex = 13;
            this.lbfecha.Text = "label8";
            this.lbfecha.Visible = false;
            // 
            // btmostrar
            // 
            this.btmostrar.Location = new System.Drawing.Point(402, 342);
            this.btmostrar.Name = "btmostrar";
            this.btmostrar.Size = new System.Drawing.Size(107, 54);
            this.btmostrar.TabIndex = 14;
            this.btmostrar.Text = "Mostrar";
            this.btmostrar.UseVisualStyleBackColor = true;
            this.btmostrar.Click += new System.EventHandler(this.btmostrar_Click);
            // 
            // btMayusculas
            // 
            this.btMayusculas.Location = new System.Drawing.Point(591, 342);
            this.btMayusculas.Name = "btMayusculas";
            this.btMayusculas.Size = new System.Drawing.Size(130, 59);
            this.btMayusculas.TabIndex = 15;
            this.btMayusculas.Text = "Mayuscula";
            this.btMayusculas.UseVisualStyleBackColor = true;
            this.btMayusculas.Click += new System.EventHandler(this.btMayusculas_Click);
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(653, 36);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(51, 20);
            this.lbedad.TabIndex = 16;
            this.lbedad.Text = "label5";
            this.lbedad.Visible = false;
            // 
            // btedad
            // 
            this.btedad.Location = new System.Drawing.Point(591, 77);
            this.btedad.Name = "btedad";
            this.btedad.Size = new System.Drawing.Size(158, 57);
            this.btedad.TabIndex = 17;
            this.btedad.Text = "Mostrar edad";
            this.btedad.UseVisualStyleBackColor = true;
            this.btedad.Click += new System.EventHandler(this.btedad_Click);
            // 
            // btCorregirNombre
            // 
            this.btCorregirNombre.Location = new System.Drawing.Point(600, 207);
            this.btCorregirNombre.Name = "btCorregirNombre";
            this.btCorregirNombre.Size = new System.Drawing.Size(149, 44);
            this.btCorregirNombre.TabIndex = 18;
            this.btCorregirNombre.Text = "Corregir nombre";
            this.btCorregirNombre.UseVisualStyleBackColor = true;
            this.btCorregirNombre.Click += new System.EventHandler(this.btCorregirNombre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 560);
            this.Controls.Add(this.btCorregirNombre);
            this.Controls.Add(this.btedad);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.btMayusculas);
            this.Controls.Add(this.btmostrar);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbapellido);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbdpi);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.btingresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btingresar;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lbdpi;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbapellido;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Button btmostrar;
        private System.Windows.Forms.Button btMayusculas;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Button btedad;
        private System.Windows.Forms.Button btCorregirNombre;
    }
}

