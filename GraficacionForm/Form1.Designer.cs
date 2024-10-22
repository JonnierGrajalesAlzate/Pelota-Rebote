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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnJuego = new System.Windows.Forms.Button();
            this.lblJugar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJuego
            // 
            this.btnJuego.Location = new System.Drawing.Point(138, 152);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(120, 47);
            this.btnJuego.TabIndex = 4;
            this.btnJuego.Text = "Juego";
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // lblJugar
            // 
            this.lblJugar.AutoSize = true;
            this.lblJugar.Location = new System.Drawing.Point(156, 152);
            this.lblJugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJugar.Name = "lblJugar";
            this.lblJugar.Size = new System.Drawing.Size(0, 13);
            this.lblJugar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(411, 287);
            this.Controls.Add(this.lblJugar);
            this.Controls.Add(this.btnJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Inicio App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Label lblJugar;
    }
}

