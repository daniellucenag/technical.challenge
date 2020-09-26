namespace technical.challenge.console
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {  
            int numero = 12;
            Console.WriteLine($"Divisores do numero {numero}!");

            for (int i = 1; i <= numero; i++)
            {
                //verificar se numero é divisor
                if (numero % i == 0)
                {   
                    Console.WriteLine($"{i} é um divisor do numero {numero}.");
                }
            }
        }
    }
}
