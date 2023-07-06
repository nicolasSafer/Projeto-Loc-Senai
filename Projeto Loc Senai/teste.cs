using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Loc_Senai
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesquisaSala pesquisa = new PesquisaSala();
            IEnumerable<m_sala> salas = pesquisa.Pesquisar("a%");
            foreach(m_sala sala in salas){
                string teste = sala.Getnome_sala();
                MessageBox.Show(teste.ToString());
            }

        }
    }
}
