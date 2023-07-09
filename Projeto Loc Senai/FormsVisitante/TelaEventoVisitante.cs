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
using System.Windows.Media;
using CONTROL;
using FontAwesome.Sharp;
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
        string data_atual;
        string mes_atual;
        string ano_atual;
        string dia_atual;
        int dia_principal = 0;
        int segunda = 0;
        int terca = 0;
        int quarta = 0;
        int quinta = 0;
        int sexta = 0;
        int sabado = 0;
        int domingo = 0;
        int cont = 0;
        bool dia = false;
        string dia_on;

        public TelaEventoVisitante()
        {
            InitializeComponent();

            conexao conn = new conexao();
            //getconexao().Open();
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("SELECT DATE_FORMAT(current_date, '%d') as Data_Atual,  DATE_FORMAT(current_date, '%m') as Mes_Atual, DATE_FORMAT(current_date, '%y') as Ano_Atual, DAYNAME(CURRENT_DATE) AS DiaDaSemanaAtual;");
           dt.Read();





            data_atual = dt.GetString(0);
            mes_atual = dt.GetString(1);
            ano_atual = dt.GetString(2);
            dia_atual = dt.GetString(3);

            box_teste_data.Text = dt.GetString(0);
            box_mes_atual.Text = dt.GetString(1);
            int conta = 0;
            switch (dia_atual)
            {
                case "Monday":
                    dia_atual = "SEGUNDA";
                    box_teste_dia.Text = dia_atual;
                    dia_principal = 1;
                    dia_principal1.Text = Convert.ToString(dia_principal);
                    if (dia_principal5.Text == "1")
                    {
                        box_calculo5.Text = data_atual;
                        conta = Convert.ToInt32(data_atual);
                        segunda = conta;
                        terca = conta + 1;
                        quarta = conta + 2;
                        quinta = conta + 3;
                        sexta = conta + 4;
                        sabado = conta + 5;
                        domingo = conta + 6;
                        box_calculo1.Text = Convert.ToString(segunda);
                        box_calculo2.Text = Convert.ToString(terca);
                        box_calculo3.Text = Convert.ToString(quarta);
                        box_calculo4.Text = Convert.ToString(quinta);
                        box_calculo5.Text = Convert.ToString(sexta);
                        box_calculo6.Text = Convert.ToString(sabado);
                        box_calculo7.Text = Convert.ToString(domingo);
                       
                    }
                    break;
                case "Tuesday":
                    dia_atual = "TERÇA";
                    box_teste_dia.Text = dia_atual;
                    dia_principal = 1;
                    dia_principal2.Text = Convert.ToString(dia_principal);
                    if (dia_principal5.Text == "1")
                    {
                        box_calculo5.Text = data_atual;
                        conta = Convert.ToInt32(data_atual);
                        segunda = conta - 1;
                        terca = conta;
                        quarta = conta + 1;
                        quinta = conta + 2;
                        sexta = conta + 3;
                        sabado = conta + 4;
                        domingo = conta + 5;
                        box_calculo1.Text = Convert.ToString(segunda);
                        box_calculo2.Text = Convert.ToString(terca);
                        box_calculo3.Text = Convert.ToString(quarta);
                        box_calculo4.Text = Convert.ToString(quinta);
                        box_calculo5.Text = Convert.ToString(sexta);
                        box_calculo6.Text = Convert.ToString(sabado);
                        box_calculo7.Text = Convert.ToString(domingo);
                        
                    }

                    break;

                case "Wednesday":
                    dia_atual = "QUARTA";
                    box_teste_dia.Text = dia_atual;
                    dia_principal = 1;
                    dia_principal3.Text = Convert.ToString(dia_principal);
                    if (dia_principal5.Text == "1")
                    {
                        box_calculo5.Text = data_atual;
                        conta = Convert.ToInt32(data_atual);
                        segunda = conta - 2;
                        terca = conta - 1;
                        quarta = conta;
                        quinta = conta + 1;
                        sexta = conta + 2;
                        sabado = conta + 3;
                        domingo = conta + 4;
                        box_calculo1.Text = Convert.ToString(segunda);
                        box_calculo2.Text = Convert.ToString(terca);
                        box_calculo3.Text = Convert.ToString(quarta);
                        box_calculo4.Text = Convert.ToString(quinta);
                        box_calculo5.Text = Convert.ToString(sexta);
                        box_calculo6.Text = Convert.ToString(sabado);
                        box_calculo7.Text = Convert.ToString(domingo);
                        

                    }
                    break;
                case "Thursday":
                    dia_atual = "QUINTA";
                    box_teste_dia.Text = dia_atual;
                    dia_principal = 1;
                    dia_principal4.Text = Convert.ToString(dia_principal);
                    if (dia_principal5.Text == "1")
                    {
                        box_calculo5.Text = data_atual;
                        conta = Convert.ToInt32(data_atual);
                        segunda = conta - 3;
                        terca = conta - 2;
                        quarta = conta - 1;
                        quinta = conta;
                        sexta = conta + 1;
                        sabado = conta + 2;
                        domingo = conta + 3;
                        box_calculo1.Text = Convert.ToString(segunda);
                        box_calculo2.Text = Convert.ToString(terca);
                        box_calculo3.Text = Convert.ToString(quarta);
                        box_calculo4.Text = Convert.ToString(quinta);
                        box_calculo5.Text = Convert.ToString(sexta);
                        box_calculo6.Text = Convert.ToString(sabado);
                        box_calculo7.Text = Convert.ToString(domingo);
                        
                    }

                    break;
                case "Friday":
                    dia_atual = "SEXTA";
                    box_teste_dia.Text = dia_atual;
                    dia_principal = 1;
                    dia_principal5.Text = Convert.ToString(dia_principal);
                    if (dia_principal5.Text == "1")
                    {
                        box_calculo5.Text = data_atual;
                        conta = Convert.ToInt32(data_atual);
                        segunda = conta - 4;
                        terca = conta - 3;
                        quarta = conta - 2;
                        quinta = conta - 1;
                        sexta = conta;
                        sabado = conta + 1;
                        domingo = conta + 2;
                        box_calculo1.Text = Convert.ToString(segunda);
                        box_calculo2.Text = Convert.ToString(terca);
                        box_calculo3.Text = Convert.ToString(quarta);
                        box_calculo4.Text = Convert.ToString(quinta);
                        box_calculo5.Text = Convert.ToString(sexta);
                        box_calculo6.Text = Convert.ToString(sabado);
                        box_calculo7.Text = Convert.ToString(domingo);

                    }

                    break;

                case "Saturday":
                    dia_atual = "SABADO";
                    box_teste_dia.Text = dia_atual;
                    dia_principal = 1;
                    dia_principal6.Text = Convert.ToString(dia_principal);
                    if (dia_principal6.Text == "1")
                    {
                        box_calculo6.Text = data_atual;
                        conta = Convert.ToInt32(data_atual);
                        segunda = conta - 5;
                        terca = conta - 4;
                        quarta = conta - 3;
                        quinta = conta - 2;
                        sexta = conta - 1;
                        sabado = conta;
                        domingo = conta + 1;
                        box_calculo1.Text = Convert.ToString(segunda);
                        box_calculo2.Text = Convert.ToString(terca);
                        box_calculo3.Text = Convert.ToString(quarta);
                        box_calculo4.Text = Convert.ToString(quinta);
                        box_calculo5.Text = Convert.ToString(sexta);
                        box_calculo6.Text = Convert.ToString(sabado);
                        box_calculo7.Text = Convert.ToString(domingo);
                        

                    }
                    break;

                case "Sunday":
                    dia_atual = "DOMINGO";
                    box_teste_dia.Text = dia_atual;
                    dia_principal = 1;
                    dia_principal7.Text = Convert.ToString(dia_principal);
                    if (dia_principal7.Text == "1")
                    {
                        box_calculo5.Text = data_atual;
                        conta = Convert.ToInt32(data_atual);
                        segunda = conta - 6;
                        terca = conta - 5;
                        quarta = conta - 4;
                        quinta = conta - 3;
                        sexta = conta - 2;
                        sabado = conta - 1;
                        domingo = conta;
                        box_calculo1.Text = Convert.ToString(segunda);
                        box_calculo2.Text = Convert.ToString(terca);
                        box_calculo3.Text = Convert.ToString(quarta);
                        box_calculo4.Text = Convert.ToString(quinta);
                        box_calculo5.Text = Convert.ToString(sexta);
                        box_calculo6.Text = Convert.ToString(sabado);
                        box_calculo7.Text = Convert.ToString(domingo);

                    }
                    break;
            }
        }
        Thread f1;
        
        

        private void TelaEventoVisitante_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        Thread f;
        Thread f2;
        Thread f3;
        Thread f4;
        Thread f5;
        Thread f6;
        Thread f7;
        private void AbrirJan1(object obj)
        {
            Application.Run(new TelaDescEvento(dia_on));
        }
        private void AbrirJan2(object obj)
        {
            Application.Run(new TelaDescEvento(dia_on));
        }
        private void AbrirJan3(object obj)
        {
            Application.Run(new TelaDescEvento(dia_on));
        }
        private void AbrirJan4(object obj)
        {
            Application.Run(new TelaDescEvento(dia_on));
        }
        private void AbrirJan5(object obj)
        {
            Application.Run(new TelaDescEvento(dia_on));
        }
        private void AbrirJan6(object obj)
        {
            Application.Run(new TelaDescEvento(dia_on));
        }
        private void AbrirJan7(object obj)
        {
            Application.Run(new TelaDescEvento(dia_on));
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dia_on = box_calculo1.Text;
            f = new Thread(AbrirJan1);
            f.SetApartmentState(ApartmentState.STA);
            f.Start(dia_on);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dia_on = box_calculo2.Text;
            f2 = new Thread(AbrirJan2);
            f2.SetApartmentState(ApartmentState.STA);
            f2.Start(dia_on);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dia_on = box_calculo3.Text;
            f3 = new Thread(AbrirJan3);
            f3.SetApartmentState(ApartmentState.STA);
            f3.Start(dia_on);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dia_on = box_calculo4.Text;
            f4 = new Thread(AbrirJan4);
            f4.SetApartmentState(ApartmentState.STA);
            f4.Start(dia_on);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            dia_on = box_calculo5.Text;
            f5 = new Thread(AbrirJan5);
            f5.SetApartmentState(ApartmentState.STA);
            f5.Start(dia_on);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dia_on = box_calculo6.Text;
            f6 = new Thread(AbrirJan6);
            f6.SetApartmentState(ApartmentState.STA);
            f6.Start(dia_on);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dia_on = box_calculo7.Text;
            f7 = new Thread(AbrirJan7);
            f7.SetApartmentState(ApartmentState.STA);
            f7.Start(dia_on);
        }

    }
}
