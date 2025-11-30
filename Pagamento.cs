using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho1_ProgVis
{
    public class Pagamento
    {
        public UInt64 Id { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public Decimal MultaAtraso { get; set; }


    }
}
