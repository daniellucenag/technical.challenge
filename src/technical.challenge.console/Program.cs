namespace technical.challenge.console
{
    using System;
    using domain.Entidades;
    using domain.Interfaces;
    using ioc;
    using Microsoft.Extensions.DependencyInjection;
    using technical.challenge.services;

    public class Program
    {
        private static IDivisorService _divisorService;
       
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();               
            var serviceProvider = NativeInjectorBootstrapper.GetProvider(serviceCollection);

            _divisorService = serviceProvider.GetService<IDivisorService>();

            bool mostrarMenu = true;
            while (mostrarMenu)
            {
                mostrarMenu = Menu();
            }
        }


        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opçao:");
            Console.WriteLine("1) Calcular divisores que compoem um número");
            Console.WriteLine("2) Calcular divisores primios que compoem um número.");
            Console.WriteLine("3) Sair");
            Console.Write("\r\nDigite o número da opçao desejada: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"\r\nVocê selecionou 'Calcular divisores que compoem um número'");
                    CalcularDivisores(false);
                    return true;
                case "2":
                    Console.WriteLine($"\r\nVocê selecionou 'Calcular divisores primos que compoem um número'.");
                    CalcularDivisores(true);
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        public static string ObterEntradaUsuario()
        {
            Console.Write("\r\nDigite o número para  realizar o calculo: ");
            return Console.ReadLine();
        }

        public static void ImprimirResultado(string mensagem)
        {
            Console.WriteLine($"\r\n{mensagem}");
            Console.Write("\r\nPressione Enter para retornar ao menu principal: ");
            Console.ReadLine();
        }

        public static void CalcularDivisores(bool primo)
        {
            try
            {
                var entrada = ObterEntradaUsuario();
                if (!int.TryParse(entrada, out int numero) || numero <= 0)
                { 
                    ImprimirResultado($"O valor digitado não é válido. Valor digitado: {numero}");
                    return;
                }
                              
                Divisor divisor = new Divisor
                {
                    Numero = numero,
                    Primo = primo,
                };

                var result = _divisorService.CalcularDivisor(divisor);
                if (result.Ok)
                {
                    ImprimirResultado($"O Resultado obtido foi: {string.Join(",", result.Divisores)}");
                }
                else
                {
                    ImprimirResultado($"{result.Erro}");
                }
            }
            catch (Exception ex)
            {
                ImprimirResultado($"Ocorreu um erro: {ex.Message} ");                
            }
        }    
    }
}
