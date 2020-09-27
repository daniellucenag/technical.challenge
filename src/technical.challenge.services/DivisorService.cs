namespace technical.challenge.services
{
    using domain.Dtos;
    using domain.Entidades;
    using domain.Interfaces;
    using global::services;
    using System;
    using System.Collections.Generic;
    using util;

    public class DivisorService : IDivisorService
    {
        public DivisorResponse CalcularDivisor(Divisor divisor)
        {
            DivisorResponse response = new DivisorResponse();
            try
            {
                DivisorValidator validator = new DivisorValidator();
                var resultValidator = validator.Validate(divisor);

                if (!resultValidator.IsValid)
                {
                    response.Erro = resultValidator.Errors[0].ErrorMessage;
                    response.Ok = false;
                    return response;
                }

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

                response.Divisores = divisores;
                response.Ok = true;

                return response;
            }
            catch (Exception ex)
            {
                response.Erro = ex.Message;
                response.Ok = false;

                return response;
            }
        }       
    }
}
