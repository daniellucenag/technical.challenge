namespace technical.challenge.services
{
    using domain.Dtos;
    using domain.Entidades;
    using domain.Interfaces;
    using FluentValidation;
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
                DivisorValidator divisorValidator = new DivisorValidator();
                var resultValidator = divisorValidator.Validate(divisor);

                if (!resultValidator.IsValid)
                {
                    response.Erro = resultValidator.Errors[0].ErrorMessage;
                    response.Ok = false;
                    return response;
                }

                for (long i = 1; i <= divisor.Numero; i++)
                {
                    if (Util.ChecarDivisor(divisor.Numero, i))
                    {
                        response.Divisores.Add(i);
                    }
                }

                if (divisor.Primo)
                {
                    IList<long> divisoresPrimos = new List<long>();
                    foreach (var item in response.Divisores)
                    {
                        if (Util.ChecaPrimo(item))
                        {
                            divisoresPrimos.Add(item);
                        }
                    }
                    response.Divisores = divisoresPrimos;
                }

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
