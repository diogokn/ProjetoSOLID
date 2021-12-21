using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._1_SRP
{
    public static class EmailServices
    {
        //Validar apenas o e-mail
        public static bool ValidarEmail(string email)
        {
            bool validarEmail = false;

            //TODO: Testes
            if (email != null && email.Contains("@"))
                validarEmail = true;

            return validarEmail;
        }

    }
}
