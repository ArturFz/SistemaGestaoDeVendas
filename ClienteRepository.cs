using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Trabalho1_ProgVis
{
    public class ClienteRepository
    {
        public static void SaveOrUpdate(Cliente cliente)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (cliente.Id == 0)
                    {
                        dbContext.Clientes.Add(cliente);
                    }
                    else
                    {
                        dbContext.Entry(cliente).State
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
        public static List<Cliente> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Clientes.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Cliente? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Clientes.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Cliente? FindByEmail(string email)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Clientes
                        .FirstOrDefault(c => c.Email == email);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Cliente? FindByTelefone(string telefone)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Clientes
                        .FirstOrDefault(c => c.Telefone == telefone);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Cliente? FindByNome(string nome)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Clientes.FirstOrDefault(c => c.Nome == nome);
                }
            }
            catch (Exception) { throw; }
        }
        public static bool ExistsByEmail(string email)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Clientes.Any(c => c.Email == email);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Cliente cliente)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Clientes.Attach(cliente);
                    dbContext.Clientes.Remove(cliente);

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