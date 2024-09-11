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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por participar!");
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            txtNome.Text = VariaveisGlobal.nome;
            txtPontos.Text = VariaveisGlobal.resultado.ToString();
            txtHora.Text = VariaveisGlobal.dataHora.ToString();
        }
    }
}
