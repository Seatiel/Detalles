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
    public partial class RegistroEstudiantes : Form
    {
        public RegistroEstudiantes()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var Estudiante = new Estudiantes();

            if (!Validar())
            {
                MessageBox.Show("Complete los Campos");
                return;
            }

            Estudiante.EstudianteId = Convert.ToInt32(EstudianteIdtextBox.Text);
            Estudiante.Nombres = NombreEstudiantetextBox.Text;          
            
            if (EstudiantesBLL.Insertar(Estudiante))
            {
                MessageBox.Show("Guardado");
            }
        }

        private bool Validar()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(EstudianteIdtextBox.Text))
            {
                EstudianteIderrorProvider.SetError(EstudianteIdtextBox, "Debe introducir el ID del estudiante");
                NombreEstudianteerrorProvider.SetError(NombreEstudiantetextBox, "Debe introducir el Nombre del Estudiante");

                retorno = false;
            }
            return retorno;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            EstudiantesdataGridView.DataSource = null;
            int Id;
            int.TryParse(EstudianteIdtextBox.Text, out Id);
            var Estudiante = EstudiantesBLL.Buscar(Id);

            if (Estudiante != null)
            {
                var GrupoEstudiante = GruposEstudiantesBLL.GetList(Estudiante.EstudianteId);
                var Grupo = GruposBLL.GetList(GrupoEstudiante);
                NombreEstudiantetextBox.Text = Estudiante.Nombres;
                EstudiantesdataGridView.Visible = true;
                EstudiantesdataGridView.DataSource = Grupo;
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            EstudianteIdtextBox.Text = NombreEstudiantetextBox.Text = "";
        }
    }
}
