namespace domain.Interfaces
{
    using domain.Dtos;
    using domain.Entidades;
    using System.Collections.Generic;
    
    public interface IDivisorService
    {
        DivisorResponse CalcularDivisor(Divisor divisor);
    }
}
