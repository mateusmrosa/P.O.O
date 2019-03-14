using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            string entrada = "";

            Console.WriteLine("___Calcula a média de uma aluno___");
            Console.WriteLine();

            Console.WriteLine("Informe seu nome: ");
            entrada = Console.ReadLine();
            aluno.Nome = entrada;

            Console.WriteLine();

            Console.WriteLine("Informe a nota 1: ");
            entrada = Console.ReadLine();
            aluno.Nota1 = Convert.ToDouble(entrada);

            Console.WriteLine("Informe a nota 2: ");
            entrada = Console.ReadLine();
            aluno.Nota2 = Convert.ToDouble(entrada);

            Console.WriteLine("Informe a nota 3: ");
            entrada = Console.ReadLine();
            aluno.Nota3 = Convert.ToDouble(entrada);

            Console.WriteLine("A média do " + aluno.Nome + " é: " + aluno.VerificaMedia());

            if (aluno.VerificaMedia() >= 6)
                Console.WriteLine("Aluno esta aprovado");
            else
                Console.WriteLine("Aluno ficou de exame");

            Console.ReadKey();
        }
    }
}
