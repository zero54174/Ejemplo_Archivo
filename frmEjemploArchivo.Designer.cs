namespace Ejemplo_Archivo
{
    partial class frmEjemploArchivo
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
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(124, 22);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(119, 15);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "Introduzca El Archivo";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(33, 103);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(290, 23);
            this.txtEntrada.TabIndex = 1;
            this.txtEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntrada_KeyDown);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(33, 153);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(290, 224);
            this.txtSalida.TabIndex = 2;
            // 
            // frmEjemploArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 434);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblArchivo);
            this.Name = "frmEjemploArchivo";
            this.Text = "Ejemplo de Archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblArchivo;
        private TextBox txtEntrada;
        private TextBox txtSalida;
    }
}