using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._3_LSP
{
    //SOLID - Principios da programação orientada a objeto
    //3) LSP -  Liskov Substitution Principle
    //Classe derivada deve ser substituível por sua classe base
    //Classes não podem interferir na principal classe, mudando o comportamento
    //Não pode herdar, porque são diferentes violando, e gerando um Bug
    public class Teste
    {
        private void TesteQuadrado()
        {
            var quad = new Quadrado();
            quad.Largura = 10;
            quad.Altura = 5;

            ObterAreaRetangulo(quad);
        }

        private void ObterAreaRetangulo(Retangulo quad)
        {
            double area = quad.Area();

            Console.WriteLine(quad.Altura.ToString() + " - " + quad.Largura.ToString());
            Console.WriteLine(area.ToString());
            Console.ReadKey();
        }
    }

}
