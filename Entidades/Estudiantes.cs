using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }

        public List<Grupos> Grupo { get; set; }        

        public Estudiantes(int estudianteID, string nombre)
        {
            this.EstudianteId = estudianteID;
            this.Nombres = nombre;
            this.Grupo = new List<Grupos>();
        }

        public Estudiantes()
        {
            this.Grupo = new List<Grupos>();
        }
    }
}
