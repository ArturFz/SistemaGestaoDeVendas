using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho1_ProgVis
{
    public class Vendedor : Usuario
    {
        public UInt32 Matricula { get; set; }
        public List<Compra> Compras { get; set; }
    }
}
