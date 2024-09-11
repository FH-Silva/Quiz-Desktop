using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_atividade
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (radioUm.Checked == true || radioDois.Checked == true || radioTres.Checked == true)
            {
                if (radioUm.Checked)
                {
                    VariaveisGlobal.resultado++;
                    MessageBox.Show("Parabéns, resposta correta!");
                }
                else
                {
                    MessageBox.Show("Resposta Incorreta :(");
                }

                Form12 pergunta = new Form12();
                pergunta.Show();
                this.Hide();
                pergunta.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Selecione uma resposta");
            }
        }
    }
}
