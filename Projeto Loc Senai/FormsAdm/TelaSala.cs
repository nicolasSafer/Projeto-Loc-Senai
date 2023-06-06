using MODEL;
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
using WindowsFormsApp3;
using System.Threading;

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaSala : Form
    {
        
        public TelaSala()
        {
            InitializeComponent();
        }
        Thread f1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TelaCadastroSala f1 = new TelaCadastroSala();
            f1.ShowDialog();
        }
        private void AbrirJan(object obj)
        {
            Application.Run(new TelaEditarSala(teste));
        }
        public string teste = null;
        private void BtnAttSala_Click(object sender, EventArgs e)
        {
            if(box_pesquisa.Text == "" )
            {

                MessageBox.Show("selecione");
            }
            else
            {
                teste = box_pesquisa.Text;
                MessageBox.Show(teste);
                f1 = new Thread(AbrirJan);
                f1.SetApartmentState(ApartmentState.STA);
                f1.Start(teste);
                
            }
            
        }

        private void TelaSala_Load(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            dtSala.DataSource = conn.ObterDados("SELECT * FROM tb_sala_do_predio");
            //clicar na linha pegar a info do campo id - armazenar em uma variavel - colocar no botão editar troca de tela e levar a variavel e fazer um selecta la com essa variavel
        }
        int indexRow;
        
        private void dtSala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) { return; }
            else    
            {
               indexRow = e.RowIndex;
                DataGridViewRow row = dtSala.Rows[indexRow];
                box_pesquisa.Text = row.Cells[0].Value.ToString();
                
            }
        }

        private void dtSala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if(box_pesquisa.Text != "")
            {
                m_sala sala = new m_sala();
                sala.codigosala = Convert.ToInt32(box_pesquisa.Text);
                controller_sala control = new controller_sala();
                bool resp = control.ExcluiSala(sala);
                if(resp)
                {
                    MessageBox.Show("registro excluido com sucesso");
                    conexao conn = new conexao();
                    dtSala.DataSource = conn.ObterDados("SELECT * FROM tb_sala_do_predio");
                }
                else
                {
                    MessageBox.Show("falha ao tentar excluir o registro");
                }

            }
            else
            {
                MessageBox.Show("insira o id da sala que deseja excluir na barra de pesquisa");
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("SELECT * FROM tb_sala_do_predio ");

            DataTable dataTable = new DataTable();
            dataTable.Load(dt);

            dtSala.DataSource = dataTable;
        }
    }
}
