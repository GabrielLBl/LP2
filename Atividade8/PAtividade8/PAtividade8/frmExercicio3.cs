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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            {
                string texto = txtBx.Text;

                if (texto == string.Empty)
                    return;

                texto = texto.Replace(" ", "");
                texto = texto.ToUpper();

                string textoInvertido = new string(texto.Reverse().ToArray());

                if (texto == textoInvertido)
                {
                    MessageBox.Show("Sim");
                }
                else
                {
                    MessageBox.Show("Não");
                }
            }
        }
    }
}
