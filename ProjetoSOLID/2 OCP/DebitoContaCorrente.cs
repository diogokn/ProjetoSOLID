using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._2_OCP
{
    public abstract class DebitoContaCorrente: Debito
    {
        public override string Debitar(decimal valor, string conta)
        {
            //TODO: Implements

            return NumeroTransacao;
        }
    }
}
