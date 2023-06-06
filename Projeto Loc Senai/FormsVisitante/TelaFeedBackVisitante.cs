using CONTROL;
using MODEL;
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
    public partial class TelaFeedBackVisitante : Form
    {
        string avaliacao;
        public TelaFeedBackVisitante()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            avaliacao = "Muito Ruim";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            avaliacao = "Ruim";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            avaliacao = "Satisfeito";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            avaliacao = "Bom";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            avaliacao = "Muito bom";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(box_nome_usuario.Text != "") 
            { 
                if (avaliacao != "")
                 {
                    if (box_obs_usuario.Text != "") 
                    {

                         m_feedback mf = new m_feedback();
                          mf.setnome_usuario(box_nome_usuario.Text);
                          mf.setavaliacao_software(avaliacao);
                          mf.setobservacao(box_obs_usuario.Text);
                         controller_feedback cf = new controller_feedback();

                             if (cf.insertfeedback(mf) == true)
                             {
                                 MessageBox.Show("Feedback enviado com sucesso. Obriago pelo apoio!!!!!");
                             }
                             else
                             {
                                MessageBox.Show("Erro em inserir o feedback");
                             }
                    }
                    else
                    {
                        MessageBox.Show("Favor inserir uma observação");
                    }
                }
                else
                {
                 MessageBox.Show("Favor selecionar uma avalição do software. (Ruim, Boa, Muito Bom)");
                }
            }
            else
            {
                MessageBox.Show("Favor inserir o seu nome");
            }
        }
    }
}
