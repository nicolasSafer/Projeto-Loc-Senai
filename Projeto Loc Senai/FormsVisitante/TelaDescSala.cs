using CONTROL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Loc_Senai.FormsVisitante
{
    public partial class TelaDescSala : Form
    {
        private int id_on;

        public TelaDescSala()
        {
            
        }

        public TelaDescSala(int id_on)
        {
            
            this.id_on = id_on;
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            // Define o tamanho padrão da tela como 1000x600 pixels
            this.MaximumSize = new Size(1000, 600);
            this.MinimumSize = new Size(900, 600);
        }

        private void TelaDescSala_Load(object sender, EventArgs e)
        {
            test_id.Text = id_on.ToString();
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("select nome_sala,descricao_sala,numeracao,bloco from tb_sala_do_predio where id_sala = " + id_on + ";");
            dt.Read();
            nome_sala.Text = dt.GetString(0);
            descricao_sala.Text = dt.GetString(1);
            numeracao_sala.Text = dt.GetString(2);
            bloco_sala.Text = dt.GetString(3);
            
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
