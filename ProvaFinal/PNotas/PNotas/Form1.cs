using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Realizado por Gabriel Leite Cardoso e Guilherme Kohler, prova pratica LP2
            double[,] notas = new double[4, 10];
            int i;
            int j;
            string QRespondida;
            string [] Questao = {"A", "A", "C", "D", "C", "D", "E", "D", "B", "C" };


            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    QRespondida = Interaction.InputBox((i + 1).ToString() + "º Aluno, digite a alternativa respondida da " + (j + 1).ToString() + "º questão ", "Entrada de Dados");

                    QRespondida = QRespondida.ToUpper();

                    if (QRespondida == "A" || QRespondida == "B" || QRespondida == "C" || QRespondida == "D" || QRespondida == "E" || QRespondida == " ")
                    {

                        if (QRespondida == Questao[j])
                            listNotas.Items.Add("O aluno: " + (i + 1).ToString() + " acertou questão: " + (j + 1).ToString() + " era: " + Questao[j] + " escolheu: " + QRespondida);
                        else
                            listNotas.Items.Add("O aluno: " + (i + 1).ToString() + " errou questão: " + (j + 1).ToString() + " era: " + Questao[j] + " escolheu: " + QRespondida);
                    }
                    else
                    {
                        MessageBox.Show("Apenas digite A, B, C, D ou E");
                        j--;
                    }
                }
            }
        }
    }
}
