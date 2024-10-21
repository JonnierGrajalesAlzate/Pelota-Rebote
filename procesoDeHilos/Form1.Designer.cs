namespace procesoDeHilos
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
            this.components = new System.ComponentModel.Container();
            this.btnJuego = new System.Windows.Forms.Button();
            this.tmrx2 = new System.Windows.Forms.Timer(this.components);
            this.tmrx3 = new System.Windows.Forms.Timer(this.components);
            this.tmrx5 = new System.Windows.Forms.Timer(this.components);
            this.lblJugar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJuego
            // 
            this.btnJuego.Location = new System.Drawing.Point(213, 169);
            this.btnJuego.Margin = new System.Windows.Forms.Padding(4);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(100, 28);
            this.btnJuego.TabIndex = 4;
            this.btnJuego.Text = "Juego";
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // lblJugar
            // 
            this.lblJugar.AutoSize = true;
            this.lblJugar.Location = new System.Drawing.Point(198, 110);
            this.lblJugar.Name = "lblJugar";
            this.lblJugar.Size = new System.Drawing.Size(130, 16);
            this.lblJugar.TabIndex = 5;
            this.lblJugar.Text = "¿QUIERES JUGAR?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 302);
            this.Controls.Add(this.lblJugar);
            this.Controls.Add(this.btnJuego);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Timer tmrx2;
        private System.Windows.Forms.Timer tmrx3;
        private System.Windows.Forms.Timer tmrx5;
        private System.Windows.Forms.Label lblJugar;
    }
}

