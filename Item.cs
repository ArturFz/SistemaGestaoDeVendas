using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1_ProgVis
{
    public class Item
    {
        public UInt64 Id { get; set; }
        public UInt32 Quantidade { get; set; }
        public Decimal PrecoUnitario { get; set; }
        public Decimal Desconto { get; set; }
        public Produto Produto { get; set; }
        public Compra Compra { get; set; }
    }
}
