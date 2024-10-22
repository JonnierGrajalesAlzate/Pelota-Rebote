namespace procesoDeHilos
{
    partial class frmJuego
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
            this.components = new System.ComponentModel.Container();
            this.tmrUFO = new System.Windows.Forms.Timer(this.components);
            this.picUFO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrUFO
            // 
            this.tmrUFO.Tick += new System.EventHandler(this.tmrUFO_Tick);
            // 
            // picUFO
            // 
            this.picUFO.Image = global::procesoDeHilos.Properties.Resources.balon;
            this.picUFO.Location = new System.Drawing.Point(215, 138);
            this.picUFO.Name = "picUFO";
            this.picUFO.Size = new System.Drawing.Size(24, 24);
            this.picUFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUFO.TabIndex = 1;
            this.picUFO.TabStop = false;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.picUFO);
            this.Name = "frmJuego";
            this.Text = "Juego";
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picUFO;
        private System.Windows.Forms.Timer tmrUFO;
    }
}