using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1_ProgVis
{
    public class Compra
    {
        [Key]
        public UInt64 Id { get; set; }
        public UInt64 Inicio { get; set; }
        public DateTime Efetivacao { get; set; }
        public Decimal Comissao { get; set; }

        public Estado _estado = Estado.PENDENTE;
        public Estado Estado
        {
            get => _estado;
            set
            {
                _estado = value;
            }
        }
        public Produto Produto { get; set; }
        public Pagamento Pagamento { get; set; }
    }
}
