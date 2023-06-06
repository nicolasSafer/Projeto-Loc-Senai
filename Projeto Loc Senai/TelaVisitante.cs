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

namespace Projeto_Loc_Senai
{
    public partial class TelaVisitante : Form
    {
        Thread f1;
        private Form activeForm;
        public int id_on;
        public TelaVisitante(int id_on)
        {
            InitializeComponent();

            //Desativa barra superior padrão do Windows
            this.Text = string.Empty;
            this.ControlBox = false;
            // Define o tamanho padrão da tela como 1440x1024 pixels
            this.Size = new Size(1440, 1024);
            this.MinimumSize = new Size(850, 600);
            this.id_on = id_on;
        }

        //Comando para responsividade da tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Fechar Tela
        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Maximar e Minimizar Tela
        private void Janelas_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Minimizar Tela
        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Movimentação da tela
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //sair do visitante
        private void AbrirJan(object obj)
        {
            Application.Run(new TelaLogin(id_on));
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        //Fechar todas as telas abertas
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        //Abrir um forms em um painel
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PainelGeral.Controls.Add(childForm);
            this.PainelGeral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnMapa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsVisitante.TelaMapaSenai());
        }

        private void BtnEvento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsVisitante.TelaEventoVisitante());
        }

        private void BtnFeedback_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsVisitante.TelaFeedBackVisitante());
        }

        private void BtnContato_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsVisitante.TelaContatosSenai());
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsVisitante.TelaInformacoes());
        }
    }
}
