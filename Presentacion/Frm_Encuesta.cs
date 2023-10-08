using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Encuesta : Form
    {
        public Frm_Encuesta()
        {
            InitializeComponent();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            string Resultado;
            Resultado = "";

            if (chkVF.Checked == true)
            {
                //Resultado = Resultado + chkVF.Text;
                Resultado += chkVF.Text + ", ";
            }
            if (chkCsharp.Checked == true)
            {
                Resultado += chkCsharp.Text + ", ";
            }
            if (chkVBN.Checked == true)
            {
                Resultado += chkVBN.Text + ", ";
            }
            if (chkJava.Checked == true)
            {
                Resultado += chkJava.Text;
            }

            // Evaluando Proceso seleccion radiobutton
            if (rdbPresencial.Checked == true)
            {
                Resultado += " ::::: " + rdbPresencial.Text + " ::::: ";
            }
            else
            {
                Resultado += " ::::: " + rdbPresencial.Text + " ::::: ";
            }



            txtResultado.Text = Resultado;
        }
    }
}
