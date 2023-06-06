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
using CONTROL;
using MODEL;
using MySql.Data.MySqlClient;
using Projeto_Loc_Senai.FormsAdm;
using WindowsFormsApp3;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Projeto_Loc_Senai.FormsVisitante
{
    public partial class TelaEventoVisitante : Form
    {
        public string data;
        public TelaEventoVisitante()
        {
            InitializeComponent();
        }
        Thread f1;
        private void TelaEventoVisitante_Load(object sender, EventArgs e)
        {
            displaDays();
            conexao conn = new conexao();

            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("select * from tb_evento");
            dt.Read();
            box_teste.Text = dt.GetString(3);

        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;

            //Definir o primeiro dia do mês

            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);

            //Contagem de dias no mês
            int days = DateTime.DaysInMonth (now.Year, now.Month);

            //converter a variavel startofthemonth em inteiro
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //UserControlBlank contagem
            for(int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
        }
        private void AbrirJan(object obj)
        {
            Application.Run(new TelaDescEvento(data));
        }
        
        private void panel2_Click(object sender, EventArgs e)
        {
            ////abrir tela desc evento
            data = "01";
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(data);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            data = "02";
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(data);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            data = "03";
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(data);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            data = "04";
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(data);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            data = "05";
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(data);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            data = "06";
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(data);
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            data = "07";
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(data);
        }
    }
}
