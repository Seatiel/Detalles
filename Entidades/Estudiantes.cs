using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Estudiantes
    {
        private int selectedValue;

        [Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }

        //public virtual ICollection<Grupos> Grupos { get; set; }

        public Estudiantes(int estudianteId, string nombres)
        {
            this.EstudianteId = estudianteId;
            this.Nombres = nombres;
            //this.Grupos = new HashSet<Grupos>();
        }

        public Estudiantes()
        {
            //this.Grupos = new HashSet<Grupos>();
        }

        public Estudiantes(int selectedValue)
        {
            this.selectedValue = selectedValue;
        }
    }
}
