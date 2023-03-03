namespace ProyectoIntermodular
{
    partial class FrmContenedor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHorarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.tsmiVentanas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.tsmiVentanas;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogOut,
            this.toolStripMenuItem1,
            this.tsmiSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(180, 22);
            this.tsmiLogOut.Text = "Log Out";
            this.tsmiLogOut.Click += new System.EventHandler(this.tsmiLogOut_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(180, 22);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProfesores,
            this.tsmiHorarios,
            this.tsmiGuardias});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // tsmiProfesores
            // 
            this.tsmiProfesores.Name = "tsmiProfesores";
            this.tsmiProfesores.Size = new System.Drawing.Size(129, 22);
            this.tsmiProfesores.Text = "Profesores";
            // 
            // tsmiHorarios
            // 
            this.tsmiHorarios.Name = "tsmiHorarios";
            this.tsmiHorarios.Size = new System.Drawing.Size(129, 22);
            this.tsmiHorarios.Text = "Horarios";
            // 
            // tsmiGuardias
            // 
            this.tsmiGuardias.Name = "tsmiGuardias";
            this.tsmiGuardias.Size = new System.Drawing.Size(129, 22);
            this.tsmiGuardias.Text = "Guardias";
            this.tsmiGuardias.Click += new System.EventHandler(this.tsmiGuardias_Click);
            // 
            // tsmiVentanas
            // 
            this.tsmiVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCascada,
            this.tsmiHorizontal,
            this.tsmVertical});
            this.tsmiVentanas.Name = "tsmiVentanas";
            this.tsmiVentanas.Size = new System.Drawing.Size(66, 20);
            this.tsmiVentanas.Text = "Ventanas";
            // 
            // tsmiCascada
            // 
            this.tsmiCascada.Name = "tsmiCascada";
            this.tsmiCascada.Size = new System.Drawing.Size(129, 22);
            this.tsmiCascada.Text = "Cascada";
            this.tsmiCascada.Click += new System.EventHandler(this.tsmiCascada_Click);
            // 
            // tsmiHorizontal
            // 
            this.tsmiHorizontal.Name = "tsmiHorizontal";
            this.tsmiHorizontal.Size = new System.Drawing.Size(129, 22);
            this.tsmiHorizontal.Text = "Horizontal";
            this.tsmiHorizontal.Click += new System.EventHandler(this.tsmiHorizontal_Click);
            // 
            // tsmVertical
            // 
            this.tsmVertical.Name = "tsmVertical";
            this.tsmVertical.Size = new System.Drawing.Size(129, 22);
            this.tsmVertical.Text = "Vertical";
            this.tsmVertical.Click += new System.EventHandler(this.tsmVertical_Click);
            // 
            // FrmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmContenedor";
            this.Text = "Contenedor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfesores;
        private System.Windows.Forms.ToolStripMenuItem tsmiHorarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardias;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentanas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascada;
        private System.Windows.Forms.ToolStripMenuItem tsmiHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmVertical;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogOut;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

