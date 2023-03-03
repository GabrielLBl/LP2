using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copiar Ctrl V");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Colar Ctrl C");
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio1"];
            if (fc != null)
                fc.Close();
            

            frmExercicio2 frm2 = new frmExercicio2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio3"];
            if (fc != null)
                fc.Close();


            frmExercicio3 frm3 = new frmExercicio3();
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio4"];
            if (fc != null)
                fc.Close();


            frmExercicio4 frm4 = new frmExercicio4();
            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio5"];
            if (fc != null)
                fc.Close();


            frmExercicio5 frm5 = new frmExercicio5();
            frm5.MdiParent = this;
            frm5.WindowState = FormWindowState.Maximized;
            frm5.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
