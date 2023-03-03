using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntermodular
{
    public partial class FrmPropiedadesGuardia : Form
    {
        private Negocio _negocio;
        public Guardia guardia;
        public FrmPropiedadesGuardia()
        {
            InitializeComponent();
            guardia=new Guardia();
            _negocio=new Negocio();
            this.DialogResult = DialogResult.Cancel;

            cmbAula.SelectedIndex = 0;
            cmbDiaSemana.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            cmbGrupo.SelectedIndex = 0;
        }

        public FrmPropiedadesGuardia(Guardia guardia)
        {
            InitializeComponent();
            this.guardia = guardia;
            _negocio = new Negocio();
            tsmiAutocompletar.Visible = false;

            if (guardia.Id != 0)
            {
                
                dtpFecha.Value = guardia.Fecha;
                txtHorario.Text = guardia.Horario.ToString();
                cmbDiaSemana.SelectedIndex = guardia.DiaSemana - 1;
                txtHora.Text = guardia.Hora.ToString();
                cmbGrupo.Text = guardia.Grupo;
                switch (guardia.Estado)
                {
                    case EstadoEnum.R:
                        cmbEstado.SelectedIndex = 0;
                        break;
                    case EstadoEnum.C:
                        cmbEstado.SelectedIndex = 1;
                        break;
                    case EstadoEnum.A:
                        cmbEstado.SelectedIndex = 2;
                        break;
                }
                txtAviso.Text = guardia.Aviso.ToString();
                cmbAula.Text = guardia.Aula;
                txtObservaciones.Text = guardia.Observaciones;

                añadirProfesores(guardia.ProfesorFalta, (int)guardia.ProfesorGuardia);
            }
            else
            {
                tsmiAutocompletar.Visible = true;
                cmbAula.SelectedIndex = 0;
                cmbDiaSemana.SelectedIndex = 0;
                cmbEstado.SelectedIndex = 0;
                cmbGrupo.SelectedIndex = 0;
            }

            

        }

        private async void añadirProfesores(int idFalta,int idGuardia)
        {
            Profesor profeFalta = await _negocio.ObtenerProfesorID(idFalta);
            if (profeFalta != null)
            {
                txtProfeFalta.Text = profeFalta.nombre + ", " + profeFalta.ape1 + " " + profeFalta.ape2;
                txtProfeFalta.Tag = idFalta;
            }

            Profesor profeGuardia = await _negocio.ObtenerProfesorID(idGuardia);
            if(profeGuardia != null)
            {
                txtProfeGuardia.Text = profeGuardia.nombre + ", " + profeGuardia.ape1 + " " + profeGuardia.ape2;
                txtProfeGuardia.Tag = idGuardia;
            }
        }

        private void btnProfesorFalta_Click(object sender, EventArgs e)
        {
            FrmBuscadorProfesor frmBuscadorProfesor = new FrmBuscadorProfesor();
            frmBuscadorProfesor.ShowDialog();
            if (frmBuscadorProfesor.DialogResult == DialogResult.OK)
            {
                txtProfeFalta.Tag = frmBuscadorProfesor.Profe.id;
                txtProfeFalta.Text = frmBuscadorProfesor.Profe.nombre+", "+ frmBuscadorProfesor.Profe.ape1+" "+ frmBuscadorProfesor.Profe.ape2;
            }
        }

        private void btnProfesorGuardia_Click(object sender, EventArgs e)
        {
            FrmBuscadorProfesor frmBuscadorProfesor = new FrmBuscadorProfesor();
            frmBuscadorProfesor.ShowDialog();
            if (frmBuscadorProfesor.DialogResult == DialogResult.OK)
            {
                txtProfeGuardia.Tag = frmBuscadorProfesor.Profe.id;
                txtProfeGuardia.Text = frmBuscadorProfesor.Profe.nombre + ", " + frmBuscadorProfesor.Profe.ape1 + " " + frmBuscadorProfesor.Profe.ape2;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtProfeGuardia.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                guardia.Fecha = dtpFecha.Value;
                guardia.Horario =Convert.ToInt32( txtHorario.Text);
                guardia.DiaSemana = cmbDiaSemana.SelectedIndex + 1;
                guardia.Hora = Convert.ToInt32(txtHora.Text);
                guardia.Grupo = cmbGrupo.Text;
                switch (cmbEstado.Text)
                {
                    case "Realizada":
                        guardia.Estado = EstadoEnum.R;
                        break;
                    case "Confirmada":
                        guardia.Estado = EstadoEnum.C;
                        break;
                    case "Anulada":
                        guardia.Estado = EstadoEnum.A;
                        break;
                }
                if (txtAviso.Text != string.Empty) { 
                    guardia.Aviso =Convert.ToInt32(txtAviso.Text);
                }
                guardia.Aula = cmbAula.Text;
                guardia.Observaciones = txtObservaciones.Text;

                if (txtProfeGuardia.Text != String.Empty)
                {
                    guardia.ProfesorGuardia = (int) txtProfeGuardia.Tag;
                }
                guardia.ProfesorFalta = (int)txtProfeFalta.Tag;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar()
        {
            if (txtProfeFalta.Text == string.Empty)
            {
                MessageBox.Show("El campo Prof. falta es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnProfesorFalta.Focus();
                return false;
            }
            if (dtpFecha.Value == null)
            {
                MessageBox.Show("El campo Fecha es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpFecha.Focus();
                return false;
            }
            if (txtHorario.Text == string.Empty)
            {
                MessageBox.Show("El campo Horario es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHorario.Focus();
                return false;
            }
            if (txtHora.Text == string.Empty)
            {
                MessageBox.Show("El campo Hora es obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHora.Focus();
                return false;
            }
            return true;
        }

        private async void tsmiAutocompletar_Click(object sender, EventArgs e)
        {
            if (txtProfeFalta.Text != string.Empty && dtpFecha.Value != null && txtHora.Text != String.Empty)
            {
                Profesor profesor = await _negocio.ObtenerProfesorID((int)txtProfeFalta.Tag);
                if (profesor != null)
                {
                    List<Guardia> guardias = await _negocio.GetGuardiasProfesores(profesor);
                    if(guardias!= null)
                    {
                        Guardia guardia = guardias.FirstOrDefault(x => x.Fecha.Date == dtpFecha.Value.Date && x.Hora == Convert.ToInt32(txtHora.Text));

                        if (guardia != null)
                        {
                            txtHorario.Text = guardia.Horario.ToString();
                            cmbDiaSemana.SelectedIndex = guardia.DiaSemana - 1;
                            cmbGrupo.Text = guardia.Grupo;
                            switch (guardia.Estado)
                            {
                                case EstadoEnum.R:
                                    cmbEstado.SelectedIndex = 0;
                                    break;
                                case EstadoEnum.C:
                                    cmbEstado.SelectedIndex = 1;
                                    break;
                                case EstadoEnum.A:
                                    cmbEstado.SelectedIndex = 2;
                                    break;
                            }
                            txtAviso.Text = guardia.Aviso.ToString();
                            cmbAula.Text = guardia.Aula;
                            txtObservaciones.Text = guardia.Observaciones;
                            Profesor profeGuardia = await _negocio.ObtenerProfesorID((int)guardia.ProfesorGuardia);
                            if (profeGuardia != null)
                            {
                                txtProfeGuardia.Text = profeGuardia.nombre + ", " + profeGuardia.ape1 + " " + profeGuardia.ape2;
                                txtProfeGuardia.Tag = guardia.ProfesorGuardia;
                            }
                        }
                    }
                }
            }
        }
    }
}
