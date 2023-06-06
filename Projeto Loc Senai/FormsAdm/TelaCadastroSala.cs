using CONTROL;
using MODEL;
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
    public partial class TelaCadastroSala : Form
    {
        public TelaCadastroSala()
        {
            InitializeComponent();
            //Desativa barra superior padrão do Windows
            this.Text = string.Empty;
            this.ControlBox = false;
            // Define o tamanho padrão da tela como 900x600 pixels
            this.MaximumSize = new Size(900, 600);
            this.MinimumSize = new Size(700, 575);
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

        //Movimentação da tela
        private void PainelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cadas_sala_Click(object sender, EventArgs e)
        {

            m_sala sl = new m_sala();

            sl.setnome_sala(box_nome_sala.Text);
            sl.setdescricao_sala(descricao_sala.Text);
            sl.setnumeracao_sala(box_numeracao.Text);
            sl.setbloco_sala(box_bloco.Text);
                               

            controller_sala cs = new controller_sala();

            if (cs.insertsala(sl) == true )
            {
                MessageBox.Show("foi");
            }
            else
            {
                MessageBox.Show("Não foi");
            }

        }
    }
}
