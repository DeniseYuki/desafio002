using Desafio002;
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
            var p = new Pessoa();
            p.Nome = "joão";
            p.Idade = 12;
            //arrumar a data de nascimento
            p.DataDeNascimento = 03/08/1990;
            // Cpf é string 
            p.Cpf = 123456789;
            p.RA = 17024269;
            // bool 
            p.Sexo = "masculino";
            p.Formado = "sim";

            var listP = new List<Pessoa>();
            listP.Add(p);

            foreach (var Cadastro in listP)
                Console.WriteLine(Cadastro.Nome + Cadastro.RA) ;


            for (int i = 0; i < quantidade; i++)
            {
                var p2 = new Pessoa();
                p2.Nome = $"joão {i}";
                p2.Idade =10+ i;


                var a = i + 3;
                listP.Add(p2);


            }
            foreach (var aluno in listP)
            {
                Console.WriteLine(aluno.Nome + " tem " + aluno.Idade + " anos");
            }
        }

        //dic.Add("Nome" + i, (40 + i));
    }
}