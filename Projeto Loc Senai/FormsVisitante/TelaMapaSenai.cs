using Projeto_Loc_Senai.Properties;
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

namespace Projeto_Loc_Senai.FormsVisitante
{
    public partial class TelaMapaSenai : Form
    {
        public TelaMapaSenai()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_pin;
        }
        int teste = 0;
        private void btn_secretaria_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Secretaria;
            btn_1.Visible = true;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;
            btn_8.Visible = false;

        }

        private void btn_Coordenacao_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Coordenacao;
            btn_1.Visible = false;
            btn_2.Visible = true;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;
            btn_8.Visible = false;
        }

        private void btn_almoxarifado_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Almoxarifado;
            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = true;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;
            btn_8.Visible = false;
        }

        private void btn_Biblioteca_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Biblioteca;
            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = true;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;
            btn_8.Visible = false;
        }

        private void btn_Sala_03_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Sala_03;
            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = true;
            btn_6.Visible = false;
            btn_7.Visible = false;
            btn_8.Visible = false;
        }

        private void btn_Sala_10_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Sala_10;
            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = true;
            btn_7.Visible = false;
            btn_8.Visible = false;
        }

        private void btn_Lab_modelagem_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Lab_Modelagem;
            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = true;
            btn_8.Visible = false;
        }

        private void btn_Lab_Costura_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Lab_Costura;
            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;
            btn_8.Visible = true;
        }



        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Thread f1;
        int id_on;
        private void btn_1_Click(object sender, EventArgs e)
        {
            id_on = 10;
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(id_on);
        }
        private void AbrirJan(object obj)
        {
            Application.Run(new TelaDescSala(id_on));
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            id_on = 11;
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(id_on);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            id_on = 12;
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(id_on);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            id_on = 13;
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(id_on);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            id_on = 14;
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(id_on);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            id_on = 15;
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(id_on);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            id_on = 16;
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(id_on);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            id_on = 17;
            f1 = new Thread(AbrirJan);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start(id_on);
        }
    }
}
