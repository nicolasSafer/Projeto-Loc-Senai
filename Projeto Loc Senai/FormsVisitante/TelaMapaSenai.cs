using Projeto_Loc_Senai.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btn_secretaria_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Secretaria;
        }

        private void btn_Coordenacao_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Coordenacao;
        }

        private void btn_almoxarifado_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Almoxarifado;
        }

        private void btn_Biblioteca_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Biblioteca;
        }

        private void btn_Sala_03_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Sala_03;
        }

        private void btn_Sala_10_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Sala_10;
        }

        private void btn_Lab_modelagem_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Lab_Modelagem;
        }

        private void btn_Lab_Costura_Click(object sender, EventArgs e)
        {
            Mapa.Image = Resources.Mapa_Terreo_Lab_Costura;
        }
    }
}
