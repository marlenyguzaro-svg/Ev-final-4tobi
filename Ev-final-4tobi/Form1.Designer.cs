namespace Ev_final_4tobi
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
            this.textusuario = new System.Windows.Forms.TextBox();
            this.Textcontraseña = new System.Windows.Forms.TextBox();
            this.Btnlgresar = new System.Windows.Forms.Button();
            this.LBL1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textusuario
            // 
            this.textusuario.Location = new System.Drawing.Point(359, 13);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(100, 22);
            this.textusuario.TabIndex = 0;
            this.textusuario.TextChanged += new System.EventHandler(this.textusuario_TextChanged);
            // 
            // Textcontraseña
            // 
            this.Textcontraseña.Location = new System.Drawing.Point(386, 89);
            this.Textcontraseña.Name = "Textcontraseña";
            this.Textcontraseña.Size = new System.Drawing.Size(100, 22);
            this.Textcontraseña.TabIndex = 1;
            // 
            // Btnlgresar
            // 
            this.Btnlgresar.Location = new System.Drawing.Point(386, 141);
            this.Btnlgresar.Name = "Btnlgresar";
            this.Btnlgresar.Size = new System.Drawing.Size(75, 23);
            this.Btnlgresar.TabIndex = 2;
            this.Btnlgresar.Text = "Ingresar";
            this.Btnlgresar.UseVisualStyleBackColor = true;
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(399, 202);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(88, 16);
            this.LBL1.TabIndex = 3;
            this.LBL1.Text = "Examen Final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.Btnlgresar);
            this.Controls.Add(this.Textcontraseña);
            this.Controls.Add(this.textusuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox Textcontraseña;
        private System.Windows.Forms.Button Btnlgresar;
        private System.Windows.Forms.Label LBL1;
    }
}

