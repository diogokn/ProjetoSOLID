using ProjetoSOLID._1_SRP;

namespace ProjetoSOLID
{
    //SOLID - Principios da programação orientada a objeto
    //1) SRP - Single Responsability Principe
    //Principio da responsabilidade única
    //A classe deve ter um e apenas um motivo para ser modificada, ou seja, apena uma responsabilidade
    //Não deve assumir responsabilidade que não são suas
    //Facilidade para testes automatizados
    //Reaproveitamento do código
    //Buscar e tornar mais simples de expansão
    public class Segurado
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public bool Validar()
        {
            bool validar = false;

            if (CPFServices.ValidarCPF(CPF) && EmailServices.ValidarEmail(Email))
                validar = true;

            return validar;
        }

    }
}