using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças.Models
{
    class Aluno : Pessoa
    {
        public string nomeResponsavel { get; set; }
        public int ano { get; set; }

        public void imprimeAluno()
        {
            Console.WriteLine($"nome aluno: {nome}");
            Console.WriteLine($"endereço aluno: {endereco}");
            Console.WriteLine($"telefone aluno: {telefone}");
            Console.WriteLine($"email aluno: {email}");
            Console.WriteLine($"nome responsável: {nomeResponsavel}");
            Console.WriteLine($"ano: {ano}");
        }
    }
}
