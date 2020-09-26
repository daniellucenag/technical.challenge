namespace api.Controllers
{
    using System.Collections.Generic;
    using domain.Entidades;
    using domain.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class DivisorController : ControllerBase
    {
        private readonly IDivisorService _divisorService;

        public DivisorController(IDivisorService divisorService)
        {
            _divisorService = divisorService;
        }

        // GET: api/Divisor/5
        [HttpGet("{numero}/{primo}", Name = "Get")]
        public IList<long> Get(int numero, bool primo)
        {
            Divisor divisor = new Divisor
            {
                Numero = numero,
                Primo = primo,
            };

            var divisores = _divisorService.CalcularDivisores(divisor);
            return divisores;
        }
    }
}
