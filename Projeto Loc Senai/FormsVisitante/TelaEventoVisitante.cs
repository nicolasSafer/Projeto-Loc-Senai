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

            if (dt.GetString(1) == "Monday")
            {
                dia_atual = "SEGUNDA";
                box_teste_dia.Text = dia_atual;
            };
            if (dt.GetString(1) == "Tuesday")
            {
                dia_atual = "TERÇA";
                box_teste_dia.Text = dia_atual;
            };
            if (dt.GetString(1) == "Wednesday")
            {
                dia_atual = "QUARTA";
                box_teste_dia.Text = dia_atual;
            };
            if (dt.GetString(1) == "Thursday")
            {
                dia_atual = "QUINTA";
                box_teste_dia.Text = dia_atual;
            };
            if (dt.GetString(1) == "Friday")
            {
                dia_atual = "SEXTA";
                box_teste_dia.Text = dia_atual;
            };
            if (dt.GetString(1) == "Saturday")
            {
                dia_atual = "SABADO";
                box_teste_dia.Text = dia_atual;
            };
            if (dt.GetString(1) == "Sunday")
            {
                dia_atual = "DOMINGO";
                box_teste_dia.Text = dia_atual;
            };

            //conn.Close();
            dt.Close();

        }
        Thread f1;
        int cont = 0;
        bool dia = false;
        string dia_atual;
        string data_atual;
        private void TelaEventoVisitante_Load(object sender, EventArgs e)
        {
            displaDays();

            if (box_teste_dia.Text != "")
            {

                //getconexao().Open();
                ConsultarDados consu = new ConsultarDados();
                MySqlDataReader dt2 = consu.select("select id_evento,nome_evento from tb_evento where dia_semana = '"+dia_atual+"';");
                dt2.Read();
                box_teste_select.Text = dt2.GetString(0);
            }






            //
            //dt.Read();
            //












            // ------------------------------QUANDO EU FOR BOM EU FAÇO FUNCIONAR------------------------------
            //List<string[]> produtos = new List<string[]>();

            //// Loop para ler cada registro retornado pelo SELECT
            //while (dt.Read())
            //{
            //    // Array para armazenar os valores do produto (nome e descrição)
            //    string[] produto = new string[2];

            //    // Preenche o array com os valores do registro atual
            //    produto[0] = dt.GetString(0);  // Nome do produto (coluna 0)
            //    produto[1] = dt.GetString(1);  // Descrição do produto (coluna 1)

            //    // Adiciona o produto à lista
            //    produtos.Add(produto);
            //}

            //// Agora, você pode usar a matriz bidimensional ou a lista de produtos conforme necessário
            //// Por exemplo, exibir os produtos em um controle de seleção (ComboBox)

            //foreach (string[] produto in produtos)
            //{
            //    string nomeProduto = produto[0];
            //    string descricaoProduto = produto[1];

            //    // Adicione o produto ao controle de seleção
            //    cbx_teste1.Items.Add(nomeProduto);

            //    // Armazene a descrição do produto como um item de dados do controle de seleção
            //    cbx_teste1.Items[cbx_teste1.Items.Count - 1] = descricaoProduto;
            //}

            // ------------------------------ TESTO OUTRA HORA ----------------------------------------------
            //try
            //{
            //    conexao conn = new conexao();

            //    ConsultarDados consu = new ConsultarDados();
            //    MySqlDataReader dt = consu.select("select * from tb_evento where dia_semana = 'SEGUNDA' ");
            //    while (dt.Read())
            //    {
            //        cont++;

            //    }
            //    if (cont == 0)
            //    {
            //        dia = false;
            //    }
            //    else
            //    {
            //        dia = true;
            //    }
            //}
            //catch
            //{
            //    dia = false;
            //}

            //return dia;

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

        private void box_id_2_seg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
