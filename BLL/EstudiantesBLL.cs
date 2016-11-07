using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class EstudiantesBLL
    {
        public static bool Insertar(Estudiantes nuevo)
        {
            bool retorno = false;
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    Conexion.Estudiante.Add(nuevo);
                    Conexion.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }
        }

        public static Estudiantes Buscar(int id)
        {
            var Estudiante = new Estudiantes();
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    Estudiante = Conexion.Estudiante.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return Estudiante;
            }
        }

        public static List<Estudiantes> GetList()
        {
            var Lista = new List<Estudiantes>();
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    Lista = Conexion.Estudiante.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                return Lista;
            }
        }

        public static List<Estudiantes> GetList(List<GruposEstudiantes> ge)
        {
            var Lista = new List<Estudiantes>();
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    foreach (var Estudiante in ge)
                    {
                        Lista.Add(Conexion.Estudiante.Find(Estudiante.EstudianteId));
                    }
                    //Lista = Conexion.Estudiante.Where(p => p.EstudiantesId == ge.e);
                }
                catch (Exception)
                {
                    throw;
                }
                return Lista;
            }
        }
    }
}
