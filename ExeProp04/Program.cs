using System;
using System.Collections.Generic;

namespace ExeProp04
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            for(int i = 0; i < N; i++)
                A.Add(int.Parse(Console.ReadLine()));


            Console.Write("O curso B possui quantos alunos? ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            for (int i = 0; i < N; i++)
                B.Add(int.Parse(Console.ReadLine()));


            Console.Write("O curso C possui quantos alunos? ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");

            for (int i = 0; i < N; i++)
                C.Add(int.Parse(Console.ReadLine()));

            A.UnionWith(B);
            A.UnionWith(C);
            
            Console.WriteLine("Total de alunos: " + A.Count);  
        }
    }
}
