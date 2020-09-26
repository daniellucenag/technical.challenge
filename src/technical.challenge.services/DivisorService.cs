namespace technical.challenge.services
{
    using domain.Entidades;
    using domain.Interfaces;
    using System.Collections.Generic;
    using util;

    public class DivisorService : IDivisorService
    {
        public IList<long> CalcularDivisores(Divisor divisor)
        {
            //TODO: Validar Divisor

            IList<long> divisores = new List<long>();
            for (long i = 1; i <= divisor.Numero; i++)
            {
                if (divisor.Numero % i == 0)
                {
                    if (divisor.Primo)
                    {
                        if (Util.ChecaPrimo(i))
                        {
                            divisores.Add(i);
                        }
                    }
                    else
                    {
                        divisores.Add(i);
                    }
                }
            }

            return divisores;
        }
    }
}
