using CONTROL;
using MODEL;
using MySql.Data.MySqlClient;
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

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaEditarEvento : Form
    {
        public string teste;
        public TelaEditarEvento(string teste)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            // Define o tamanho padrão da tela como 1000x600 pixels
            this.MaximumSize = new Size(1000, 650);
            this.MinimumSize = new Size(900, 600);
            this.teste = teste;
            label7.Text = teste;
            //MessageBox.Show(teste);
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

        private void cadas_sala_Click(object sender, EventArgs e)
        {
            m_evento mue = new m_evento();
            mue.codigoevento = Convert.ToInt32(teste);

            mue.setnome_evento(box_nome_evento.Text);
            mue.setlocal_evento(box_local_evento.Text);
            mue.setdata_evento(box_data_evento.Text);
            mue.sethorario_evento(box_horario_evento.Text);
            mue.setdescricao_evento(box_descricao_evento.Text);

            ControllEventos cs = new ControllEventos();
            if (cs.updatesala(mue) == true)
            {
                MessageBox.Show("Evento alterado com Sucesso!");
                ConsultarDados consu = new ConsultarDados();
                dtEvento.DataSource = consu.ObterDados("SELECT * FROM tb_evento");
            }
            else
            {
                MessageBox.Show("Erro em alterar evento");
            }
        }
        int indexRow;
        private void TelaEditarEvento_Load(object sender, EventArgs e)
        {
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("SELECT * FROM tb_evento where id_evento = '" + teste + "'");

            DataTable dataTable = new DataTable();
            dataTable.Load(dt);
            dtEvento.DataSource = dataTable;


            DataGridViewRow row = dtEvento.Rows[indexRow];
            box_nome_evento.Text = row.Cells[1].Value.ToString();
            box_local_evento.Text = row.Cells[2].Value.ToString();
            box_data_evento.Text = row.Cells[3].Value.ToString();
            box_horario_evento.Text = row.Cells[4].Value.ToString();
            box_descricao_evento.Text = row.Cells[5].Value.ToString();

        }
    }
}
