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

            conexao conn = new conexao();
            //getconexao().Open();
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("SELECT DATE_FORMAT(current_date, '%d/%m/%y') AS DataAtual, DAYNAME(CURRENT_DATE) AS DiaDaSemanaAtual");
            dt.Read();

            box_teste_data.Text = dt.GetString(0);


            data_atual = dt.GetString(0);


            //if (dt.GetString(1) == "Monday")
            //{
            //    dia_atual = "SEGUNDA";
            //    box_teste_dia.Text = dia_atual;
            //};
            //if (dt.GetString(1) == "Tuesday")
            //{
            //    dia_atual = "TERÇA";
            //    box_teste_dia.Text = dia_atual;
            //};
            //if (dt.GetString(1) == "Wednesday")
            //{
            //    dia_atual = "QUARTA";
            //    box_teste_dia.Text = dia_atual;
            //};
            //if (dt.GetString(1) == "Thursday")
            //{
            //    dia_atual = "QUINTA";
            //    box_teste_dia.Text = dia_atual;
            //};
            //if (dt.GetString(1) == "Friday")
            //{
            //    dia_atual = "SEXTA";
            //    box_teste_dia.Text = dia_atual;
            //};
            //if (dt.GetString(1) == "Saturday")
            //{
            //    dia_atual = "SABADO";
            //    box_teste_dia.Text = dia_atual;
            //};
            //if (dt.GetString(1) == "Sunday")
            //{
            //    dia_atual = "DOMINGO";
            //    box_teste_dia.Text = dia_atual;
            //};

            ////conn.Close();
            //dt.Close();
        }
        Thread f1;
        int cont = 0;
        bool dia = false;
        string dia_atual;
        string data_atual;

        private void TelaEventoVisitante_Load(object sender, EventArgs e)
        {
          

        }

    }
}
