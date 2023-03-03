namespace ProyectoIntermodular
{
    partial class FrmBuscadorProfesor
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
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(12, 12);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(237, 20);
            this.txtBuscador.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 38);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(93, 38);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(75, 23);
            this.btnNombre.TabIndex = 5;
            this.btnNombre.Text = "Por Nombre";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnId
            // 
            this.btnId.Location = new System.Drawing.Point(12, 38);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(75, 23);
            this.btnId.TabIndex = 4;
            this.btnId.Text = "Por Id";
            this.btnId.UseVisualStyleBackColor = true;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // FrmBuscadorProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 66);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.btnId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmBuscadorProfesor";
            this.Text = "Buscador Profesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnId;
    }
}