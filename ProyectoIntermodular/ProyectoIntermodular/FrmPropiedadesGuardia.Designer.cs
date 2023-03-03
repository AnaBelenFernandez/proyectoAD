namespace ProyectoIntermodular
{
    partial class FrmPropiedadesGuardia
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
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDiaSemana = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtProfeGuardia = new System.Windows.Forms.TextBox();
            this.txtProfeFalta = new System.Windows.Forms.TextBox();
            this.btnProfesorGuardia = new System.Windows.Forms.Button();
            this.btnProfesorFalta = new System.Windows.Forms.Button();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAutocompletar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cmbAula = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAviso
            // 
            this.txtAviso.Location = new System.Drawing.Point(55, 108);
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(121, 20);
            this.txtAviso.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Aula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Aviso";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Realizada",
            "Confirmada",
            "Anulada"});
            this.cmbEstado.Location = new System.Drawing.Point(414, 65);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Estado";
            // 
            // cmbDiaSemana
            // 
            this.cmbDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaSemana.FormattingEnabled = true;
            this.cmbDiaSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.cmbDiaSemana.Location = new System.Drawing.Point(414, 26);
            this.cmbDiaSemana.Name = "cmbDiaSemana";
            this.cmbDiaSemana.Size = new System.Drawing.Size(121, 21);
            this.cmbDiaSemana.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Dia";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(238, 27);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(121, 20);
            this.txtHorario.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Horario";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(15, 224);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(517, 71);
            this.txtObservaciones.TabIndex = 54;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(414, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtProfeGuardia
            // 
            this.txtProfeGuardia.Enabled = false;
            this.txtProfeGuardia.Location = new System.Drawing.Point(111, 169);
            this.txtProfeGuardia.Name = "txtProfeGuardia";
            this.txtProfeGuardia.Size = new System.Drawing.Size(293, 20);
            this.txtProfeGuardia.TabIndex = 52;
            // 
            // txtProfeFalta
            // 
            this.txtProfeFalta.Enabled = false;
            this.txtProfeFalta.Location = new System.Drawing.Point(111, 137);
            this.txtProfeFalta.Name = "txtProfeFalta";
            this.txtProfeFalta.Size = new System.Drawing.Size(293, 20);
            this.txtProfeFalta.TabIndex = 51;
            // 
            // btnProfesorGuardia
            // 
            this.btnProfesorGuardia.Location = new System.Drawing.Point(15, 166);
            this.btnProfesorGuardia.Name = "btnProfesorGuardia";
            this.btnProfesorGuardia.Size = new System.Drawing.Size(90, 23);
            this.btnProfesorGuardia.TabIndex = 50;
            this.btnProfesorGuardia.Text = "Prof. Guardia";
            this.btnProfesorGuardia.UseVisualStyleBackColor = true;
            this.btnProfesorGuardia.Click += new System.EventHandler(this.btnProfesorGuardia_Click);
            // 
            // btnProfesorFalta
            // 
            this.btnProfesorFalta.Location = new System.Drawing.Point(15, 137);
            this.btnProfesorFalta.Name = "btnProfesorFalta";
            this.btnProfesorFalta.Size = new System.Drawing.Size(90, 23);
            this.btnProfesorFalta.TabIndex = 49;
            this.btnProfesorFalta.Text = "Prof. falta";
            this.btnProfesorFalta.UseVisualStyleBackColor = true;
            this.btnProfesorFalta.Click += new System.EventHandler(this.btnProfesorFalta_Click);
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "ESO1A",
            "ESO1B",
            "ESO2A",
            "DAM2"});
            this.cmbGrupo.Location = new System.Drawing.Point(238, 65);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupo.TabIndex = 48;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(55, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Observaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Fecha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(457, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(376, 301);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutocompletar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 24);
            this.menuStrip1.TabIndex = 65;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAutocompletar
            // 
            this.tsmiAutocompletar.Name = "tsmiAutocompletar";
            this.tsmiAutocompletar.Size = new System.Drawing.Size(99, 20);
            this.tsmiAutocompletar.Text = "Autocompletar";
            this.tsmiAutocompletar.Click += new System.EventHandler(this.tsmiAutocompletar_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(55, 65);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(121, 20);
            this.txtHora.TabIndex = 66;
            // 
            // cmbAula
            // 
            this.cmbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAula.FormattingEnabled = true;
            this.cmbAula.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "TIC_ESO",
            "IF02"});
            this.cmbAula.Location = new System.Drawing.Point(238, 107);
            this.cmbAula.Name = "cmbAula";
            this.cmbAula.Size = new System.Drawing.Size(121, 21);
            this.cmbAula.TabIndex = 67;
            // 
            // FrmPropiedadesGuardia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 331);
            this.Controls.Add(this.cmbAula);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtAviso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDiaSemana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtProfeGuardia);
            this.Controls.Add(this.txtProfeFalta);
            this.Controls.Add(this.btnProfesorGuardia);
            this.Controls.Add(this.btnProfesorFalta);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPropiedadesGuardia";
            this.Text = "Propiedades de Guardias";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAviso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDiaSemana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtProfeGuardia;
        private System.Windows.Forms.TextBox txtProfeFalta;
        private System.Windows.Forms.Button btnProfesorGuardia;
        private System.Windows.Forms.Button btnProfesorFalta;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutocompletar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.ComboBox cmbAula;
    }
}