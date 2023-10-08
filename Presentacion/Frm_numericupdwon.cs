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
    public partial class Frm_numericupdwon : Form
    {
        public Frm_numericupdwon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DiaTexto;
            int NroDia;
            NroDia = (int)nupNdia.Value;

            switch (NroDia)
            {
                case 1:
                    DiaTexto = "Lunes";
                    break;
                case 2:
                    DiaTexto = "Martes";
                    break;
                case 3:
                    DiaTexto = "Miercoles";
                    break;
                case 4:
                    DiaTexto = "Jueves";
                    break;
                case 5:
                    DiaTexto = "Viernes";
                    break;
                case 6:
                    DiaTexto = "Sabado";
                    break;
                default:
                    DiaTexto = "Domingo";
                    break;
            }
            txtResultado.Text = DiaTexto;

        }
    }
}
