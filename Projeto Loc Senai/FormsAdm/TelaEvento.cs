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
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaEvento : Form
    {
        public TelaEvento()
        {
            InitializeComponent();
        }

        Thread f1;
        int indexRow;
        public string teste;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TelaCadastroEvento f1 = new TelaCadastroEvento();
            f1.ShowDialog();
        }
       
        private void dtEvento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            else
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dtEvento.Rows[indexRow];
                box_pesquisa.Text = row.Cells[0].Value.ToString();
            }
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
            Application.Run(new TelaEditarEvento(teste));
        }

        private void TelaEvento_Load(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            dtEvento.DataSource = conn.ObterDados("SELECT * FROM tb_evento");
        }
        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            dtEvento.DataSource = conn.ObterDados("SELECT * FROM tb_evento");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (box_pesquisa.Text != "")
            {
                m_evento mde = new m_evento();
                mde.codigoevento = Convert.ToInt32(box_pesquisa.Text);
                ControllEventos ce = new ControllEventos();
                bool resp = ce.ExcluiEvento(mde);
                if (resp)
                {
                    MessageBox.Show("registro excluido com sucesso");
                    conexao conn = new conexao();
                    dtEvento.DataSource = conn.ObterDados("SELECT * FROM tb_evento");
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