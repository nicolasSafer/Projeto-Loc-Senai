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
        public string data;
        public TelaDescEvento(string data)
        {
            
            this.data = data;
           // MessageBox.Show(data);
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(data);
        }

        private void TelaDescEvento_Load(object sender, EventArgs e)
        {
            m_evento me = new m_evento();
            ControllEventos controllEventos = new ControllEventos();
            // box_nome_evento.Text = controllEventos.dr.GetString(1);
            // box_data_evento.Text = me.setdata_evento();
            try
            {

                conexao conn = new conexao();

                ConsultarDados consulta = new ConsultarDados();
                //MySqlDataReader dt_evento = consulta.select("select nome_evento, local_evento, data_evento, horario_evento,descricao_evento from  tb_evento where data_evento like "+data+" %;");
                MySqlDataReader dt_evento = consulta.select("select * from tb_evento where data_evento LIKE '"+data+"%'");
                dt_evento.Read();
                if (dt_evento.Read() != null)
                {

                    box_nome_evento.Text = dt_evento.GetString(1);
                    box_local_evento.Text = dt_evento.GetString(2);
                    box_data_evento.Text = dt_evento.GetString(3);
                    box_hora_evento.Text = dt_evento.GetString(4);
                    box_desc_evento.Text = dt_evento.GetString(5);
                }
                else
                {
                    MessageBox.Show("Valores vazios");
                }



            }
            catch 
            {
                MessageBox.Show("Não possui evento neste dia");
                this.Close();
            }


        }
    }
    
}
