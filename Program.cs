using System;
using System.Collections.Generic;

namespace desafio001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantos elementos além dos 2 iniciais vc quer? ");
            int quantidade = int.Parse(Console.ReadLine());
            //var idade = int.Parse(Console.ReadLine());

            // for (int i = 0; i < idade; i++)
            // {
            //     Console.WriteLine("nOME");
            //     Console.WriteLine("Idade" + (40 + i));
            // }

            //-------
            var dic = new Dictionary<string, int>();
            dic.Add("Nome1", 10);
            dic.Add("Nome2", 20);
            for (int i = 0; i < quantidade; i++)
            {
                var a = i + 3;
                dic.Add($"Nome{a}", (40 + i));


            }
                foreach (var item in dic)
                {
                    Console.WriteLine(item.Key + " tem " + item.Value + " anos");
                }
            }

            //dic.Add("Nome" + i, (40 + i));
        }
    }

