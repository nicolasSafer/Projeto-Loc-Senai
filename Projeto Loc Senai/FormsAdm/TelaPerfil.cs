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

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaPerfil : Form
    {
        int id;
        public TelaPerfil(int _id)
        {
            id = _id;
            InitializeComponent();
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("select * from tb_funcionario where id_funcionario = " + id);
              dt.Read();
            box_nome_funcionario.Text = dt.GetString(1);
            box_email_funcionario.Text = dt.GetString(2);
            box_funcao_funcionario.Text = dt.GetString(4);
            box_id_funcionario.Text = dt.GetString(0);
            try
            {
                box_pesquisa.Text = dt.GetString(5);
            }
            catch { 
                
            }
            

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
                //MessageBox.Show("Erro na imagem");
            }


        }

        private void bordasPerfil1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A");
        }
    }
}
