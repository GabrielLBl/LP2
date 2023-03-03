using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        double ValorA, ValorB, ValorC;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(mskBxValorA.Text, out ValorA) || (ValorA == 0))
            {
                MessageBox.Show("Valor A Inválido!");
                mskBxValorA.Focus();
            }
            else if (!double.TryParse(mskBxValorB.Text, out ValorB) || (ValorB == 0))
            {
                MessageBox.Show("Valor B Inválido!");
                mskBxValorB.Focus();
            }
            else if (!double.TryParse(mskBxValorC.Text, out ValorC) || (ValorC == 0))
            {
                MessageBox.Show("Valor C Inválido!");
                mskBxValorC.Focus();
            }
            else
            {
                if ((ValorA < (ValorB + ValorC)) &&
                    (ValorA > Math.Abs(ValorB - ValorC) &&
                    (ValorB < (ValorA + ValorC)) &&
                    (ValorB > Math.Abs(ValorA - ValorC)) &&
                    (ValorC < (ValorA + ValorB)) &&
                    ValorC > Math.Abs(ValorA - ValorB)))

                    if ((ValorA == ValorB) && (ValorB == ValorC))
                        MessageBox.Show("Equilátero");
                    else if ((ValorA == ValorB) || (ValorB == ValorC) || (ValorA == ValorC))
                        MessageBox.Show("Isósceles");
                    else
                        MessageBox.Show("Escaleno");
            }
        }


        private void mskBxValorA_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskBxValorA.Text, out ValorA))
                MessageBox.Show("Valor A Inválido!");
        }

        private void mskBxValorB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskBxValorB.Text, out ValorB))
                MessageBox.Show("Valor B Inválido!");
        }

        private void mskBxValorC_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskBxValorC.Text, out ValorC))
                MessageBox.Show("Valor C Inválido!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskBxValorA.Clear();
            mskBxValorB.Clear();
            mskBxValorC.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
