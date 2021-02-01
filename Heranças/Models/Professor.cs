using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças.Models
{
    class Professor : Pessoa 
    {
        public double salario { get; set; }
        public string periodo { get; set; }

        public void imprimeProfessor()
        {
            Console.WriteLine($"nome professor: {nome}");
            Console.WriteLine($"endereço professor: {endereco}");
            Console.WriteLine($"telefone professor: {telefone}");
            Console.WriteLine($"email professor: {email}");
            Console.WriteLine($"salario professor: {salario}");
            Console.WriteLine($"periodo professor: {periodo}");
        }

    }
}
