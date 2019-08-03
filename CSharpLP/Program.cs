using System;

namespace CSharpLP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro número: ");
            int a = Metodos.LerInt();

            bool positivo = Metodos.EhPositivo(a);
           
            Metodos.PrintarEmAzul(positivo.ToString());

            Console.ReadLine();
        }
    }
}
