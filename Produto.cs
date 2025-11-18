using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_TCD;

namespace Trabalho1_ProgVis
{
    public class Produto
    {
        [Key]
        public UInt64 Id { get; set; }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }
        public UInt32 Estoque { get; set; }
        public UInt32 EstoqueMinimo { get; set; } = 10;
        public Boolean Ativo { get; set; } = true;
        public Categoria Categoria { get; set; }
    }
}
