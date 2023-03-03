using System;
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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int B, C, D;

            if (double.TryParse(txtBxSal.Text, out double salario) && double.TryParse(txtBxProduc.Text, out double producao) && double.TryParse(txtBxGratific.Text, out double gratificacao))
            {
                if (producao >= 100)
                    B = 1;
                else
                    B = 0;

                if (producao >= 120)
                    C = 1;
                else
                    C = 0;
                if (producao >= 150)
                    D = 1;
                else
                    D = 0;

                double salarioBruto = salario + salario * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

                if (salarioBruto > 7000 && (producao < 150 || gratificacao == 0))
                    salarioBruto = 7000;

                txtBxSalBruto.Text = salarioBruto.ToString("N2");
            }
            else
            {
                MessageBox.Show("Preencha todos os valores!");
            }
        }
    }
}
