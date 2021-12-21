using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._1_SRP
{
    public static class CPFServices
    {
        public static bool ValidarCPF(string cpf)
        {
            bool validarEmail = false;

            //TODO: Testes
            if (cpf != null && cpf.Length == 11)
                validarEmail = true;

            return validarEmail;
        }
        
    }
}
