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
                try
                {
                    total += item.CalcularTotal();
                }
                catch
                {
                    Decimal precoUnitario = item.PrecoUnitario;
                    Decimal quantidade = item.Quantidade;
                    Decimal desconto = item.Desconto;
                    total += item.CalcularTotal();
                }
            }
        return total;
        }

        public Decimal CalcularComissao()
        {
            var comissao = CalcularTotal() * 0.01m;
            return comissao;
        }
        public void AdicionarItem(Item item)
        {
            Itens.Add(item); 
        }
        public void RemoverItem(Item item)
        {
            Itens.Remove(item);  
        }

    }
}
