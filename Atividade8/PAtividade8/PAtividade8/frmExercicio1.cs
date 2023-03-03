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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void BtnWhiteSpaces_Click(object sender, EventArgs e)
        {
            int qtd = 0;
            int i;

            for (i = 0; i < richTxtBx.Text.Length; i++)
            {
                if (char.IsWhiteSpace(richTxtBx.Text[i]))
                    qtd++;
            }

            richTxtBx.Text = qtd.ToString();
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int qtd = 0;
            int i;

            richTxtBx.Text = richTxtBx.Text.ToUpper();

            for (i = 0; i < richTxtBx.Text.Length; i++)
            {
                if (richTxtBx.Text[i] == 'R')
                    qtd++;
            }

            richTxtBx.Text = qtd.ToString();
        }

        private void btnParDeLetras_Click(object sender, EventArgs e)
        {
            int Pares = 0;
            string texto = richTxtBx.Text;

            for (int letra = 0; letra < texto.Length - 1; letra++)
            {
                if (texto[letra] == texto[letra + 1])
                    Pares++;
            }

            richTxtBx.Text = Pares.ToString();
        }
    }
}
