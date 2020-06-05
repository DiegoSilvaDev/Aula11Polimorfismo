using System;

namespace Polimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoPlayer= new Calculo();

            // 1º opção, sem argumentos
            Console.WriteLine(infoPlayer.CalcularVida());
            // 2º opção, com 1 argumento int
            Console.WriteLine(infoPlayer.CalcularVida(100));
            // 3 opção, com 2 argumentos int
            Console.WriteLine(infoPlayer.CalcularVida(100, 40));
            // 4 opção, com 2 argumentos string
            Console.WriteLine(infoPlayer.CalcularVida("Paulo", "Brandão"));
        }
    }
}
