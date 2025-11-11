using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1_ProgVis
{
    [Table("Compra")]

    public class Compra
    {
        [Key]
        public UInt64 Id { get; set; }
        public UInt64 Numero { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Efetivacao { get; set; }
        public Decimal Comissao { get; set; }
        public Estado Estado { get; set; } = Estado.PENDENTE;
              
        
        // Relacionamentos
        public Vendedor Vendedor { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
        public List<Item> Itens { get; set; }

    }
}
