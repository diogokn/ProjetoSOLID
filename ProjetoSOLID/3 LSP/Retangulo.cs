using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._3_LSP
{
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }
        public double Area()
        {
            return Altura * Largura;
        }
    }
}
