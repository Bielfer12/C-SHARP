using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            
            
            string[] vet = Console.ReadLine().Split(' '); //fazendo um vetor para indexar cada palavra que estiver seprada pelo espaço
            string p1 = vet[0];
            string p2 = vet[1]; //vet[1] esta dizendo para armazenar em ps o item no indexado 1, lo lugar 1
            string p3 = vet[2];

            
            Console.WriteLine(frase +  p1 + p2 + p3 + x + y + z); gabriel fillipe cas
            
        }
    }
}
