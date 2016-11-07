using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TareaDetalles
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TareaDetalles.UI.Registros.RegistroEstudiantes re = new UI.Registros.RegistroEstudiantes();
            re.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TareaDetalles.UI.Registros.RegistroGrupos rg = new UI.Registros.RegistroGrupos();
            rg.Show();
        }
    }
}
