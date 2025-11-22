using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabalho1_ProgVis;

namespace Trabalho_TCD
{
    public class ItemRepository
    {
        public static void SaveOrUpdate(Item item)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (item.Id == 0)
                    {
                        dbContext.Itens.Add(item);
                    }
                    else
                    {
                        dbContext.Entry(item).State
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
        public static List<Item> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Itens.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Item? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Itens.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Item item)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Itens.Attach(item);
                    dbContext.Itens.Remove(item);

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
