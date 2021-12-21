using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._2_OCP
{
    //SOLID - Principios da programação orientada a objeto
    //1) OCP - Open Closed Principle
    //Principio Aberto e Fechado
    //Facilidade de estender funcionalidades
    //Não precisamos alterar todo o código ou modifica-lo, apenas adicionar recursos
    //Extender através de uma interface ou abastração, ex. para inverter as dependendecias
    public abstract class Debito
    {
        public string? NumeroTransacao { get; set; }

        public abstract string Debitar(decimal valor, string conta);
    }
}
