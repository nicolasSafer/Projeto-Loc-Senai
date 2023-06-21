using CONTROL;
using MODEL;
using Projeto_Loc_Senai.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            foreach (var pic in PainelCentral.Controls.OfType<PictureBox>())
                pic.Image = pic.ErrorImage;
            switch (picture.Name)
            {
                case "picMorte": avaliacao = "Muito Ruim"; picture.Image = Resources.morto; break;
                case "picTriste": avaliacao = "Ruim"; picture.Image = Resources.triste; break;
                case "picFeliz": avaliacao = "Satisfeito"; picture.Image = Resources.feliz; break;
                case "picAmei": avaliacao = "Bom"; picture.Image = Resources.amei; break;
                case "picApaixonado": avaliacao = "Muito bom"; picture.Image = Resources.apaixonado; break;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (box_nome_usuario.Text != "" && box_obs_usuario.Text != "")
            {
                if (avaliacao != null)
                {
                    m_feedback mf = new m_feedback();
                    mf.setnome_usuario(box_nome_usuario.Text);
                    mf.setavaliacao_software(avaliacao);
                    mf.setobservacao(box_obs_usuario.Text);
                    controller_feedback cf = new controller_feedback();

                    if (cf.insertfeedback(mf) == true)
                    {
                        MessageBox.Show("Feedback enviado com sucesso. Obrigado pelo apoio!!!!!");
                    }
                    else
                    {
                        MessageBox.Show("Erro em inserir o feedback");
                    }
                }



                else
                {
                    MessageBox.Show("Selecione uma avaliação");
                }

            }
            else
            {
                MessageBox.Show("Verificar os campus nome ou descrição se estão vazios.");
            }
        }

    }
}
