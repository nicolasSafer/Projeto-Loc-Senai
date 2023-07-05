using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROL;
using MODEL;
using MySql.Data.MySqlClient;
using WindowsFormsApp3;

namespace Projeto_Loc_Senai.FormsVisitante
{
    public partial class TelaDescEvento : Form
    {
        
        private string dia_on;

        public TelaDescEvento()
        {
            
           
            
          
        }

        public TelaDescEvento(string dia_on)
        {
            this.dia_on = dia_on;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TelaDescEvento_Load(object sender, EventArgs e)
        {
            textBox1.Text = dia_on;
            conexao conn = new conexao();
            dtEvento.DataSource = conn.ObterDados("SELECT horario_evento, nome_evento, local_evento from tb_evento where data_evento = '"+dia_on+"/06/23';");

        }
    }
    
}
