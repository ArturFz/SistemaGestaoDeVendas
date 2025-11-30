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
        public DateTime? Efetivacao { get; set; }
        public Decimal Comissao { get; set; }
        public Estado Estado { get; set; } = Estado.PENDENTE;
              
        // Relacionamentos
        public Vendedor? Vendedor { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
        public List<Item> Itens { get; set; }
        public Cliente Cliente { get; set; }

        public Compra()
        {
            Pagamentos = new List<Pagamento>();
            Itens = new List<Item>();
            Inicio = DateTime.Now;
            Estado = Estado.PENDENTE;
        }

        public Decimal CalcularTotal()
        {
            if (Itens == null || Itens.Count == 0)
            {
                return 0;
            }

            Decimal total = 0;
            foreach (var item in Itens)
            {
                if (item == null) continue;
                total += item.CalcularTotal();
            }
            // Arredonda total da compra para 2 casas também
            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public Decimal CalcularComissao()
        {
            var comissao = CalcularTotal() * 0.01m;
            return Math.Round(comissao, 2, MidpointRounding.AwayFromZero);
        }

        public void AdicionarItem(Item item)
        {
            if (item == null) return;
            // garante vínculo bidirecional
            item.Compra = this;
            Itens.Add(item); 
        }
        public void RemoverItem(Item item)
        {
            if (item == null) return;
            Itens.Remove(item);
            item.Compra = null;
        }

    }
}
