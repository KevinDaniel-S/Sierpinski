using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sierpinski
{
    public partial class VentanaSierpinski : Form
    {
        SolidBrush b = new SolidBrush(Color.Gold);
        Graphics g = null;
        int nivel = 0;
        ColorDialog cd = new ColorDialog();
        
        public VentanaSierpinski()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        public void DibujarTriangulo(float x, float y, float largo,int nivel)
        {
            if (nivel == 0)
            {
                PointF[] puntos =
                 {
                    new PointF(x, y),
                    new PointF(x + largo, y),
                    new PointF(x + largo / 2, y - (float)Math.Sqrt(3) * largo / 2)
                };
                g.FillPolygon(b, puntos);
            }
            else
            {
                nivel--;
                DibujarTriangulo(x, y, largo / 2, nivel);
                DibujarTriangulo(x + largo / 2, y, largo / 2, nivel);
                DibujarTriangulo(x + largo / 4, y - (float)Math.Sqrt(3) * largo / 4, largo / 2, nivel);
            }
        }

        public void DibujarCuadrado(float x, float y, float largo, int nivel)
        {
            if (nivel == 0)
            {
                PointF[] puntos =
                 {
                    new PointF(x, y),
                    new PointF(x + largo, y),
                    new PointF(x + largo, y - largo),
                    new PointF(x, y - largo)
                };

                g.FillPolygon(b, puntos);
            }
            else
            {
                nivel--;     
                DibujarCuadrado(x, y, largo / 3, nivel);                    //1
                DibujarCuadrado(x + largo / 3, y, largo / 3, nivel);        //2
                DibujarCuadrado(x, y - largo / 3, largo / 3, nivel);        //4
                DibujarCuadrado(x, y - (largo / 3) * 2, largo / 3, nivel);  //6
                DibujarCuadrado(x + largo / 3, y - (largo / 3) * 2, largo / 3, nivel);//7
                DibujarCuadrado(x + (largo / 3) * 2, y - (largo / 3) * 2, largo / 3, nivel);//8
                DibujarCuadrado(x + (largo / 3) * 2, y - largo / 3, largo / 3, nivel);//5
                DibujarCuadrado(x + (largo / 3) * 2, y, largo / 3, nivel);  //3          
            }
        }

        
        private void BotonAumentar_Click(object sender, EventArgs e)
        {
            nivel++;
            Pintar();
        }

        private void BotonDisminuir_Click(object sender, EventArgs e)
        {
            if (nivel > 0)
            {
                nivel--;
                Pintar();
            }
        }

        private void BotonColor_Click(object sender, EventArgs e)
        {
            cd.FullOpen = true;
            cd.ShowDialog();
            b.Color = cd.Color;
            Pintar();
        }

        private void Fractales_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pintar();
        }

        private void Pintar()
        {

            g.Clear(Color.WhiteSmoke);
            if (fractales.Text == "Triangulo")
            {
                DibujarTriangulo(50, 400, 350, nivel);
            }
            else
            {
                DibujarCuadrado(50, 400, 350, nivel);
            }
        }
    }
}
