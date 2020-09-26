namespace domain.Interfaces
{
    using domain.Entidades;
    using System.Collections.Generic;
    
    public interface IDivisorService
    {
        IList<long> CalcularDivisores(Divisor divisor);
    }
}
