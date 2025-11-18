using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1_ProgVis
{
    public class Item
    {
        private Produto _produto;
        public Produto Produto
        {
            get => _produto;
            set
            {
                _produto = value;
                PrecoUnitario = _produto.Preco;
            }
        }
        public Compra Compra { get; set; }
        
        public UInt64 Id { get; set; }
        public UInt32 Quantidade { get; set; }
        public Decimal PrecoUnitario { get; set; }
        public Decimal Desconto { get; set; }

        public Decimal CalcularTotal()
        {
            var subtotal = PrecoUnitario * Quantidade;
            var desconto = Desconto/100* subtotal;
            var total = subtotal - Desconto;
            return total;
        }
    }
}
