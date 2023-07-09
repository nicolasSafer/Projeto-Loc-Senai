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

        

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TelaMapaSenai_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }
        int teste = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           // if(teste == 1) { 
           // Graphics g = this.pictureBox1.CreateGraphics();
           // Pen blackPen = new Pen(Color.Black, 3);

           // PointF pnt1 = new PointF(586.0F, 489.0F);
           // PointF pnt2 = new PointF(586F, 451.0F);

           //e.Graphics.DrawLine(blackPen, pnt1, pnt2);
           // }
           // else
           // {
           //     Graphics g = this.pictureBox1.CreateGraphics();
           //     Pen blackPen = new Pen(Color.Black, 3);

           //     PointF pnt1 = new PointF(586.0F, 489.0F);
           //     PointF pnt2 = new PointF(586F, 489.0F);

           //     e.Graphics.DrawLine(blackPen, pnt1, pnt2);
           // }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            picture_map.Image = Resources.map1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picture_map.Image = Resources.map2;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            picture_map.Image = Resources.map3;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            picture_map.Image = Resources.map4;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            picture_map.Image = Resources.map5;

        }
    }
}
