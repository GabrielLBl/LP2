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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCharNum_Click(object sender, EventArgs e)
        {
            int qtd = 0;
            int i;

            for (i = 0; i < richTxtBox.Text.Length; i++)
            {
                if (char.IsNumber(richTxtBox.Text[i]))
                    qtd++;
            }

            richTxtBox.Text = qtd.ToString();
        }

        private void btnFirstWhiteChar_Click(object sender, EventArgs e)
        {
            int pos = 0;

            if (!string.IsNullOrEmpty(richTxtBox.Text))
                while (!char.IsWhiteSpace(richTxtBox.Text[pos]))
                {
                    if (pos == richTxtBox.TextLength - 1)
                    {
                        pos = 0;
                        break;
                    }

                    pos++;
                }
            richTxtBox.Text = pos.ToString();
        }

        private void btnQtsCharsAlfab_Click(object sender, EventArgs e)
        {
            int qtd = 0;

            foreach (char caracter in richTxtBox.Text)
            {
                if (char.IsLetter(caracter))
                    qtd++;
            }

            richTxtBox.Text = qtd.ToString();
        }
    }
}
