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
        #endregion

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            E_Categorias oCa = new E_Categorias();
            oCa.Codigo_ca = 0;
            oCa.Descripcion_ca = txt_descripcion_ca.Text.Trim();
            Rpta = N_Categorias.Guardar_ca(1, oCa);
        }
    }}

