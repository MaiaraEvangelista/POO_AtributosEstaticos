using System;

namespace Atributos_estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Classes estáticas não podem ser instânciadas

            //Quando usamos as classes estáticas?
            //RESPOTA: Quando precisamos de uma solução que serve para qualquer aplicação.

            //Quando não usamos as Classes estáticas?
            //RESPOSTA: Quando temos classes específicas de um tipo de aplicação.

            Console.WriteLine( Math.Pow(2,5));

            Console.WriteLine(Conversor.ConverterDolarParaReal(3f));
            Console.WriteLine( Conversor.ConverterRealParaDolar(200f));

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" Uma outra conversão");
            Console.WriteLine("----------------------------------------------");


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Math.Pow(4,2));
            Console.WriteLine(Conversor.ConverterEuroParaReal(65f));
            Console.WriteLine(Conversor.ConverterRealParaEuro(400f));




        }
    }
}
