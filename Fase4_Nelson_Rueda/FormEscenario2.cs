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
    public partial class FormEscenario2 : Form
    {
        public FormEscenario2()
        {
            InitializeComponent();
        }

        private void gráficaTSMIEscenario2_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Graphics para dibujar en el formulario
            Graphics graphics = CreateGraphics();

            // Dibujar el árbol binario de búsqueda
            DrawBinaryTree(graphics);
        }


        private void preOrdenTSMIEscenario2_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            dibujarPreOrden(graphics);
        }

        private void inOrdenTSMIEscenario2_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            dibujarInorden(graphics);
        }

        private void postOrdenTSMIEscenario2_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            dibujarPostOrden(graphics);
        }

        private void volverAlMenúTSMIEscenario2_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormMenu));
        }


        private void mostrarForm(Type formType)
        {
            Form formInstance = (Form)Activator.CreateInstance(formType);
            formInstance.Show();
            this.Close();
        }

        private void DrawBinaryTree(Graphics graphics)
        {
            // Crear el nodo raíz
            dibujarNodoArbol(graphics, 320, 30, 35, 35, Brushes.Cyan, Pens.Orange, "18");

            // Crear los nodos restantes y conectarlos
            dibujarNodoArbol(graphics, 250, 90, 35, 35, Brushes.Cyan, Pens.Orange, "9");
            dibujarNodoArbol(graphics, 500, 90, 35, 35, Brushes.Cyan, Pens.Orange, "25");

            dibujarNodoArbol(graphics, 180, 150, 35, 35, Brushes.Cyan, Pens.Orange, "7");
            dibujarNodoArbol(graphics, 290, 150, 35, 35, Brushes.Cyan, Pens.Orange, "12");
            dibujarNodoArbol(graphics, 470, 150, 35, 35, Brushes.Cyan, Pens.Orange, "23");
            dibujarNodoArbol(graphics, 540, 150, 35, 35, Brushes.Cyan, Pens.Orange, "29");

            dibujarNodoArbol(graphics, 120, 210, 35, 35, Brushes.Cyan, Pens.Orange, "2");
            dibujarNodoArbol(graphics, 210, 210, 35, 35, Brushes.Cyan, Pens.Orange, "8");
            dibujarNodoArbol(graphics, 260, 210, 35, 35, Brushes.Cyan, Pens.Orange, "11");
            dibujarNodoArbol(graphics, 430, 210, 35, 35, Brushes.Cyan, Pens.Orange, "21");
            dibujarNodoArbol(graphics, 500, 210, 35, 35, Brushes.Cyan, Pens.Orange, "24");
            dibujarNodoArbol(graphics, 580, 210, 35, 35, Brushes.Cyan, Pens.Orange, "31");

            // Conectar los nodos
            ConnectNodes(graphics, 320, 30, 250, 90);    // Conectar 18 con 9
            ConnectNodes(graphics, 320, 30, 500, 90);    // Conectar 18 con 25

            ConnectNodes(graphics, 250, 90, 180, 150);   // Conectar 9 con 7
            ConnectNodes(graphics, 250, 90, 290, 150);   // Conectar 9 con 12

            ConnectNodes(graphics, 500, 90, 470, 150);   // Conectar 25 con 23
            ConnectNodes(graphics, 500, 90, 540, 150);   // Conectar 25 con 29

            ConnectNodes(graphics, 180, 150, 120, 210);  // Conectar 7 con 2
            ConnectNodes(graphics, 180, 150, 210, 210);  // Conectar 7 con 8

            ConnectNodes(graphics, 290, 150, 260, 210);  // Conectar 12 con 11

            ConnectNodes(graphics, 470, 150, 430, 210);  // Conectar 23 con 21
            ConnectNodes(graphics, 470, 150, 500, 210);  // Conectar 23 con 24

            ConnectNodes(graphics, 540, 150, 580, 210);
            ConnectNodes(graphics, 540, 150, 580, 210);  // Conectar 29 con 31
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

        private void dibujarPreOrden(Graphics graphics)
        {
            dibujarNodoArbol(graphics, 140, 350, 35, 35, Brushes.Yellow, Pens.Orange, "18");

            dibujarNodoArbol(graphics, 190, 350, 35, 35, Brushes.Yellow, Pens.Orange, "9");

            dibujarNodoArbol(graphics, 240, 350, 35, 35, Brushes.Yellow, Pens.Orange, "7");

            dibujarNodoArbol(graphics, 290, 350, 35, 35, Brushes.Yellow, Pens.Orange, "2");


            dibujarNodoArbol(graphics, 340, 350, 35, 35, Brushes.Yellow, Pens.Orange, "8");


            dibujarNodoArbol(graphics, 390, 350, 35, 35, Brushes.Yellow, Pens.Orange, "12");


            dibujarNodoArbol(graphics, 440, 350, 35, 35, Brushes.Yellow, Pens.Orange, "11");


            dibujarNodoArbol(graphics, 490, 350, 35, 35, Brushes.Yellow, Pens.Orange, "25");


            dibujarNodoArbol(graphics, 540, 350, 35, 35, Brushes.Yellow, Pens.Orange, "23");


            dibujarNodoArbol(graphics, 590, 350, 35, 35, Brushes.Yellow, Pens.Orange, "21");


            dibujarNodoArbol(graphics, 640, 350, 35, 35, Brushes.Yellow, Pens.Orange, "24");

            dibujarNodoArbol(graphics, 690, 350, 35, 35, Brushes.Yellow, Pens.Orange, "29");

            dibujarNodoArbol(graphics, 740, 350, 35, 35, Brushes.Yellow, Pens.Orange, "31");

        }

        private void dibujarInorden(Graphics graphics)
        {
            dibujarNodoArbol(graphics, 140, 400, 35, 35, Brushes.Yellow, Pens.Orange, "2");

            dibujarNodoArbol(graphics, 190, 400, 35, 35, Brushes.Yellow, Pens.Orange, "7");

            dibujarNodoArbol(graphics, 240, 400, 35, 35, Brushes.Yellow, Pens.Orange, "8");

            dibujarNodoArbol(graphics, 290, 400, 35, 35, Brushes.Yellow, Pens.Orange, "9");


            dibujarNodoArbol(graphics, 340, 400, 35, 35, Brushes.Yellow, Pens.Orange, "11");


            dibujarNodoArbol(graphics, 390, 400, 35, 35, Brushes.Yellow, Pens.Orange, "12");


            dibujarNodoArbol(graphics, 440, 400, 35, 35, Brushes.Yellow, Pens.Orange, "18");

            dibujarNodoArbol(graphics, 490, 400, 35, 35, Brushes.Yellow, Pens.Orange, "21");


            dibujarNodoArbol(graphics, 540, 400, 35, 35, Brushes.Yellow, Pens.Orange, "23");


            dibujarNodoArbol(graphics, 590, 400, 35, 35, Brushes.Yellow, Pens.Orange, "24");

            dibujarNodoArbol(graphics, 640, 400, 35, 35, Brushes.Yellow, Pens.Orange, "25");

            dibujarNodoArbol(graphics, 690, 400, 35, 35, Brushes.Yellow, Pens.Orange, "29");

            dibujarNodoArbol(graphics, 740, 400, 35, 35, Brushes.Yellow, Pens.Orange, "31");

        }


        private void dibujarPostOrden(Graphics graphics)
        {

            dibujarNodoArbol(graphics, 140, 450, 35, 35, Brushes.Yellow, Pens.Orange, "2");

            dibujarNodoArbol(graphics, 190, 450, 35, 35, Brushes.Yellow, Pens.Orange, "8");

            dibujarNodoArbol(graphics, 240, 450, 35, 35, Brushes.Yellow, Pens.Orange, "7");

            dibujarNodoArbol(graphics, 290, 450, 35, 35, Brushes.Yellow, Pens.Orange, "11");


            dibujarNodoArbol(graphics, 340, 450, 35, 35, Brushes.Yellow, Pens.Orange, "12");


            dibujarNodoArbol(graphics, 390, 450, 35, 35, Brushes.Yellow, Pens.Orange, "9");


            dibujarNodoArbol(graphics, 440, 450, 35, 35, Brushes.Yellow, Pens.Orange, "21");


            dibujarNodoArbol(graphics, 490, 450, 35, 35, Brushes.Yellow, Pens.Orange, "24");


            dibujarNodoArbol(graphics, 540, 450, 35, 35, Brushes.Yellow, Pens.Orange, "23");


            dibujarNodoArbol(graphics, 590, 450, 35, 35, Brushes.Yellow, Pens.Orange, "31");


            dibujarNodoArbol(graphics, 640, 450, 35, 35, Brushes.Yellow, Pens.Orange, "29");

            dibujarNodoArbol(graphics, 690, 450, 35, 35, Brushes.Yellow, Pens.Orange, "25");

            dibujarNodoArbol(graphics, 740, 450, 35, 35, Brushes.Yellow, Pens.Orange, "18");

        }
    }
}
