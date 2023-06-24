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
                        sexta = conta+ 4;
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
                        terca = conta ;
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
                        quarta = conta ;
                        quinta = conta + 1;
                        sexta = conta +2;
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
                        quinta = conta ;
                        sexta = conta +1;
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
                    if(dia_principal5.Text == "1")
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

                        //=============================================
                        // select segunda id
                        //=============================================
                        if (box_calculo1.Text != "")
                        {

                            ConsultarDados consu1 = new ConsultarDados();
                            MySqlDataReader dt1 = consu1.select("select id_evento from tb_evento where dia_semana = '" + label1.Text + "';");
                            //dt2.Read();
                            //box_teste_select.Text = dt2.GetString(0);

                            List<string[]> resultados_1 = new List<string[]>();
                            string[] resultado_1 = new string[4];
                            int count_1 = 0;
                            while (dt1.Read())
                            {

                                // Supondo duas colunas retornadas pela consulta
                                resultado_1[count_1] = dt1["id_evento"].ToString(); // Supondo que a primeira coluna seja do tipo string

                                count_1++;
                            }
                            count_1 = 0;
                            string id_on_1 = "0";
                            foreach (string i in resultado_1)
                            {


                                if (i == null)
                                {
                                    id_on_1 = "0";
                                }
                                else
                                {
                                    id_on_1 = i;
                                }
                                switch (count_1)
                                {
                                    case 0:
                                        box_id_1_seg.Text = id_on_1;
                                        break;
                                    case 1:
                                        box_id_2_seg.Text = id_on_1;
                                        break;
                                    case 2:
                                        box_id_3_seg.Text = id_on_1;
                                        break;
                                    case 3:
                                        box_id_4_seg.Text = id_on_1;
                                        break;
                                    default:
                                        MessageBox.Show("Nada");
                                        break;
                                }

                                count_1++;
                            }


                        }
                        //=============================================
                        // select terça id
                        //=============================================
                        if (box_calculo1.Text != "")
                        {

                            ConsultarDados consu2 = new ConsultarDados();
                            MySqlDataReader dt2 = consu2.select("select id_evento from tb_evento where dia_semana = '" + label2.Text + "';");
                            //dt2.Read();
                            //box_teste_select.Text = dt2.GetString(0);

                            List<string[]> resultados_2 = new List<string[]>();
                            string[] resultado_2 = new string[4];
                            int count_2 = 0;
                            while (dt2.Read())
                            {

                                // Supondo duas colunas retornadas pela consulta
                                resultado_2[count_2] = dt2["id_evento"].ToString(); // Supondo que a primeira coluna seja do tipo string

                                count_2++;
                            }
                            count_2 = 0;
                            string id_on_2 = "0";
                            foreach (string i in resultado_2)
                            {


                                if (i == null)
                                {
                                    id_on_2 = "0";
                                }
                                else
                                {
                                    id_on_2 = i;
                                }
                                switch (count_2)
                                {
                                    case 0:
                                        box_id_1_ter.Text = id_on_2;
                                        break;
                                    case 1:
                                        box_id_2_ter.Text = id_on_2;
                                        break;
                                    case 2:
                                        box_id_3_ter.Text = id_on_2;
                                        break;
                                    case 3:
                                        box_id_4_ter.Text = id_on_2;
                                        break;
                                    default:
                                        MessageBox.Show("Nada");
                                        break;
                                }

                                count_2++;
                            }


                        }

                        //=============================================
                        // select sexta id
                        //=============================================
                        if (box_calculo5.Text != "")
                        {
                            
                            ConsultarDados consu5 = new ConsultarDados();
                            MySqlDataReader dt5 = consu5.select("select id_evento from tb_evento where dia_semana = '" + dia_atual + "';");
                            //dt2.Read();
                            //box_teste_select.Text = dt2.GetString(0);
                            
                                List<string[]> resultados_5 = new List<string[]>();
                                string[] resultado_5 = new string[4];
                                int count_5 = 0;
                                while (dt5.Read())
                                {

                                    // Supondo duas colunas retornadas pela consulta
                                    resultado_5[count_5] = dt5["id_evento"].ToString(); // Supondo que a primeira coluna seja do tipo string

                                    count_5++;
                                }
                                count_5 = 0;
                                string id_on_5 = "0";
                                foreach (string i in resultado_5)
                                {


                                    if (i == null)
                                    {
                                        id_on_5 = "0";
                                    }
                                    else
                                    {
                                        id_on_5 = i;
                                    }
                                    switch (count_5)
                                    {
                                        case 0:
                                            box_id_1_sex.Text = id_on_5;
                                            break;
                                        case 1: 
                                            box_id_2_sex.Text = id_on_5;
                                            break;
                                        case 2:
                                            box_id_3_sex.Text = id_on_5;
                                            break;
                                        case 3:
                                            box_id_4_sex.Text = id_on_5;
                                            break;
                                        default:
                                            MessageBox.Show("Nada");
                                            break;
                                    }

                                    count_5++;
                                }

                            
                        }

                    }

                    break;
                case "Saturday":
                    dia_atual = "SABADO";
                    box_teste_dia.Text = dia_atual;
                    dia_principal = 1;
                    dia_principal6.Text = Convert.ToString(dia_principal);
                    if (dia_principal5.Text == "1")
                    {
                        box_calculo5.Text = data_atual;
                        conta = Convert.ToInt32(data_atual);
                        segunda = conta - 5;
                        terca = conta - 4;
                        quarta = conta - 3;
                        quinta = conta - 2;
                        sexta = conta -1;
                        sabado = conta ;
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
                    if (dia_principal5.Text == "1")
                    {
                        box_calculo5.Text = data_atual;
                        conta = Convert.ToInt32(data_atual);
                        segunda = conta - 6;
                        terca = conta - 5;
                        quarta = conta - 4;
                        quinta = conta - 3;
                        sexta = conta - 2;
                        sabado = conta - 1;
                        domingo = conta ;
                        box_calculo1.Text = Convert.ToString(segunda);
                        box_calculo2.Text = Convert.ToString(terca);
                        box_calculo3.Text = Convert.ToString(quarta);
                        box_calculo4.Text = Convert.ToString(quinta);
                        box_calculo5.Text = Convert.ToString(sexta);
                        box_calculo6.Text = Convert.ToString(sabado);
                        box_calculo7.Text = Convert.ToString(domingo);

                    }
                    break;

                default:
                    MessageBox.Show("Nada");
                    break;
            }
            //conn.Close();
            dt.Close();
        }
        Thread f1;
        
        

        private void TelaEventoVisitante_Load(object sender, EventArgs e)
        {
            
        }

    }
}
