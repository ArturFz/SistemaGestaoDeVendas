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
        public Compra Compra { get; set; }

        public Boolean PodeRealizarNovaCompra()
        {
            if (this.Compra == null || this.Compra.Pagamentos == null || !this.Compra.Pagamentos.Any())
            {
                return true;
            }
            else if (this.Compra.Pagamentos.Any(p => p.Vencimento < DateTime.Now))
            {
                return false;
            }
            return true;
        }
    }
}
