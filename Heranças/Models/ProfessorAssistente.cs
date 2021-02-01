using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças.Models
{
    class ProfessorAssistente : Professor
    {
        public string conhecimentos { get; set; }

        public void imprimeAssistente()
        {
            Console.WriteLine($"nome assistente: {nome}");
            Console.WriteLine($"endereço assistente: {endereco}");
            Console.WriteLine($"telefone assistente: {telefone}");
            Console.WriteLine($"email assistente: {email}");
            Console.WriteLine($"conhecimentos: {conhecimentos}");
        }
    }
}
