using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabalho1_ProgVis;
using System.ComponentModel;

namespace Trabalho_TCD
{
    public class CategoriaRepository
    {
        public static void SaveOrUpdate(Categoria categoria)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (categoria.Id == 0)
                    {
                        dbContext.Categorias.Add(categoria);
                    }
                    else
                    {
                        dbContext.Entry(categoria).State
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
        public static List<Categoria> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Categorias.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Categoria? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Categorias.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Categoria categoria)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Categorias.Attach(categoria);
                    dbContext.Categorias.Remove(categoria);

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
