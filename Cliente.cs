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
        public List<Compra> Compras { get; set; }

        public Boolean PodeRealizarNovaCompra(Boolean autorizadoGerente = false)
        {
            if (this.Compras == null || !this.Compras.Any())
            {
                return true;
            }

            foreach (var compra in this.Compras)
            {
                if (compra == null) continue;
                if (compra.Estado == Estado.CANCELADA) continue;
                if (compra.Pagamentos == null || !compra .Pagamentos.Any()) continue;

                var existeParcelaVencidaNaoQuitada = compra.Pagamentos.Any(p =>
                    p.Vencimento < DateTime.Now &&
                    (p.DataPagamento == default(DateTime) || p.DataPagamento == DateTime.MinValue)
                );

                if (existeParcelaVencidaNaoQuitada)
                {
                    if (autorizadoGerente)
                    {
                        return true;
                    }
                    return false;
                }
            }

            return true;
        }
    }
}
