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
    public partial class Frm_Tiempo : Form
    {
        int Contador = 0; //Inicializando variable timer

        public Frm_Tiempo()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Contador < 100)
            { 
                Contador++;
                txtContador.Text = Convert.ToString(Contador);
                //progressBar1.Value= Contador;
                progressBar1.Increment(1);
            }
            else
            {
                timer1.Stop();
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
