using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_atividade
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por participar!");
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //Pega o horario e calcula o periodo de tempo percorrido
            VariaveisGlobal.fim = DateTime.Now;
            VariaveisGlobal.tempo = VariaveisGlobal.fim - VariaveisGlobal.inicio;
            String tempoFormatado = String.Format("{0:mm\\:ss}", VariaveisGlobal.tempo);

            //Registra os valores no bloco de notas
            StreamWriter registros = new StreamWriter("registro.txt", true);
            registros.WriteLine($"Tempo: {tempoFormatado}s => Usuário: {VariaveisGlobal.nome}, Pontos: {VariaveisGlobal.resultado}");
            registros.Close();

            //Exibe o resultado do último jogador
            txtNome.Text = VariaveisGlobal.nome;
            txtPontos.Text = VariaveisGlobal.resultado.ToString();
            txtHora.Text = tempoFormatado;
        }

        private void ranking_Click(object sender, EventArgs e)
        {
            Form13 pergunta = new Form13();
            pergunta.ShowDialog();
            pergunta.FormClosed += (s, args) => this.Close();
        }
    }
}
