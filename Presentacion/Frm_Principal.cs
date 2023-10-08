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
    public partial class Frm_Principal : Form
    {   
        //Instanciar los form del menu principal
        MiprimerForm Frm_01;
        Frm_TrackBar Frm_02;
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void miPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_01==null)
            {
                Frm_01 = new MiprimerForm();
                Frm_01.MdiParent = this;
                Frm_01.FormClosed += new FormClosedEventHandler(Alta_frm_01);
                Frm_01.Show();
            }
            
        }

        void Alta_frm_01(object sender, EventArgs e)
        {
            Frm_01 = null;
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_02 = new Frm_TrackBar();
            Frm_02.MdiParent = this;
            Frm_02.Show();
        }
    }
}
