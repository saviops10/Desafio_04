using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04

{
    class Program
    {
        static void Main(string[] args)
        {

            List<Aluno> aluno = new List<Aluno>();
            aluno.Add(new Aluno { nome = "John Smith", idade = 12, nota = 7 });
            aluno.Add(new Aluno { nome = "Ana Lee", idade = 13, nota = 9 });
            aluno.Add(new Aluno { nome = "Maria Jane", idade = 13, nota = 8 });
            aluno.Add(new Aluno { nome = "Alex Rose", idade = 11, nota = 6 });

            foreach (var estudante in aluno)
            {
                Console.WriteLine((" " + estudante.nome + "\t"));
                Console.WriteLine((" Idade: " + estudante.idade + "\t"));

                Console.WriteLine(" Nota final: " + estudante.nota + "\t" + "\n");

            }
            int[] notas = { 7, 9, 8, 6 };
            int soma = notas.Sum();
            Console.WriteLine(" A Soma das notas: " + soma);
        }
    }
}
