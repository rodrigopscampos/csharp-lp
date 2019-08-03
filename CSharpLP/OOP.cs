using System;

namespace CSharpLP.OOP
{
    //Crie uma classe Calculadora, com os métodos Somar, 
    //Subtrair, Multiplicar e Dividir. Utilize os métodos.

    public static class Calculadora
    {
        public static int Somar(int a, int b)
            => a + b;

        public static int Subtrair(int a, int b)
            => a - b;

        public static int Multiplicar(int a, int b)
            => a * b;

        public static int Dividir(int a, int b)
            => a / b;
    }

    //Crie um classe Pessoa com o nome e idade e o método 
    //Comprimentar que printa “Olá, eu sou {nome} e tenho {idade} anos”, 
    //crie uma instância e utilize os métodos

    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Comprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos");
        }

    }

    //Crie uma classe SuperConsole, com os métodos ReadInt, 
    //que lê uma linha e devolve o valor convertido para int.

    public static class SuperConsole
    {
        public static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static int PedirPorInt(string texto)
        {
            Console.WriteLine(texto);
            return ReadInt();
        }
    }
}
