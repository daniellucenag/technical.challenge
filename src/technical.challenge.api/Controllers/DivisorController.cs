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

        [HttpGet("{numero}/{primo}", Name = "Get")]
        public ActionResult<IList<long>> Get(int numero, bool primo)
        {
            Divisor divisor = new Divisor
            {
                Numero = numero,
                Primo = primo,
            };

            var result = _divisorService.CalcularDivisor(divisor);

            if (result.Ok)
            {
                return Ok(result.Divisores);
            }
            else
            {
                return BadRequest(result.Erro);
            }

        }
    }
}
