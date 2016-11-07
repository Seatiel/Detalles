using DAL;
using Entidades;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TareaDetalles.UI.Registros
{
    public partial class RegistroGrupos : Form
    {
        List<GruposEstudiantes> GrupoEstuduante;
        List<Estudiantes> Estudiante;

        private Grupos grupo = new Grupos();

        public RegistroGrupos()
        {
            InitializeComponent();
            GrupoEstuduante = new List<GruposEstudiantes>();
            Estudiante = new List<Estudiantes>();
            ListarEstudiantes();
        }

        private void ListarEstudiantes()
        {
            DetallesDb Conexion = new DetallesDb();
            var Lista = Conexion.Estudiante.ToList();
            if (Lista.Count > 0)
            {
                NombreGrupocomboBox.DataSource = Lista;
                NombreGrupocomboBox.ValueMember = "EstudianteId";
                NombreGrupocomboBox.DisplayMember = "Nombres";
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            GruposdataGridView.DataSource = null;
            int GrupoId;
            int.TryParse(GrupoIdtextBox.Text, out GrupoId);
            GrupoEstuduante.Add((new GruposEstudiantes() { EstudianteId = (int)NombreGrupocomboBox.SelectedValue, GrupoId = GrupoId }));
            Estudiante.Add(EstudiantesBLL.Buscar((int)NombreGrupocomboBox.SelectedValue));
            GruposdataGridView.DataSource = Estudiante;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            GruposdataGridView.DataSource = null;
            int Id;
            int.TryParse(GrupoIdtextBox.Text, out Id);
            var grupo = GruposEstudiantesBLL.GetList(Id);
            var estudiante = EstudiantesBLL.GetList(grupo);
            GruposdataGridView.DataSource = estudiante; 
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Complete los Campos");
                return;
            }

            int Id;
            int.TryParse(GrupoIdtextBox.Text, out Id);
            GruposEstudiantesBLL.Insertar(GrupoEstuduante);
            GruposBLL.Insertar(new Grupos(Id, NombreGrupotextBox.Text));
        }

        private bool Validar()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(GrupoIdtextBox.Text))
            {
                GrupoIderrorProvider.SetError(GrupoIdtextBox, "Debe introducir el ID del Grupo");
                NombreGrupoerrorProvider.SetError(NombreGrupotextBox, "Debe introducir el Nombre del Grupo");

                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            GrupoIdtextBox.Text = NombreGrupotextBox.Text = "";
        }
    }
}
