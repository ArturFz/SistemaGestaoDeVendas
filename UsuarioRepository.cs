using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Trabalho1_ProgVis
{
    public class UsuarioRepository
    {
        public static void SaveOrUpdate(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (usuario.Id == 0)
                    {
                        dbContext.Usuarios.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State
                            = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Usuario> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario? FindByIdWithCredencial(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios.Include(u => u.Credencial).FirstOrDefault(u => u.Id == id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Usuario> FindAllWithCredencial()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios.Include("Credencial").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Usuarios.Attach(usuario);
                    dbContext.Usuarios.Remove(usuario);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
