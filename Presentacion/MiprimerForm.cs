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
    public partial class MiprimerForm : Form
    {
        public MiprimerForm()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            //txtCodigo.Select();   para enviar cursor a un objeto
            txtCodigo.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void MiprimerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
