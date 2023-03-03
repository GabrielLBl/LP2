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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random sorteado = new Random();
            int numero1;
            int numero2;

            if (!int.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Insira um número na caixa 1");
            }
            else if (!int.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Insira um número na caixa 2");
            }
            if (int.Parse(txtNumero1.Text) <= int.Parse(txtNumero2.Text))
            {
                numero1 = int.Parse(txtNumero1.Text);
                numero2 = int.Parse(txtNumero2.Text);
            }
            else
            {
                numero1 = int.Parse(txtNumero2.Text);
                numero2 = int.Parse(txtNumero1.Text);
            }
                txtSorteio.Text = sorteado.Next(numero1, numero2).ToString();
        }
    }
}
