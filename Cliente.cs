using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_TCD;

namespace Trabalho1_ProgVis
{
    public class Cliente
    {
        public UInt64 Id { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
    }
}
