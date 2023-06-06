using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaFeedback : Form
    {
        Thread f1;
        int indexRow;
        public string teste;
        public TelaFeedback()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (box_pesquisa.Text == "")
            {

                MessageBox.Show("insira o ID da sala que deseja excluir na barra de pesquisa ou selecione na tabela o ID desejado");
            }
            else
            {
                teste = box_pesquisa.Text;
                MessageBox.Show(teste);
                f1 = new Thread(AbrirJan2);
                f1.SetApartmentState(ApartmentState.STA);
                f1.Start(teste);

            }
        }
        private void AbrirJan2(object obj)
        {
            Application.Run(new TelaEditarFeedback(teste));
        }
        private void TelaFeedback_Load(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            dtFeedBack.DataSource = conn.ObterDados("SELECT * FROM tb_feedback_software");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            dtFeedBack.DataSource = conn.ObterDados("SELECT * FROM tb_feedback_software");
        }

        private void dtFeedBack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            else
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dtFeedBack.Rows[indexRow];
                box_pesquisa.Text = row.Cells[0].Value.ToString();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (box_pesquisa.Text != "")
            {
                m_feedback mdf = new m_feedback();
                mdf.codigofeedback = Convert.ToInt32(box_pesquisa.Text);
                controller_feedback ce = new controller_feedback();
                bool resp = ce.ExcluiFeedBack(mdf);
                if (resp)
                {
                    MessageBox.Show("registro excluido com sucesso");
                    conexao conn = new conexao();
                    dtFeedBack.DataSource = conn.ObterDados("SELECT * FROM tb_feedback_software") ;
                }
                else
                {
                    MessageBox.Show("falha ao tentar excluir o registro");
                }

            }
            else
            {
                MessageBox.Show("insira o ID da sala que deseja excluir na barra de pesquisa ou selecione na tabela o ID desejado");
            }
        }
    }
}
