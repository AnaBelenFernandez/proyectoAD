namespace ProyectoIntermodular
{
    partial class FrmGestionGuardias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionGuardias));
            this.lvwGuardias = new System.Windows.Forms.ListView();
            this.profFalta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profGuardia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diaSemana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.observaciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCrearContextual = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVer = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRealizado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfirmada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAnulado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsContextual.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwGuardias
            // 
            this.lvwGuardias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.profFalta,
            this.profGuardia,
            this.estado,
            this.fecha,
            this.diaSemana,
            this.hora,
            this.grupo,
            this.aula,
            this.observaciones});
            this.lvwGuardias.ContextMenuStrip = this.cmsContextual;
            this.lvwGuardias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwGuardias.FullRowSelect = true;
            this.lvwGuardias.GridLines = true;
            this.lvwGuardias.HideSelection = false;
            this.lvwGuardias.Location = new System.Drawing.Point(0, 49);
            this.lvwGuardias.MultiSelect = false;
            this.lvwGuardias.Name = "lvwGuardias";
            this.lvwGuardias.Size = new System.Drawing.Size(1338, 401);
            this.lvwGuardias.TabIndex = 5;
            this.lvwGuardias.UseCompatibleStateImageBehavior = false;
            this.lvwGuardias.View = System.Windows.Forms.View.Details;
            this.lvwGuardias.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwGuardias_MouseDoubleClick);
            // 
            // profFalta
            // 
            this.profFalta.Text = "ProfFalta";
            this.profFalta.Width = 142;
            // 
            // profGuardia
            // 
            this.profGuardia.Text = "ProfGuardia";
            this.profGuardia.Width = 152;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 86;
            // 
            // fecha
            // 
            this.fecha.Text = "Fecha";
            this.fecha.Width = 117;
            // 
            // diaSemana
            // 
            this.diaSemana.Text = "DiaSemana";
            this.diaSemana.Width = 101;
            // 
            // hora
            // 
            this.hora.Text = "Hora";
            this.hora.Width = 106;
            // 
            // grupo
            // 
            this.grupo.Text = "Grupo";
            this.grupo.Width = 89;
            // 
            // aula
            // 
            this.aula.Text = "Aula";
            this.aula.Width = 93;
            // 
            // observaciones
            // 
            this.observaciones.Text = "Observaciones";
            this.observaciones.Width = 248;
            // 
            // cmsContextual
            // 
            this.cmsContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrearContextual,
            this.tsmiVer,
            this.TsmiBorrar,
            this.cambiarEstadoToolStripMenuItem});
            this.cmsContextual.Name = "cmsContextual";
            this.cmsContextual.Size = new System.Drawing.Size(158, 92);
            this.cmsContextual.Opening += new System.ComponentModel.CancelEventHandler(this.cmsContextual_Opening);
            // 
            // tsmiCrearContextual
            // 
            this.tsmiCrearContextual.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCrearContextual.Image")));
            this.tsmiCrearContextual.Name = "tsmiCrearContextual";
            this.tsmiCrearContextual.Size = new System.Drawing.Size(157, 22);
            this.tsmiCrearContextual.Text = "Crear";
            this.tsmiCrearContextual.Click += new System.EventHandler(this.tsmiCrear_Click);
            // 
            // tsmiVer
            // 
            this.tsmiVer.Image = ((System.Drawing.Image)(resources.GetObject("tsmiVer.Image")));
            this.tsmiVer.Name = "tsmiVer";
            this.tsmiVer.Size = new System.Drawing.Size(157, 22);
            this.tsmiVer.Text = "Ver";
            this.tsmiVer.Click += new System.EventHandler(this.tsmiVer_Click);
            // 
            // TsmiBorrar
            // 
            this.TsmiBorrar.Image = ((System.Drawing.Image)(resources.GetObject("TsmiBorrar.Image")));
            this.TsmiBorrar.Name = "TsmiBorrar";
            this.TsmiBorrar.Size = new System.Drawing.Size(157, 22);
            this.TsmiBorrar.Text = "Borrar";
            this.TsmiBorrar.Click += new System.EventHandler(this.TsmiBorrar_Click);
            // 
            // cambiarEstadoToolStripMenuItem
            // 
            this.cambiarEstadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRealizado,
            this.tsmiConfirmada,
            this.tsmiAnulado});
            this.cambiarEstadoToolStripMenuItem.Name = "cambiarEstadoToolStripMenuItem";
            this.cambiarEstadoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cambiarEstadoToolStripMenuItem.Text = "Cambiar estado";
            // 
            // tsmiRealizado
            // 
            this.tsmiRealizado.Name = "tsmiRealizado";
            this.tsmiRealizado.Size = new System.Drawing.Size(202, 22);
            this.tsmiRealizado.Text = "Realizado";
            this.tsmiRealizado.Click += new System.EventHandler(this.tsmiRealizado_Click);
            // 
            // tsmiConfirmada
            // 
            this.tsmiConfirmada.Name = "tsmiConfirmada";
            this.tsmiConfirmada.Size = new System.Drawing.Size(202, 22);
            this.tsmiConfirmada.Text = "Confirmada y pendiente";
            this.tsmiConfirmada.Click += new System.EventHandler(this.tsmiConfirmada_Click);
            // 
            // tsmiAnulado
            // 
            this.tsmiAnulado.Name = "tsmiAnulado";
            this.tsmiAnulado.Size = new System.Drawing.Size(202, 22);
            this.tsmiAnulado.Text = "Anulado";
            this.tsmiAnulado.Click += new System.EventHandler(this.tsmiAnulado_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtFiltrar,
            this.btnFiltrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(1338, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 25);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(23, 22);
            this.btnFiltrar.Text = "toolStripButton1";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrear});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsmiCrear
            // 
            this.tsmiCrear.Name = "tsmiCrear";
            this.tsmiCrear.Size = new System.Drawing.Size(180, 22);
            this.tsmiCrear.Text = "Crear";
            this.tsmiCrear.Click += new System.EventHandler(this.tsmiCrear_Click);
            // 
            // FrmGestionGuardias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 450);
            this.Controls.Add(this.lvwGuardias);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmGestionGuardias";
            this.Text = "Gestion de Guardias";
            this.cmsContextual.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwGuardias;
        private System.Windows.Forms.ColumnHeader profFalta;
        private System.Windows.Forms.ColumnHeader profGuardia;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader diaSemana;
        private System.Windows.Forms.ColumnHeader hora;
        private System.Windows.Forms.ColumnHeader grupo;
        private System.Windows.Forms.ColumnHeader aula;
        private System.Windows.Forms.ColumnHeader observaciones;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.ToolStripButton btnFiltrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrear;
        private System.Windows.Forms.ContextMenuStrip cmsContextual;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrearContextual;
        private System.Windows.Forms.ToolStripMenuItem tsmiVer;
        private System.Windows.Forms.ToolStripMenuItem TsmiBorrar;
        private System.Windows.Forms.ToolStripMenuItem cambiarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRealizado;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfirmada;
        private System.Windows.Forms.ToolStripMenuItem tsmiAnulado;
    }
}