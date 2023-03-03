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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnTestarIguais_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtBxTexto1.Text, txtBxTexto2.Text, true) == 0)
            {
                MessageBox.Show("São iguais");
            }

            else
            {
                MessageBox.Show("São diferentes");
            }
        }

        private void btnInserir1no2_Click(object sender, EventArgs e)
        {
            int meio = txtBxTexto2.TextLength / 2;

            txtBxTexto2.Text = txtBxTexto2.Text.Substring(0, meio) +
                txtBxTexto1.Text +
                txtBxTexto2.Text.Substring(meio,
                txtBxTexto2.Text.Length - meio);
        }

        private void btnInserirAsteriscos_Click(object sender, EventArgs e)
        {
            int meio = txtBxTexto1.Text.Length / 2;
            txtBxTexto1.Text = txtBxTexto1.Text.Insert(meio, "**");
        }


    }
}
