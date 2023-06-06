using MODEL;
using CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaEditarFeedback : Form
    {
        public string teste;
        conexao conn = new conexao();
        int indexRow;
        public TelaEditarFeedback(string teste)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            // Define o tamanho padrão da tela como 1000x600 pixels
            this.MaximumSize = new Size(1000, 650);
            this.MinimumSize = new Size(900, 600);
            this.teste = teste;
        }

        //Comando para responsividade da tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PainelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TelaEditarFeedback_Load(object sender, EventArgs e)
        {

            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("SELECT * FROM tb_feedback_software where id_feedback = '" + teste + "'");

            DataTable dataTable = new DataTable();
            dataTable.Load(dt);
            dtFeedBack.DataSource = dataTable;


            DataGridViewRow row = dtFeedBack.Rows[indexRow];
            box_nome_usuario.Text = row.Cells[3].Value.ToString();
            box_avaliacao_software.Text = row.Cells[1].Value.ToString();
            box_observacao_software.Text = row.Cells[2].Value.ToString();
           
        }

        private void cadas_sala_Click(object sender, EventArgs e)
        {
            m_feedback muf = new m_feedback();
            muf.codigofeedback = Convert.ToInt32(teste);
            muf.setavaliacao_software(box_avaliacao_software.Text);
            muf.setobservavoes(box_observacao_software.Text);
            muf.setnome_usuario(box_nome_usuario.Text);
            controller_feedback cf = new controller_feedback();
            if (cf.updatesala(muf) == true)
            {
                MessageBox.Show("Evento alterado com Sucesso!");
                ConsultarDados consu = new ConsultarDados();
                dtFeedBack.DataSource = consu.ObterDados("SELECT * FROM tb_feedback_software where id_feedback= '"+ teste +"'");
            }
            else
            {
                MessageBox.Show("Erro em alterar evento");
            }
        }

    }
}
