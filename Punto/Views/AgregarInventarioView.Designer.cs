namespace Punto
{
    partial class AgregarInventarioView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtnomcorto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblestatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(235, 34);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(167, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(235, 75);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(167, 20);
            this.txtdescripcion.TabIndex = 3;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(147, 82);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.Text = "Descripcion";
            // 
            // txtnomcorto
            // 
            this.txtnomcorto.Location = new System.Drawing.Point(235, 115);
            this.txtnomcorto.Name = "txtnomcorto";
            this.txtnomcorto.Size = new System.Drawing.Size(167, 20);
            this.txtnomcorto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Corto";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(235, 154);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(167, 20);
            this.txtprecio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(235, 191);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(167, 20);
            this.txtcantidad.TabIndex = 9;
            this.txtcantidad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(247, 292);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(86, 40);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(383, 292);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(86, 40);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Regresar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblestatus
            // 
            this.lblestatus.AutoSize = true;
            this.lblestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestatus.Location = new System.Drawing.Point(284, 249);
            this.lblestatus.Name = "lblestatus";
            this.lblestatus.Size = new System.Drawing.Size(73, 20);
            this.lblestatus.TabIndex = 12;
            this.lblestatus.Text = "Cantidad";
            // 
            // AgregarInventarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 380);
            this.Controls.Add(this.lblestatus);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnomcorto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Name = "AgregarInventarioView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox txtnomcorto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblestatus;
    }
}

