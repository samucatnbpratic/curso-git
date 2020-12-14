using System;
using System.Collections.Generic;

namespace ConsoleExercInstrutor
{
    class Program
    {
        

        static void Main(string[] args)
        {

            HashSet<int> alunos = new HashSet<int>();

            Console.Write("Número de Alunos Curso A: ");
            int nA = int.Parse(Console.ReadLine());
            InserirAluno(alunos, nA);

            Console.Write("Número de Alunos Curso B: ");
            int nB = int.Parse(Console.ReadLine());
            InserirAluno(alunos, nB);

            Console.Write("Número de Alunos Curso C: ");
            int nC = int.Parse(Console.ReadLine());
            InserirAluno(alunos, nC);

            Console.WriteLine("Total de Estudantes: " + alunos.Count);

        }

        static void InserirAluno(HashSet<int> Aluno, int Qtd)
        {
            for (int i = 1; i <= Qtd; i++)
            {
                
                Console.Write($"Aluno {i}: ");
                int matricula = int.Parse(Console.ReadLine());
                Aluno.Add(matricula);
            }

        }
    }
}
