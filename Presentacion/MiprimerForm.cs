using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MiprimerForm : Form
    {
        public MiprimerForm()
        {
            InitializeComponent();
        }

        // inicio variables
        int NestadoGuarda = 0;
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 1; //Nuevo Registro
            list_mantenimiento.Enabled = false;

            txtCodigo.Text = "";
            txtDescripcion.Text = "";

            GrbMantenimiento.Enabled = true;
            txtCodigo.Enabled = true; 
            //inhabilitar btn
            grbBotonesPrincipal.Enabled = false;
            //txtCodigo.Select();   para enviar cursor a un objeto
            txtCodigo.Focus();

           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            GrbMantenimiento.Enabled = false;

            //habilitar btn
            grbBotonesPrincipal.Enabled = true;

            list_mantenimiento.Enabled = true;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            String Registro;
            Registro = txtCodigo.Text.Trim() + " |  " + txtDescripcion.Text.Trim();

            if(NestadoGuarda == 1) //Nuevo Registro
            {
                list_mantenimiento.Items.Add(Registro);
            }
            else //Actualizar Registro
            {
                int ElementoSeleccionado = list_mantenimiento.SelectedIndex;

                list_mantenimiento.Items.Remove(list_mantenimiento.SelectedItem);
                list_mantenimiento.Items.Insert(ElementoSeleccionado, Registro);
            }

            MessageBox.Show("Datos guardados","Mensaje");

            txtCodigo.Text = "";
            txtDescripcion.Text = "";

            GrbMantenimiento.Enabled = false;

            grbBotonesPrincipal.Enabled = true;

            list_mantenimiento.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            list_mantenimiento.Items.Remove(list_mantenimiento.SelectedItem);
            MessageBox.Show("Elemento Eliminado", "Mensaje");

        }

        private void list_mantenimiento_Click(object sender, EventArgs e)
        {
            string TextoSeleccionado;
            int LongitudTexto;
            TextoSeleccionado = this.list_mantenimiento.SelectedItem.ToString().Trim();
            LongitudTexto = TextoSeleccionado.Length;
            txtCodigo.Text = TextoSeleccionado.Substring(0, 3);
            txtDescripcion.Text = TextoSeleccionado.Substring(6, LongitudTexto-6);

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 2; //Actualiza Registro
            list_mantenimiento.Enabled = false;

            GrbMantenimiento.Enabled = true;
            txtCodigo.Enabled = false;
            //inhabilitar btn
            grbBotonesPrincipal.Enabled = false; 
            txtCodigo.Focus();
        }
    }
}
