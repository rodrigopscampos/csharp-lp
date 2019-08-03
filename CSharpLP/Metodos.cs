using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLP
{
    public static class Metodos
    {
        //Implemente um método LerInt(), que lê uma 
        //linha do console e converte o valor para int

        public static int LerInt()
        {
            string texto = Console.ReadLine();
            int n = int.Parse(texto);
            return n;
        }

        //Implemente um método Somar, que soma três números inteiros
        public static int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        //Implemente um método PrintarEmAzul que receba uma string 
        //e a imprime em azul.
        public static void PrintarEmAzul(string texto)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(texto);
            Console.ResetColor();
        }

        //Implemente um método EPositivo que recebe 
        //um número e diz se é positivo ou não.
        public static bool EhPositivo(int n)
        {
            return !EhNegativo(n);
        }

        public static bool EhNegativo(int n)
        {
            return !EhPositivo(n);
        }

        //Implementei um método CategorizarLetras que recebe um array de char 
        //e informa quantas vogais e quantas consoantes o texto contém.

        public static bool EstaContido(char[] array, char amosta)
        {
            amosta = Convert.ToChar(amosta.ToString().ToLower());

            foreach (var item in array)
            {
                if (item == amosta)
                {
                    return true;
                }
            }

            return false;
        }

        public static int[] CategorizarLetras(string texto)
        {
            int v = 0;
            int c = 0;

            char[] vogais = new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (char caracter in texto)
            {
                if (EstaContido(vogais, caracter))
                {
                    v++;
                }
                else
                {
                    c++;
                }
            }

            return new int[] { v, c };
        }

        //public static void Main(string[] args)
        //{
        //    int n = 0;

        //    if (EhPositivo(n))
        //    {

        //    }
        //    else
        //    {

        //    }
        //}
    }

}
