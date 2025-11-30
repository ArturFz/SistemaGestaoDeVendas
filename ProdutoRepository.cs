using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabalho1_ProgVis;

namespace Trabalho_TCD
{
    public class ProdutoRepository
    {
        public static void SaveOrUpdate(Produto produto)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (produto.Categoria.Id != null)
                    {
                        if (produto.Categoria.Id != 0)
                        {
                            dbContext.Categorias.Attach(produto.Categoria);
                        }
                        else
                        {
                            produto.Categoria = null;
                        }
                    }
                    
                    
                    if (produto.Id == 0)
                    {
                        dbContext.Produtos.Add(produto);
                    }
                    else
                    {
                        dbContext.Entry(produto).State
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
        public static List<Produto> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Produtos.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Produto? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Produtos.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Produto produto)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Produtos.Attach(produto);
                    dbContext.Produtos.Remove(produto);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Produto> FindAllWithCategoria()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Produtos.Include("Categoria").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Produto> FindByCategoria(UInt64 categoriaId)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {

                    return dbContext.Produtos
                                    .Where(p => p.Categoria != null && p.Categoria.Id == categoriaId)
                                    .Include(p => p.Categoria)
                                    .ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static List<Produto> FindByEstoqueMinimo()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Produtos
                        .Include(p => p.Categoria)
                        .Where(p => p.Estoque <= p.EstoqueMinimo)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Produto> FindByEstoqueMinimoWithCategoria()
        {
            using (var db = new Repository())
            {
                return db.Produtos
                         .Include(p => p.Categoria) // força o carregamento da categoria
                         .Where(p => p.Estoque <= p.EstoqueMinimo)
                         .ToList();
            }
        }

    }
}
