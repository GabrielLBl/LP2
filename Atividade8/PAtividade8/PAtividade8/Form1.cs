﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio1"];
            if (fc != null)
                fc.Close();

            frmExercicio1 frm1 = new frmExercicio1();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form fc = Application.OpenForms["frmExercicio2"];
                if (fc != null)
                    fc.Close();

                frmExercicio2 frm2 = new frmExercicio2();
                frm2.MdiParent = this;
                frm2.WindowState = FormWindowState.Maximized;
                frm2.Show();
            }
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
