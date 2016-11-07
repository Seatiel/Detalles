using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class GruposEstudiantesBLL
    {
        public static bool Insertar(List<GruposEstudiantes> nuevo)
        {
            bool retorno = false;
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    foreach (var Estudiante in nuevo)
                    {
                        Conexion.GruposEstudiantes.Add(Estudiante);
                    }
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

        public static List<GruposEstudiantes> GetList(int grupoId)
        {
            var Lista = new List<GruposEstudiantes>();
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    Lista = Conexion.GruposEstudiantes.Where(ge => ge.GrupoId == grupoId).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                return Lista;
            }
        }

        public static List<GruposEstudiantes> GetListEsttudiantes(int estudianteId)
        {
            var Lista = new List<GruposEstudiantes>();
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    Lista = Conexion.GruposEstudiantes.Where(ge => ge.EstudianteId == estudianteId).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return Lista;
        }
    }
}
