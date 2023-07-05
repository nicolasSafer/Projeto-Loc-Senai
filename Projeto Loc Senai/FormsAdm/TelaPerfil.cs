using MODEL;
using CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using MySql.Data.MySqlClient;
using FontAwesome.Sharp;

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaPerfil : Form
    {
        private string id_on;

        public TelaPerfil()
        {
            
        }

        public TelaPerfil(string id_on)
        {
            this.id_on = id_on;
            InitializeComponent();
        }
conexao conn = new conexao();
        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            
            
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("select nome_funcionario,email_funcionario,id_funcao,img from tb_funcionario where id_funcionario = "+id_on+";");
              dt.Read();
            box_nome_funcionario.Text = dt.GetString(0);
            box_email_funcionario.Text = dt.GetString(1);
            box_funcao_funcionario.Text = dt.GetString(2);
            box_id_funcionario.Text = id_on;
            box_pesquisa.Text = dt.GetString(3);
            

            try
            {
                if (box_pesquisa.Text != null)
                {
                    FotoPerfil.Image = Image.FromFile(box_pesquisa.Text);
                }
                else
                {
                    box_pesquisa.Text = null;
                    FotoPerfil = null;
                }


            }
            catch
            {
               
            }


        }

        private void bordasPerfil1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog(); //
                open.Filter = "imagemfiles| *.png"; // abre o windows para escolher imagem .png
                if (open.ShowDialog() == DialogResult.OK) // se escolheu imagem
                {
                    box_pesquisa.Text = open.FileName; //esdereçamento da imagem|| usar para quardar a imagem
                    FotoPerfil.Image = Image.FromFile(open.FileName);// abre a imagem

                    MySqlConnection conexao = conn.getconexao();
                    conexao.Open();
                    string att = "UPDATE tb_funcionario set img = @img WHERE id_funcionario = "+id_on+";";
                    MySqlCommand comando_2 = new MySqlCommand(att, conexao);
                    comando_2.Parameters.AddWithValue("@id_on", id_on);
                    comando_2.Parameters.AddWithValue("@img", box_pesquisa.Text);
         

                    comando_2.CommandType = CommandType.Text;
                    comando_2.ExecuteReader();
                    MessageBox.Show("Imagem cadastrada com sucesso");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("falha ao abrir o arquivi erro" + ex.Message);
            }


           
        }
    }
}
