﻿using System;
using System.Collections.Generic;

namespace desafio001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantos elementos além dos 2 iniciais vc quer? ");
            int quantidade = int.Parse(Console.ReadLine());
            string nome;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();


            var dic = new Dictionary<string, int>();
            dic.Add($"Nome1: {nome}", 10);
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            dic.Add($"Nome2: {nome}", 20);
            for (int i = 0; i < quantidade; i++)
            {
                var a = i + 3;
                string nomeA;
                Console.WriteLine("Digite seu nome: ");
                nomeA = Console.ReadLine();
                dic.Add($"Nome{a}:{nomeA}", (40 + i));


            }
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " tem " + item.Value + " anos");
            }
        }

        
    }
}