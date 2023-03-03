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
    public partial class frmExercicio2 : Form
    {

        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnGerarNumeroH_Click(object sender, EventArgs e)
        {

            int i = 0;
            double h = 0;
            double numeroN;

           if (!double.TryParse(txtBxNumeroN.Text, out numeroN))
           {
               MessageBox.Show("Insira um número válido");
           }

            else if (numeroN <= 0)
            {
                MessageBox.Show("Número deve ser maior que 0");
            }

            for (i = 2; i <= numeroN; i++)
            {
                h += 1.0 / i;
            }

            MessageBox.Show(h.ToString());
            h = 0;
            i = 0;
        }
    }
}
