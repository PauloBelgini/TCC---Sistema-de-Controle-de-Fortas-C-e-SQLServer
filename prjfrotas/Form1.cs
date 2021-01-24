using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjveterinario
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            

        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmveiculos frmvei = new frmveiculos();

            frmvei.ShowDialog();

            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre Sobre = new sobre();

            Sobre.ShowDialog();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
         

        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMotorista frmMot = new frmMotorista();

            frmMot.ShowDialog();
        }

        private void viagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViagens frmVia = new frmViagens();

            frmVia.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
