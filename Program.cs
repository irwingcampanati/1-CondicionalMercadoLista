using System;
using System.Collections.Generic;
using System.Collections;

namespace Condicionalidade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Para iniciarmos a sua compra, nos diga seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Para uma lista personalizada, digite sua idade: ");
            float idade = float.Parse(Console.ReadLine());
            Console.Clear();

            List<string> listaDeMercado = new List<string>() { "Macarrão ", "Arroz " };
            if (idade >= 18)
            {
                listaDeMercado.Add("Heineken");
                Console.WriteLine(nome);
                Console.WriteLine(idade);
                Console.WriteLine(listaDeMercado[0]);
                Console.WriteLine(listaDeMercado[1]);
                Console.WriteLine(listaDeMercado[2]);
            }
            else
            {
                Console.WriteLine(nome);
                Console.WriteLine(idade);
                Console.WriteLine(listaDeMercado[0]);
                Console.WriteLine(listaDeMercado[1]); ;
            }
        }
    }
}
