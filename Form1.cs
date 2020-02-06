using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.I_Local
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void servidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServidores objform_servidores = new frmServidores();
            objform_servidores.MdiParent = this;
            objform_servidores.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void satToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSAT objform_sat = new frmSAT();
            objform_sat.MdiParent = this;
            objform_sat.Show();
        }

        private void pontosDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPDV objform_pdv = new frmPDV();
            objform_pdv.MdiParent = this;
            objform_pdv.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Daniel O. Cirillo");
        }

        private void organizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
