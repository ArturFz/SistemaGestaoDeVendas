using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Trabalho1_ProgVis
{
    public class Repository : DbContext
    {
        private static readonly String _connectionParams = @"server=127.0.0.1;port=3307;uid=root;pwd=;database=Projeto-1-3Tri";

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Credencial> Credenciais { get; set; }

        public Repository()
        {
            if (Database.EnsureCreated())
            {
                Credencial adminCredencial = new Credencial()
                {
                    NomeUsuario = "Admin",
                    Senha = "Senha",
                    Perfil = true
                };
                Usuario usuarioAdmin = new Usuario()
                {
                    Nome = "Admin",
                    Telefone = "12345678911",
                    Email = "admin@gmail.com",
                    Credencial = adminCredencial
                };

                UsuarioRepository.SaveOrUpdate(usuarioAdmin);
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionParams);
        }

        
    }
}