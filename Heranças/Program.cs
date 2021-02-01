using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranças.Models;

namespace Heranças
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor Lucas = new Professor();
            Lucas.salario = 1200;
            Lucas.periodo = "noturno";
            Lucas.nome = "lucas da silva";
            Lucas.endereco = "rua das capivaras";
            Lucas.telefone = "99999-2323";
            Lucas.email = "lucas@gmail.com";
            Lucas.imprimeProfessor();

            Coordenador Luiz = new Coordenador();
            Luiz.nome = "luiz pereira";
            Luiz.endereco = "rua das cascatas";
            Luiz.telefone = "33333-2323";
            Luiz.email = "luiz@gmail.com";
            Luiz.salario = 1300;
            Luiz.periodo = "integral";
            //Luiz.cursos.<Curso>;
            Luiz.imprimeCoordenador();


            Aluno vinicius = new Aluno();
            vinicius.nome = "vinicius donschen";
            vinicius.endereco = "rua henrique michels";
            vinicius.telefone = "999-1232";
            vinicius.email = "vinicius@gmail.com";
            vinicius.nomeResponsavel = "ana";
            vinicius.ano = 1999;
            vinicius.imprimeAluno();

            ProfessorAssistente julia = new ProfessorAssistente();
            julia.nome = "julia da silva";
            julia.endereco = "rua das pedras";
            julia.telefone = "33332-2323";
            julia.email = "julia@gmail.com";
            julia.conhecimentos = "C#, SQL, Java";
            julia.imprimeAssistente();

        }
    }
}
