using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Patinho;

            Console.WriteLine("quantos patinhos:");
            Patinho = int.Parse(Console.ReadLine()); 
            Console.WriteLine();

        for (int x = Patinho; x > 0 ; x -= 1)
        {
            Console.WriteLine(x + " Patinhos foram passear");
            Console.WriteLine("Além das montanhas");
            Console.WriteLine("Para brincar");
            Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
            Console.WriteLine("Mas só " + (x - 1) + " patinhos voltaram de lá.\n"); 
            
        } 
            Console.WriteLine("A mamãe patinha foi procurar");
            Console.WriteLine("Além das montanhas");
            Console.WriteLine("Na beira do mar");
            Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
            Console.WriteLine("E os " + Patinho + " patinhos voltaram de lá.");
        }
    }
}
