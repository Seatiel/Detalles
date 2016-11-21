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

            try
            {
                var db = new DetallesDb();

                db.Grupo.Add(nuevo);
                foreach (var estudiante in nuevo.Estudiante)
                {
                    db.Entry(nuevo).State = System.Data.Entity.EntityState.Unchanged;
                }
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public static Grupos Buscar(int grupoId)
        {
            Grupos grupo;
            using (var Conexion = new DetallesDb())
            {
                try
                {
                    grupo = Conexion.Grupo.Find(grupoId);
                    grupo.Estudiante.Count();
                }
                catch (Exception)
                {
                    throw;
                }
                return grupo;
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
