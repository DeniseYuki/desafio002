using Desafio002;
using System;
using System.Collections.Generic;

namespace desafio001
{
    class Program
    {
        public static object Cadastro { get; private set; }

        static void Main(string[] args)
        {

            Console.WriteLine("quantos elementos além dos 2 iniciais vc quer? ");
            int quantidade = int.Parse(Console.ReadLine());
           
            var p = new Pessoa();
                p.Nome = "joão";
                p.Idade = 12;
           // Pessoa IdadeNascimento = new Pessoa();
                p.DataNascimento = new DateTime(1990, 08, 02);

                p.Cpf = "123456789";

                p.RA = 17024269;

                //p.SexoGenero(true);

                Console.WriteLine(p.SexoGenero(true));
                p.Formado = "sim";

            var listP = new List<Pessoa>();
            listP.Add(p);

            foreach (var Cadastro in listP)
                Console.WriteLine(Cadastro.Nome + Cadastro.RA + Cadastro.DataNascimento); //Cadastro.SexoGenero) ;
                //Console.WriteLine(SexoGenero);

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
                Console.WriteLine(p.SexoGenero(true));
                Console.WriteLine(aluno.Nome + " tem " + aluno.Idade + " anos");
                //return textoReturn;
            }
        }





        //dic.Add("Nome" + i, (40 + i));
    }
}