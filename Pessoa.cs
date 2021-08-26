using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio002
{
    public class Pessoa
    {
        //- nome
        public string Nome { get; set; }
        //- Idade
        public int Idade { get; set; }

        public DateTime DataNascimento { get; set;}

        //public bool SexoGenero { get; set;}
        public string Masculino (bool Genero){
            Genero = true;
            string textoReturn = "";
            if (Genero)
            {
                textoReturn += "Masculino";
            }

            return textoReturn;
        }





        //- RA
        public int RA { get; set; }
        //- CPF
        public string Cpf { get; set; }
        //- Formado(sim ou não)
        public string Formado { get; set; }

    }
    public class IdadeNascimento
    {

    }
}
