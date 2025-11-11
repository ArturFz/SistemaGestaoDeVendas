using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabalho1_ProgVis;

namespace Trabalho_TCD
{
    public class VendedorRepository
    {
        public static void SaveOrUpdate(Vendedor vendedor)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (vendedor.Id == 0)
                    {
                        dbContext.Vendedores.Add(vendedor);
                    }
                    else
                    {
                        dbContext.Entry(vendedor).State
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
        public static List<Vendedor> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Vendedores.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Vendedor? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Vendedores.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Vendedor vendedor)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Vendedores.Remove(vendedor);
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
