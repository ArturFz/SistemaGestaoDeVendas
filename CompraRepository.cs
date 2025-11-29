using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho1_ProgVis;
using Microsoft.EntityFrameworkCore;

namespace Trabalho_TCD
{
    internal class CompraRepository
    {
        public static void SaveOrUpdate(Compra compra)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (compra.Cliente != null && compra.Cliente.Id > 0)
                    {
                        dbContext.Clientes.Attach(compra.Cliente);
                    }
                    if (compra.Vendedor != null && compra.Vendedor.Id > 0)
                    {
                        dbContext.Vendedores.Attach(compra.Vendedor);
                    }

                    if (compra.Itens != null)
                    {
                        foreach (var item in compra.Itens)
                        {
                            if (item.Produto != null && item.Produto.Id > 0)
                            {
                                dbContext.Produtos.Attach(item.Produto);
                            }
                        }
                    }

                    if (compra.Id == 0)
                    {
                        dbContext.Compras.Add(compra);
                    }
                    else
                    {
                        dbContext.Entry(compra).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
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

        public static List<Compra> GetPerPeriod(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Compras
                        .Include(c => c.Vendedor)
                        .Include(c => c.Cliente)
                        .Where(c => c.Inicio >= dataInicio && c.Inicio <= dataFim)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Compra compra)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Compras.Attach(compra);
                    dbContext.Compras.Remove(compra);
                    
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
    