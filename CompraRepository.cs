using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho1_ProgVis;

namespace Trabalho_TCD
{
    internal class CompraRepository
    {
        public static void SaveOrUpdate (Compra compra)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (compra.Id == 0)
                    {
                        dbContext.Compras.Add(compra);
                    }
                    else
                    {
                        dbContext.Entry(compra).State
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
        public static List<Compra> FindAll()
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    return dbContext.Compras.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Compra FindById (UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Compras.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}
