using System.Collections.Generic;

namespace domain.Dtos
{
    public class DivisorResponse
    {
        public bool Ok { get; set; }
        public IList<long> Divisores { get; set; }
        public string Erro { get; set; }

        public DivisorResponse()
        {
            Divisores = new List<long>();
        }
    }
}
