using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Trabalho1_ProgVis
{
    internal class CredencialRepository
    {
        public static void SaveOrUpdate(Credencial credencial)
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    if (credencial.Id == 0)
                    {
                        dbContext.Credenciais.Add(credencial);
                    }
                    else
                    {
                        dbContext.Entry(credencial).State
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

        public static List<Credencial> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Credenciais.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove (Credencial credencial)
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    dbContext.Credenciais.Attach(credencial);
                    dbContext.Credenciais.Remove(credencial);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Credencial FindById(Int64 Id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Credenciais.Find(Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Credencial> FindAllWithUsuario()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Credenciais.Include("Usuario").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
