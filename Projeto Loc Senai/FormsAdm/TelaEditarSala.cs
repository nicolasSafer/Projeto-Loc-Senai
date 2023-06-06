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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaEditarSala : Form
    {
        public string teste;
        public TelaEditarSala(string id)
        {
            teste = id;
            InitializeComponent();
            label5.Text = teste;
            //Desativa barra superior padrão do Windows
            this.Text = string.Empty;
            this.ControlBox = false;
            // Define o tamanho padrão da tela como 1000x600 pixels
            this.MaximumSize = new Size(1000, 650);
            this.MinimumSize = new Size(900, 600);
        }

        //Comando para responsividade da tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void cadas_sala_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void cadas_sala_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DSKFOASDFKOSA");
            
        }
        int indexRow;

        private void TelaEditarSala_Load(object sender, EventArgs e)
        {
            
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("SELECT * FROM tb_sala_do_predio where id_sala = '"+ teste + "'");

            DataTable dataTable = new DataTable();
            dataTable.Load(dt);

            dtSala.DataSource = dataTable;

            
            DataGridViewRow row = dtSala.Rows[indexRow];
            box_nome_sala.Text = row.Cells[1].Value.ToString();
            descricao_sala.Text = row.Cells[2].Value.ToString();
            box_numeracao.Text = row.Cells[3].Value.ToString();
            box_bloco.Text = row.Cells[4].Value.ToString();
            //MessageBox.Show(dt.GetString(0));

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                m_sala ums = new m_sala();
                ums.codigosala = Convert.ToInt32(teste);

                ums.setnome_sala(box_nome_sala.Text);
                ums.setnumeracao_sala(box_numeracao.Text);
                ums.setbloco_sala(descricao_sala.Text);
                ums.setdescricao_sala(box_bloco.Text);

                controller_sala cs = new controller_sala();
                if (cs.updatesala(ums) == true)
                {
                    MessageBox.Show("Deu boa");
                }
                else
                {
                    MessageBox.Show("Não deu boa");
                }
            }
            catch (Exception ex)
            {

               MessageBox.Show("Erro" + ex);
            }
            
        }
    }
}
