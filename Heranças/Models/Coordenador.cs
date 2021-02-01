using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças.Models
{
    class Coordenador : Pessoa
    {
        public double salario { get; set; }
        public string periodo { get; set; }

        //list pode puxar informações de uma classe ou armazenar em variáries 
        //adicionando valores
        public List<Curso> cursos { get; set; }

        public void imprimeCoordenador()
        {
            Console.WriteLine($"nome coordenador: {nome}");
            Console.WriteLine($"endereço coordenador: {endereco}");
            Console.WriteLine($"telefone coordenador: {telefone}");
            Console.WriteLine($"email coordenador: {email}");
            Console.WriteLine($"salario coordenador: {salario}");
            Console.WriteLine($"periodo coordenador: {periodo}");
            Console.WriteLine($"cursos coordenador: {cursos}");
        }
    }
}
