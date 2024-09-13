using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz_atividade
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void listRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            StreamReader registros = new StreamReader("registro.txt");

            while (registros.EndOfStream == false)
            {
                //Lê o que está em registro.txt
                listRank.Items.Add(registros.ReadLine());
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
