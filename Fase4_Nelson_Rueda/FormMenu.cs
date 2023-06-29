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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void mostrarForm(Type formType)
        {
            Form formInstance = (Form)Activator.CreateInstance(formType);
            formInstance.Show();
        }
        private void escenario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormEscenario1));
        }

        private void escenario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormEscenario2));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
