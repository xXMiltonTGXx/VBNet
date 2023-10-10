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
        Frm_Categorias Frm_ca;
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
            else
            {
                Frm_01.Activate(); 
            }
        }

        void Alta_frm_01(object sender, EventArgs e)
        {
            Frm_01 = null;
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_02 == null)
            {
                Frm_02 = new Frm_TrackBar();
                Frm_02.MdiParent = this;
                Frm_02.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                Frm_02.Show();
            }
            else
            {
                Frm_02.Activate();
            }
           
        }

        void Alta_frm_02(object sender, EventArgs e)
        {
            Frm_02 = null;
        }

        private void m_btn01_Click(object sender, EventArgs e)
        {
            if (Frm_01 == null)
            {
                Frm_01 = new MiprimerForm();
                Frm_01.MdiParent = this;
                Frm_01.FormClosed += new FormClosedEventHandler(Alta_frm_01);
                Frm_01.Show();
            }
            else
            {
                Frm_01.Activate();
            }
        }

        private void m_btn02_Click(object sender, EventArgs e)
        {
            if (Frm_02 == null)
            {
                Frm_02 = new Frm_TrackBar();
                Frm_02.MdiParent = this;
                Frm_02.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                Frm_02.Show();
            }
            else
            {
                Frm_02.Activate();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_ca == null)
            {
                Frm_ca = new Frm_Categorias();
                Frm_ca.MdiParent = this;
                Frm_ca.FormClosed += new FormClosedEventHandler(Alta_frm_ca);
                Frm_ca.Show();
            }
            else
            {
                Frm_ca.Activate();
            }
        }
        void Alta_frm_ca(object sender, EventArgs e)
        {
            Frm_ca = null;
        }

        
    }
}
