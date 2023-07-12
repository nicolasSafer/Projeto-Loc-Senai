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
    public partial class TelaAdm : Form
    {
        Thread f1;
        private Form activeForm;
        public string id_on;


        public TelaAdm()
        {



        }

        public TelaAdm(string id_on)
        {
            this.id_on = id_on;
            InitializeComponent();
            //Desativa barra superior padrão do Windows
            this.Text = string.Empty;
            this.ControlBox = false;
            // Define o tamanho padrão da tela como 1440x1024 pixels
            this.Size = new Size(1440, 1024);
            this.MinimumSize = new Size(850, 600);
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

        //Movimentação da Tela
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        //Fechar todas as telas abertas
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void Btnperfil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsAdm.TelaPerfil(id_on));
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsAdm.TelaSala());
        }

        private void Btneventos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsAdm.TelaEvento());
        }

        private void btnfeedback_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsAdm.TelaFeedback());
        }

        //Sair do Administrador
        private void AbrirJan(object obj)
        {
            Application.Run(new TelaLogin());
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        private void TelaAdm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(id_on);
        }

        private void PainelGeral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
