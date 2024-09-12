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

namespace Quiz_atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            VariaveisGlobal.nome = Interaction.InputBox("Como se chama?", "Insira seu nome");
            VariaveisGlobal.dataHora = DateTime.Now;

            if (VariaveisGlobal.nome == string.Empty)
            {
                MessageBox.Show("Insira seu nome, por favor");
            }
            else
            {
                MessageBox.Show("Bem-vindo(a) " + VariaveisGlobal.nome);
                Form2 pergunta = new Form2();

                pergunta.Show();
                this.Hide();
                pergunta.FormClosed += (s, args) => this.Close();
            }
        }
    }
}
