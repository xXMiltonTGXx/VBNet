using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_trabajandoCombobox : Form
    {
        public Frm_trabajandoCombobox()
        {
            InitializeComponent();
        }

        private void cbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResultado.Text = "Curso Seleccionado: " + cbCursos.SelectedItem + " y se encuentra en la posición " + cbCursos.SelectedIndex;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cbCursos.Items.Add(txtNuevo.Text);
            txtNuevo.Text = "";
            MessageBox.Show("Curso Registrado","titulo");
        }
 
    }
}
