using System;
using System.Collections.Generic;

namespace Desafio_04
{

    class Program
    {
        static void Main(string[] args)
        {
            double totalNotaArray = 0.0;
            double totalNotaList = 0.0;

            Aluno[] alunosArray = new Aluno[3];

            for (int i = 0; i < alunosArray.Length; i++)
            {
                int count = i + 1;

                Console.WriteLine("Qual o nome do aluno {0}?", count);
                string nome = Console.ReadLine();

                Console.WriteLine("Qual a idade do {0}?", nome);
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual a nota do {0}? ", nome);
                double nota = Double.Parse(Console.ReadLine());

                alunosArray[i] = new Aluno(nome, idade, nota);
            }

            Console.WriteLine("Lista em Array:");

            for (int i = 0; i < alunosArray.Length; i++)
            {
                Console.WriteLine("Aluno: " + alunosArray[i].nome + ", Idade: " + alunosArray[i].idade + ", Nota: " + alunosArray[i].nota);
                somaNotaArray += alunosArray[i].nota;
            }

            Console.WriteLine("Notas dos alunos somadas: " + totalNotaArray);

            List<Aluno> alunosList = new List<Aluno>();

            alunosList.Add(new Aluno(alunosArray[0].nome, alunosArray[0].idade, alunosArray[0].nota));
            alunosList.Add(new Aluno(alunosArray[1].nome, alunosArray[1].idade, alunosArray[1].nota));
            alunosList.Add(new Aluno(alunosArray[2].nome, alunosArray[2].idade, alunosArray[2].nota));

            Console.WriteLine("\n");
            Console.WriteLine("Lista com Objeto:");

            foreach (Aluno i in alunosList)
            {
                Console.WriteLine("Aluno: " + i.Nome + ", Idade: " + i.Idade + ", Nota: " + i.Nota);
                somaNotaList += i.nota;
            }
            Console.WriteLine("Notas dos alunos somadas: " + totalNotaList);

        }
    }
}
