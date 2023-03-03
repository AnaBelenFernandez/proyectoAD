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
    public partial class FrmContenedor : Form
    {
        public FrmContenedor()
        {
            InitializeComponent();
            this.DialogResult= DialogResult.Cancel;
        }

        private void tsmiLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Close();
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsmiGuardias_Click(object sender, EventArgs e)
        {
            FrmGestionGuardias hija = new FrmGestionGuardias();
            hija.MdiParent = this;
            hija.Show();
        }
    }
}
