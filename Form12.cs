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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            var jogador = (nome: "Joãozinho", pontuacao: 15, dataHora: "Hora");
            MessageBox.Show(jogador.nome);
            this.Close();
        }
    }
}
