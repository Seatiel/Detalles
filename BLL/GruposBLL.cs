using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class GruposBLL
    {
        public static bool Insertar(Grupos nuevo)
        {
            bool retorno = false;
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    Conexion.Grupo.Add(nuevo);
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

        public static Grupos Buscar(int GrupoId)
        {
            var Grupo = new Grupos();
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    Grupo = Conexion.Grupo.Find(GrupoId);
                }
                catch (Exception)
                {
                    throw;
                }
                return Grupo;
            }
        }

        public static List<Grupos> GetList(List<GruposEstudiantes> p)
        {
            var Lista = new List<Grupos>();
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    foreach (var Estudiante in p)
                    {
                        Lista.Add(Conexion.Grupo.Find(Estudiante.EstudianteId));
                    }
                    //Lista = Conexion.Grupo.Where(p => p.Estudiante)
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
