namespace Sierpinski
{
    partial class VentanaSierpinski
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
            this.botonAumentar = new System.Windows.Forms.Button();
            this.botonDisminuir = new System.Windows.Forms.Button();
            this.fractales = new System.Windows.Forms.ComboBox();
            this.botonColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAumentar
            // 
            this.botonAumentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAumentar.Location = new System.Drawing.Point(125, 12);
            this.botonAumentar.Name = "botonAumentar";
            this.botonAumentar.Size = new System.Drawing.Size(107, 35);
            this.botonAumentar.TabIndex = 0;
            this.botonAumentar.Text = "Nivel ++";
            this.botonAumentar.UseVisualStyleBackColor = true;
            this.botonAumentar.Click += new System.EventHandler(this.BotonAumentar_Click);
            // 
            // botonDisminuir
            // 
            this.botonDisminuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonDisminuir.Location = new System.Drawing.Point(12, 12);
            this.botonDisminuir.Name = "botonDisminuir";
            this.botonDisminuir.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.botonDisminuir.Size = new System.Drawing.Size(107, 35);
            this.botonDisminuir.TabIndex = 1;
            this.botonDisminuir.Text = "Nivel --";
            this.botonDisminuir.UseVisualStyleBackColor = true;
            this.botonDisminuir.Click += new System.EventHandler(this.BotonDisminuir_Click);
            // 
            // fractales
            // 
            this.fractales.DisplayMember = "g}";
            this.fractales.FormattingEnabled = true;
            this.fractales.Items.AddRange(new object[] {
            "Triangulo",
            "Cuadrado"});
            this.fractales.Location = new System.Drawing.Point(351, 20);
            this.fractales.Name = "fractales";
            this.fractales.Size = new System.Drawing.Size(121, 21);
            this.fractales.TabIndex = 2;
            this.fractales.Text = "Fractal";
            this.fractales.ValueMember = "g}";
            this.fractales.SelectedIndexChanged += new System.EventHandler(this.Fractales_SelectedIndexChanged);
            // 
            // botonColor
            // 
            this.botonColor.Location = new System.Drawing.Point(238, 12);
            this.botonColor.Name = "botonColor";
            this.botonColor.Size = new System.Drawing.Size(107, 35);
            this.botonColor.TabIndex = 3;
            this.botonColor.Text = "Color";
            this.botonColor.UseVisualStyleBackColor = true;
            this.botonColor.Click += new System.EventHandler(this.BotonColor_Click);
            // 
            // VentanaTrianguloSierpinski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.botonColor);
            this.Controls.Add(this.fractales);
            this.Controls.Add(this.botonDisminuir);
            this.Controls.Add(this.botonAumentar);
            this.Name = "VentanaTrianguloSierpinski";
            this.Text = "FractalSierpinski";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAumentar;
        private System.Windows.Forms.Button botonDisminuir;
        private System.Windows.Forms.ComboBox fractales;
        private System.Windows.Forms.Button botonColor;
    }
}

