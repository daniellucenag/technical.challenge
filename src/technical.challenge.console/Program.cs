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
                            Console.WriteLine($"{i} é um divisor do numero {numero}, e " + (ChecaPrimo(i) ? "é" : "não é") + " primo.");
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


        private static bool ChecaPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            var m = numero / 2;
            for (var i = 2; i <= m; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
