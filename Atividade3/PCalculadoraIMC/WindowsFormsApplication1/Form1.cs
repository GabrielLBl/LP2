using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double imc, peso, altura;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxAltura.Text, out altura))
            {
                MessageBox.Show("Insira uma altura válida!");
                mskbxAltura.Focus();
            }
            else if (!double.TryParse(mskbxPeso.Text, out peso))
            {
               MessageBox.Show("Insira um peso válido!");
               mskbxPeso.Focus();
            }

            else { 
            imc = peso/(altura * altura);
            imc = Math.Round(imc, 2);
            if (imc < 18.5)
               MessageBox.Show("Seu imc é " + imc.ToString() + " ,Classificação Magreza, Grau 0");

            else if
                (imc < 24.9)
                MessageBox.Show("Seu imc é " + imc.ToString() + " ,Classificação Normal, Grau 1");

            else if
                (imc < 29.9)
                MessageBox.Show("Seu imc é " + imc.ToString() + " ,Classificação SobrePeso, Grau 2");

            else if
                (imc < 39.9)
                MessageBox.Show("Seu imc é " + imc.ToString() + " ,Classificação Obesidade, Grau 3");

            else
                MessageBox.Show("Seu imc é " + imc.ToString() + " ,Classificação Obesidade Grave, Grau 4");
            }
               
        }

        private void mskbxAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxAltura.Text, out altura))
                MessageBox.Show("Insira uma altura válida!");
        }

        private void mskbxPeso_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxPeso.Text, out peso))
                MessageBox.Show("Insira um peso válido!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAltura.Clear();
            mskbxPeso.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
