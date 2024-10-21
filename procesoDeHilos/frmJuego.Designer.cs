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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.picUFO = new System.Windows.Forms.PictureBox();
            this.tmrUFO = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciar.Location = new System.Drawing.Point(235, 13);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 28);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Comenzar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // picUFO
            // 
            this.picUFO.Image = global::procesoDeHilos.Properties.Resources.balon;
            this.picUFO.Location = new System.Drawing.Point(140, 165);
            this.picUFO.Margin = new System.Windows.Forms.Padding(4);
            this.picUFO.Name = "picUFO";
            this.picUFO.Size = new System.Drawing.Size(24, 24);
            this.picUFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUFO.TabIndex = 1;
            this.picUFO.TabStop = false;
            // 
            // tmrUFO
            // 
            this.tmrUFO.Tick += new System.EventHandler(this.tmrUFO_Tick);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 469);
            this.Controls.Add(this.picUFO);
            this.Controls.Add(this.btnIniciar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmJuego";
            this.Text = "fmrWinMode";
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox picUFO;
        private System.Windows.Forms.Timer tmrUFO;
    }
}