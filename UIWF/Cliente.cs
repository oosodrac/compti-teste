using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWF
{
    class Cliente
    {
        public String Codigo { get; set; }
        public String Nome { get; set; }
        public Decimal Iva { get; set; }
        public Decimal Desconto { get; set; }
        public String CondicaoPagamento { get; set; }
        public String ModoPagamento { get; set; }
        public Decimal ValorCredito { get; set; }
        public String Facturacao { get; set; }
        public Boolean Anulado { get; set; }
        public DateTime DataCriacao { get; set; }

        public Cliente()
        {
            this.DataCriacao = DateTime.Now;
            this.Facturacao = Faturacao.MODERADO.ToString();
            this.Anulado = false;

        }
    }
}
