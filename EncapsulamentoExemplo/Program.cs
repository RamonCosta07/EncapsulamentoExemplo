using System;

namespace EncapsulamentoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // valores válidos
            Retângulo r = new Retângulo();
            r.DefinirMedidas(30, 30);
            Console.WriteLine($"Área de R: {r.ObterArea()}");
            Console.WriteLine("**************************");

            //valores inválidos
            Retângulo s = new Retângulo();
            s.DefinirMedidas(-30, 0);
            Console.WriteLine($"Área de S: {s.ObterArea()}");
            Console.WriteLine("**************************");

        }
    }
}
