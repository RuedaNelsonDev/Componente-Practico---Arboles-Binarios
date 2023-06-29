using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4_Nelson_Rueda
{
    public partial class FormEscenario1 : Form
    {
        public FormEscenario1()
        {
            InitializeComponent();
        }

       

        private void gráficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Graphics para dibujar en el formulario
            Graphics graphics = CreateGraphics();

            // Dibujar el árbol binario de búsqueda
            DrawBinaryTree(graphics);
        }

        private void DrawBinaryTree(Graphics graphics)
        {
            // Crear el nodo raíz
            dibujarNodoArbol(graphics, 320, 30, 35, 35, Brushes.Cyan, Pens.Orange, "55");

            // Crear los nodos restantes y conectarlos
            dibujarNodoArbol(graphics, 250, 90, 35, 35, Brushes.Cyan, Pens.Orange, "53");
            dibujarNodoArbol(graphics, 390, 90, 35, 35, Brushes.Cyan, Pens.Orange, "59");

            dibujarNodoArbol(graphics, 180, 150, 35, 35, Brushes.Cyan, Pens.Orange, "48");
            dibujarNodoArbol(graphics, 290, 150, 35, 35, Brushes.Cyan, Pens.Orange, "54");
            dibujarNodoArbol(graphics, 470, 150, 35, 35, Brushes.Cyan, Pens.Orange, "63");

            dibujarNodoArbol(graphics, 350, 150, 35, 35, Brushes.Cyan, Pens.Orange, "56");

            dibujarNodoArbol(graphics, 370, 270, 35, 35, Brushes.Cyan, Pens.Orange, "57");
            dibujarNodoArbol(graphics, 470, 270, 35, 35, Brushes.Cyan, Pens.Orange, "61");
            dibujarNodoArbol(graphics, 540, 270, 35, 35, Brushes.Cyan, Pens.Orange, "70");

            dibujarNodoArbol(graphics, 220, 270, 35, 35, Brushes.Cyan, Pens.Orange, "51");

            // Conectar los nodos
            ConnectNodes(graphics, 320, 30, 250, 90);     // Conectar 55 con 53
            ConnectNodes(graphics, 320, 30, 390, 90);     // Conectar 55 con 59

            ConnectNodes(graphics, 250, 90, 180, 150);    // Conectar 53 con 48
            ConnectNodes(graphics, 250, 90, 290, 150);    // Conectar 53 con 54

            ConnectNodes(graphics, 390, 90, 350, 150);    // Conectar 59 con 56
            ConnectNodes(graphics, 390, 90, 470, 150);    // Conectar 59 con 63


            ConnectNodes(graphics, 350, 150, 370, 270);   // Conectar 56 con 57
            ConnectNodes(graphics, 470, 150, 470, 270);   // Conectar 63 con 61

            ConnectNodes(graphics, 470, 150, 540, 270);   // Conectar 63 con 61

            ConnectNodes(graphics, 180, 150, 220, 270);   // Conectar 18 con 51


        }


        private void dibujarNodoArbol(Graphics graphics, int x, int y, int width, int height, Brush brush, Pen pen, string label)
        {
            graphics.FillEllipse(brush, x, y, width, height);
            graphics.DrawEllipse(pen, x, y, width, height);
            graphics.DrawString(label, Font, Brushes.Purple, x + 10, y + 10);
        }

        private void ConnectNodes(Graphics graphics, int x1, int y1, int x2, int y2)
        {
            graphics.DrawLine(Pens.Black, x1 + 18, y1 + 35, x2 + 18, y2);
        }


        private void preOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            dibujarPreOrden(graphics);
        }

        private void dibujarPreOrden(Graphics graphics)
        {
            dibujarNodoArbol(graphics, 140, 350, 35, 35, Brushes.Yellow, Pens.Orange, "55");

            dibujarNodoArbol(graphics, 190, 350, 35, 35, Brushes.Yellow, Pens.Orange, "53");

            dibujarNodoArbol(graphics, 240, 350, 35, 35, Brushes.Yellow, Pens.Orange, "48");

            dibujarNodoArbol(graphics, 290, 350, 35, 35, Brushes.Yellow, Pens.Orange, "51");


            dibujarNodoArbol(graphics, 340, 350, 35, 35, Brushes.Yellow, Pens.Orange, "54");


            dibujarNodoArbol(graphics, 390, 350, 35, 35, Brushes.Yellow, Pens.Orange, "59");


            dibujarNodoArbol(graphics, 440, 350, 35, 35, Brushes.Yellow, Pens.Orange, "56");


            dibujarNodoArbol(graphics, 490, 350, 35, 35, Brushes.Yellow, Pens.Orange, "57");


            dibujarNodoArbol(graphics, 540, 350, 35, 35, Brushes.Yellow, Pens.Orange, "63");


            dibujarNodoArbol(graphics, 590, 350, 35, 35, Brushes.Yellow, Pens.Orange, "61");


            dibujarNodoArbol(graphics, 640, 350, 35, 35, Brushes.Yellow, Pens.Orange, "70");

        }

        private void dibujarInorden(Graphics graphics)
        {
            dibujarNodoArbol(graphics, 140, 400, 35, 35, Brushes.Yellow, Pens.Orange, "48");

            dibujarNodoArbol(graphics, 190, 400, 35, 35, Brushes.Yellow, Pens.Orange, "51");

            dibujarNodoArbol(graphics, 240, 400, 35, 35, Brushes.Yellow, Pens.Orange, "53");

            dibujarNodoArbol(graphics, 290, 400, 35, 35, Brushes.Yellow, Pens.Orange, "54");


            dibujarNodoArbol(graphics, 340, 400, 35, 35, Brushes.Yellow, Pens.Orange, "55");


            dibujarNodoArbol(graphics, 390, 400, 35, 35, Brushes.Yellow, Pens.Orange, "56");


            dibujarNodoArbol(graphics, 440, 400, 35, 35, Brushes.Yellow, Pens.Orange, "57");

            dibujarNodoArbol(graphics, 490, 400, 35, 35, Brushes.Yellow, Pens.Orange, "59");


            dibujarNodoArbol(graphics, 540, 400, 35, 35, Brushes.Yellow, Pens.Orange, "61");


            dibujarNodoArbol(graphics, 590, 400, 35, 35, Brushes.Yellow, Pens.Orange, "63");

            dibujarNodoArbol(graphics, 640, 400, 35, 35, Brushes.Yellow, Pens.Orange, "70");

        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            dibujarInorden(graphics);

        }

        private void dibujarPostOrden(Graphics graphics)
        {

            dibujarNodoArbol(graphics, 140, 450, 35, 35, Brushes.Yellow, Pens.Orange, "51");

            dibujarNodoArbol(graphics, 190, 450, 35, 35, Brushes.Yellow, Pens.Orange, "48");

            dibujarNodoArbol(graphics, 240, 450, 35, 35, Brushes.Yellow, Pens.Orange, "54");

            dibujarNodoArbol(graphics, 290, 450, 35, 35, Brushes.Yellow, Pens.Orange, "53");


            dibujarNodoArbol(graphics, 340, 450, 35, 35, Brushes.Yellow, Pens.Orange, "57");


            dibujarNodoArbol(graphics, 390, 450, 35, 35, Brushes.Yellow, Pens.Orange, "56");


            dibujarNodoArbol(graphics, 440, 450, 35, 35, Brushes.Yellow, Pens.Orange, "61");


            dibujarNodoArbol(graphics, 490, 450, 35, 35, Brushes.Yellow, Pens.Orange, "70");


            dibujarNodoArbol(graphics, 540, 450, 35, 35, Brushes.Yellow, Pens.Orange, "63");


            dibujarNodoArbol(graphics, 590, 450, 35, 35, Brushes.Yellow, Pens.Orange, "59");


            dibujarNodoArbol(graphics, 640, 450, 35, 35, Brushes.Yellow, Pens.Orange, "55");

        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Graphics graphics = CreateGraphics();
            dibujarPostOrden(graphics);
        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormMenu));
        }

        private void mostrarForm(Type formType)
        {
            Form formInstance = (Form)Activator.CreateInstance(formType);
            formInstance.Show();
            this.Close();
        }
    }
}
