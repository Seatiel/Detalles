using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public string Nombres { get; set; }

        public List<Estudiantes> Estudiante { get; set; }

        public Grupos(int grupoId, string nombresGrupos)
        {
            this.GrupoId = grupoId;
            this.Nombres = nombresGrupos;
            this.Estudiante = new List<Estudiantes>();   

        }

        public Grupos()
        {
            this.Estudiante = new List<Estudiantes>();
        }
    }
}
