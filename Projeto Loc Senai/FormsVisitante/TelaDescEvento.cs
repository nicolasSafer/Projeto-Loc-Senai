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
            if (Convert.ToInt32(dia_on) <= 9)
            {
                textBox1.Text = "0" + dia_on + "/07/23";
                //dia_on_2 = textBox1.Text;
                

            }
            else
            {
                textBox1.Text = dia_on + "/07/23";
                //dia_on_2 = textBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        int indexRow;
        string dia_on_2;
        private void TelaDescEvento_Load(object sender, EventArgs e)
        {
           dia_on_2 = textBox1.Text;
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("SELECT * from tb_evento where data_evento= '"+ dia_on_2 +"';");
//int count_1 = 0;
            List<string> resultado_1 = new List<string>();

            while (dt.Read())
            {
                resultado_1.Add(dt["id_evento"].ToString());
            }

            string id_on_1 = "0";
            int count_1 = 0;

            foreach (string i in resultado_1)
            {
                if (i == null)
                {
                    id_on_1 = "0";
                }
                else
                {
                    id_on_1 = i;
                }

                switch (count_1)
                {
                    case 0:
                        evento_1.Text = id_on_1;
                        break;
                    case 1:
                        evento_2.Text = id_on_1;
                        break;
                    case 2:
                        evento_3.Text = id_on_1;
                        break;
                    case 3:
                        evento_4.Text = id_on_1;
                        break;
                    default:
                        MessageBox.Show("Nada");
                        break;
                }

                count_1++;
            }

            dt.Close();

            ConsultarDados consu2 = new ConsultarDados();
            MySqlDataReader dt1 = consu2.select("SELECT * from tb_evento where id_evento= '" + Convert.ToInt32(evento_1.Text) + "';");
            dt1.Read();
            nome_evento.Text = dt1.GetString(1);
            local_evento.Text = dt1.GetString(2);
            data_evento.Text = dt1.GetString(3);
            horario_evento.Text = dt1.GetString(4);
            descricao_evento.Text = dt1.GetString(5);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt1 = consu.select("SELECT * from tb_evento where id_evento= '" + Convert.ToInt32(evento_1.Text) + "';");
            dt1.Read();
            nome_evento.Text = dt1.GetString(1);
            local_evento.Text = dt1.GetString(2);
            data_evento.Text = dt1.GetString(3);
            horario_evento.Text = dt1.GetString(4);
            descricao_evento.Text = dt1.GetString(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(evento_2.Text != "")
            {
                ConsultarDados consu = new ConsultarDados();
                MySqlDataReader dt1 = consu.select("SELECT * from tb_evento where id_evento= '" + Convert.ToInt32(evento_2.Text) + "';");
                dt1.Read();
                nome_evento.Text = dt1.GetString(1);
                local_evento.Text = dt1.GetString(2);
                data_evento.Text = dt1.GetString(3);
                horario_evento.Text = dt1.GetString(4);
                descricao_evento.Text = dt1.GetString(5);
                
            }else
            {
                nome_evento.Text = "Sem evento";
                local_evento.Text = "Sem evento";
                data_evento.Text = "Sem evento";
                horario_evento.Text = "Sem evento";
                descricao_evento.Text = "Sem evento";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt1 = consu.select("SELECT * from tb_evento where id_evento= '" + Convert.ToInt32(evento_3.Text) + "';");
            dt1.Read();
            nome_evento.Text = dt1.GetString(1);
            local_evento.Text = dt1.GetString(2);
            data_evento.Text = dt1.GetString(3);
            horario_evento.Text = dt1.GetString(4);
            descricao_evento.Text = dt1.GetString(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt1 = consu.select("SELECT * from tb_evento where id_evento= '" + Convert.ToInt32(evento_4.Text) + "';");
            dt1.Read();
            nome_evento.Text = dt1.GetString(1);
            local_evento.Text = dt1.GetString(2);
            data_evento.Text = dt1.GetString(3);
            horario_evento.Text = dt1.GetString(4);
            descricao_evento.Text = dt1.GetString(5);
        }
    }
    }
    
    

