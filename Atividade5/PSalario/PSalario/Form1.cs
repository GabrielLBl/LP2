using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {

        double salario, aliqINSS, aliqIRRF, salFamilia, salLiquido;
        int filhos;
        string casado, stringfilhos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBxNome.Clear();
            mskBxSalario.Clear();
            cmbBxFilho.Text = "0";
            mskBxAliqINSS.Clear();
            mskBxAliqIRRF.Clear();
            mskBxSalFamilia.Clear();
            mskBxSalLiq.Clear();
            mskBxDescINSS.Clear();
            mskBxDescIRRF.Clear();
            lblDados.Text = "Aguardando Dados";
            chkBxCasado.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBxFilho.Text = "0";
        }


        private void txtBxNome_Validated(object sender, EventArgs e)
        {
            if (txtBxNome.Text == "")
            {
                MessageBox.Show("Nome não pode estar vazio!");
            }
        }

        private void mskBoxSalario_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskBxSalario.Text, out salario))
            {
                MessageBox.Show("Insira um salário válido!");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtBxNome.Text == "")
            {
                MessageBox.Show("Nome não pode estar vazio!");
                txtBxNome.Focus();
            }

            if (!double.TryParse(mskBxSalario.Text, out salario))
            {
                MessageBox.Show("Insira um salário válido!");
                mskBxSalario.Focus();
            }

            if (!int.TryParse(cmbBxFilho.Text, out filhos))
            {
                MessageBox.Show("Qtd de filhos vazia!");
            }

            if (salario <= 800.47)
            {
                mskBxAliqINSS.Text = "7,65%";
                aliqINSS = 0.0765 * salario;
                mskBxDescINSS.Text = aliqINSS.ToString();
            }

            else if (salario <= 1050)
            {
                mskBxAliqINSS.Text = "8,65%";
                aliqINSS = 0.0865 * salario;
                mskBxDescINSS.Text = aliqINSS.ToString();
            }

            else if (salario <= 1400.77)
            {
                mskBxAliqINSS.Text = "9,00%";
                aliqINSS = 0.0900 * salario;
                mskBxDescINSS.Text = aliqINSS.ToString();
            }

            else if (salario <= 2801.56)
            {
                mskBxAliqINSS.Text = "11,00%";
                aliqINSS = 0.1100 * salario;
                mskBxDescINSS.Text = aliqINSS.ToString();
            }

            else 
            {
                mskBxAliqINSS.Text = "Teto";
                aliqINSS = 308.17;
                mskBxDescINSS.Text = aliqINSS.ToString();
            }

            if (salario <= 1257.12)
            {
                mskBxAliqIRRF.Text = "Isento";
                aliqIRRF = 0;
                mskBxDescIRRF.Text = aliqIRRF.ToString();
            }

            else if (salario <= 2512.08)
            {
                mskBxAliqIRRF.Text = "15,00%";
                aliqIRRF = 0.1500 * salario;
                mskBxDescIRRF.Text = aliqIRRF.ToString();
            }

            else
            {
                mskBxAliqIRRF.Text = "27,5%";
                aliqIRRF = 0.275 * salario;
                mskBxDescIRRF.Text = aliqIRRF.ToString();
            }

            if (salario <= 435.52)
            {
                salFamilia = 22.33 * filhos;
                mskBxSalFamilia.Text = salFamilia.ToString();
            }

            else if (salario <= 654.61)
            {
                salFamilia = 15.74 * filhos;
                mskBxSalFamilia.Text = salFamilia.ToString();
            }

            else
            {
                salFamilia = 0 * filhos;
                mskBxSalFamilia.Text = salFamilia.ToString();
            }

            salLiquido = salario - aliqINSS - aliqIRRF + salFamilia;
            mskBxSalLiq.Text = salLiquido.ToString();

            if (chkBxCasado.Checked) 
            {
                if (rdioBtnM.Checked)
                {
                    casado = "casado";
                }

                if (rdioBtnF.Checked)
                {
                    casado = "casada";
                }

            }

            else
            {
                if (rdioBtnM.Checked)
                {
                    casado = "solteiro";
                }

                if (rdioBtnF.Checked)
                {
                    casado = "solteira";
                }

            }

            if (filhos == 0);
            {
                stringfilhos = "não possui filhos";
            }

            if (filhos == 1)
            {
                stringfilhos = "possui 1 filho";
            }

            if (filhos > 1)
            {
                stringfilhos = "possui " + cmbBxFilho.Text + " filhos";
            }


            if (rdioBtnM.Checked)
            {
                lblDados.Text = "Os descontos do salário do Sr. " + txtBxNome.Text + " que é " + casado + " e que " + stringfilhos + " são:";
            }

            else
            {
                lblDados.Text = "Os descontos do salário da Sra. " + txtBxNome.Text + " que é " + casado + " e que " + stringfilhos + " são:";
            }
        }

    }
}
