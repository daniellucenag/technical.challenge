namespace technical.challenge.console
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {              

            while (true)
            {
                Console.WriteLine("Digite um número para visualizar seus divisores ou 'q' para sair.");
                var entrada = Console.ReadLine();
                if (entrada == "q")
                {
                    break;
                }

                try
                {
                    var numero = int.Parse(entrada);
                    Console.WriteLine($"Divisores do numero {entrada}!");

                    for (int i = 1; i <= numero; i++)
                    {
                        //verificar se numero é divisor
                        if (numero % i == 0)
                        {   
                            Console.WriteLine($"{i} é um divisor do numero {numero}.");
                        }
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                    continue;
                }   

            }


        }        
    }
}
