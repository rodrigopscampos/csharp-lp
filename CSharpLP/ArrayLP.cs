using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpLP
{
    public class ArrayLP
    {
        public static void Array_Ex1()
        {
            //Crie um array de inteiros de comprimento 10000 
            //e preencha com os números de 1 a 10000

            int[] numeros = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                numeros[i] = i + 1;
                Console.WriteLine(numeros[i]);
            }

            Console.ReadLine();
        }

        public static void Array_Ex2()
        {
            //Crie um array de tamanho informado pelo usuário,
            //preencha e imprima o conteúdo do array

            Console.Write("Informe a quantidade: ");
            int qtdade = int.Parse(Console.ReadLine());

            string[] itens = new string[qtdade];

            for (int i = 0; i < qtdade; i++)
            {
                Console.Write($"Item {i + 1} de {qtdade}: ");
                itens[i] = Console.ReadLine();
            }

            Console.WriteLine("I" +
                "tens: ");

            for (int i = 0; i < qtdade; i++)
            {
                Console.WriteLine(itens[i]);
            }

            Console.ReadLine();
        }

        public static void Array_Ex3()
        {
            //Implemente um algoritmo que percorra uma string e 
            //imprima apenas os números

            string texto = "aspnetmvc1320000";
            int contador = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];

                if (char.IsNumber(c))
                {
                    contador++;
                }
            }

            Console.WriteLine(contador);
            Console.ReadLine();
        }

        public static void Array_Ex4()
        {
            //Implemente um algoritmo que encontra o maior
            //e o menor número de um array

            int[] numeros = new int[] { 1, 1, 2, 3, 4, 7, -100, 200 };

            int maior = numeros[0];
            int menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                int n = numeros[i];

                if (maior < n)
                {
                    maior = n;
                }

                if (menor > n)
                {
                    menor = n;
                }
            }
        }

        public static void Array_Ex05()
        {
            //Implemente um algoritmo que ordena um array

            int[] numeros = new[] { 100, 5, 3, 1, 7, 8, 10, -100 };

            Console.WriteLine(numeros);

            Console.ReadLine();

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            foreach (var item in numeros)
            {
                Console.Write(item + " ");
            }

            int fim = 1;
            while (true)
            {
                bool ordenado = true;
                for (int e = 0; e < numeros.Length - fim; e++)
                {
                    int d = e + 1;

                    if (numeros[d] < numeros[e])
                    {
                        int aux = numeros[d];
                        numeros[d] = numeros[e];
                        numeros[e] = aux;
                        ordenado = false;
                    }
                }

                if (ordenado == true)
                {
                    break;
                }

                fim++;

                Console.WriteLine();
                foreach (var item in numeros)
                {
                    Console.Write(item + " ");
                }
            }





            Console.ReadLine();
        }

        public static void Foreach_Ex01()
        {
            //Percorra um array e imprima o valor de cada item utilizando foreach
            int[] array = new[] { 1, 1, 2, 2, 3, 4, 5 };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void Foreach_Ex02()
        {
            //Some o valor de todos os ítens de um array de int
            int[] array = new[] { 1, 1, 2, 2, 3, 4, 5 };

            int soma = 0;
            foreach (var item in array)
            {
                soma += item;
            }

            Console.WriteLine(soma);
        }

        public static void Foreach_Ex03()
        {
            //Implemente um algoritmo que imprima um array de maneira agradável

            int[] array = new[] { 1, 1, 2, 2, 3, 4, 5 };

            Console.Write("[");
            bool item1 = true;
            foreach (var item in array)
            {
                if (item1)
                {
                    Console.Write(item);
                    item1 = false;
                }
                else
                {
                    Console.Write(", " + item);
                }
            }
            Console.Write("]");
        }

        public static void Foreach_Ex04_ModoRaiz()
        {
            //Percorra um array e encontre todos os números repetidos, depois,
            //monte um novo array com apenas um item de cada.

            int[] entrada = new[] { 10, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            Console.WriteLine("[" + string.Join(", ", entrada) + "]");
            Console.WriteLine();

            //O primeiro passo é ordenar o array, para não escrever todo o bloco de laço
            //vou utilizar o OrderBy, que faz isso mais fácil
            //(apenas para economizar linhas, porque o foco não é ordenação)
            entrada = entrada.OrderBy(i => i).ToArray();

            Console.WriteLine("Repetidos: ");
            for (int a = 0; a < entrada.Length - 1; a++)
            {
                int b = a + 1;
                int qtdOcorrencias = 1;

                while (entrada[a] == entrada[b])
                {
                    qtdOcorrencias++;
                    b++;
                }

                if (qtdOcorrencias > 1)
                {
                    Console.WriteLine("Item: " + entrada[a] + " Quantidade: " + qtdOcorrencias);
                    a = b - 1;
                }
            }

            Console.WriteLine("Limpo: ");
            for (int a = 0; a < entrada.Length;)
            {
                int b = a + 1;
                if (b < entrada.Length)
                {
                    while (entrada[a] == entrada[b])
                    {
                        b++;
                    }
                }

                Console.WriteLine(entrada[a]);
                a = b;
            }
        }

        public static void Foreach_Ex04_ModoNutella()
        {
            //Percorra um array e encontre todos os números repetidos, depois,
            //monte um novo array com apenas um item de cada.

            int[] entrada = new[] { 10, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            Console.WriteLine("[" + string.Join(", ", entrada) + "]");
            Console.WriteLine();

            var repetidos = entrada
                .GroupBy(i => i)
                .Where(item => item.Count() > 1);

            Console.WriteLine("Repetidos: ");
            foreach (var item in repetidos)
            {
                Console.WriteLine("Item: " + item.Key + " Quantidade: " + item.Count());
            }

            entrada = entrada.Distinct().ToArray();

            Console.WriteLine("Limpo: ");
            foreach (var item in entrada)
            {
                Console.WriteLine(item);
            }
        }
    }
}
