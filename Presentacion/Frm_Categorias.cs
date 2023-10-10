using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class Frm_Categorias : Form
    {
        public Frm_Categorias()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Estadoguarda = 0; //Sin ninguna accion
        int Ncodigo = 0; //Se va usar para guar el codigo del registro seleccionado
        #endregion
        #region "Mis Metodos"
        private void Formato_ca()
        {
            dgvPrincipal.Columns[0].Width = 80;
            dgvPrincipal.Columns[0].HeaderText = "Codigo";

            dgvPrincipal.Columns[1].Width = 250;
            dgvPrincipal.Columns[1].HeaderText = "Categoria"; 
        }
        private void Listado_ca(string cTexto)
        {
            dgvPrincipal.DataSource = N_Categorias.listar_ca(cTexto);
            this.Formato_ca();
        }
        private void Estado(bool lEstado)
        {
            txt_descripcion_ca.Enabled = lEstado;
            btnCancelar.Enabled = lEstado;  
            btnGuardar.Enabled = lEstado; 

            btnNuevo.Enabled = !lEstado;
            btnActualizar.Enabled = !lEstado;
            btnEliminar.Enabled = !lEstado;
            btnReporte.Enabled = !lEstado;
            btnSalir.Enabled = !lEstado;   

            txtBuscar.Enabled = !lEstado;
            btnBuscar.Enabled = !lEstado;
            dgvPrincipal.Enabled = !lEstado;
        }
        #endregion

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_descripcion_ca.Text))
            {
                MessageBox.Show("No se tiene información para ser guardada", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string Rpta = "";
                E_Categorias oCa = new E_Categorias();
                oCa.Codigo_ca = Ncodigo;
                oCa.Descripcion_ca = txt_descripcion_ca.Text.Trim();
                Rpta = N_Categorias.Guardar_ca(Estadoguarda, oCa);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_ca("%");
                    this.Estado(false);
                    txt_descripcion_ca.Text = ""; 
                    Estadoguarda = 0;
                    Ncodigo = 0;
                    MessageBox.Show("Datos guardados correctamente", "Aviso del sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_ca(txtBuscar.Text.Trim());    
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; //Nuevo Registro
            this.Estado(true); 
            txt_descripcion_ca.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Estado(false);
            txt_descripcion_ca.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar Registro
            this.Estado(true); 
        }

        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ncodigo = Convert.ToInt32(dgvPrincipal.CurrentRow.Cells["codigo_ca"].Value);
            txt_descripcion_ca.Text = Convert.ToString(dgvPrincipal.CurrentRow.Cells["descripcion_ca"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult cOpcion;
            cOpcion = MessageBox.Show("¿Estas seguro de eliminar el registro?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cOpcion == DialogResult.Yes)
            {
                string Rpta = "";
                Rpta = N_Categorias.Eliminar_ca(Ncodigo);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_ca("%");
                    txt_descripcion_ca.Text = "";
                    Ncodigo = 0;
                    MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

