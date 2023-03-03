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
    public partial class FrmBuscadorProfesor : Form
    {
        private Profesor _profe;
        public Profesor Profe { get { return _profe; } }
        Negocio _negocio;
        public FrmBuscadorProfesor()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            _negocio = new Negocio();
        }

        private async void btnNombre_Click(object sender, EventArgs e)
        {
            if (txtBuscador.Text != String.Empty)
            {
                List<Profesor> list = await _negocio.GetProfesores();
                Profesor profesor = list.FirstOrDefault(x => x.nombre.Equals(txtBuscador.Text));
                if (profesor == null)
                {
                    MessageBox.Show("No se encontro el profesor indicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _profe = profesor;
                    this.DialogResult |= DialogResult.OK;
                    this.Close();
                }
            }  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnId_Click(object sender, EventArgs e)
        {
            if(txtBuscador.Text != String.Empty) {
                int id = Convert.ToInt32(txtBuscador.Text);
                Profesor profesor = await _negocio.ObtenerProfesorID(Convert.ToInt32(txtBuscador.Text));
                if (profesor == null)
                {
                    MessageBox.Show("No se encontro el profesor indicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _profe = profesor;
                    this.DialogResult |= DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
