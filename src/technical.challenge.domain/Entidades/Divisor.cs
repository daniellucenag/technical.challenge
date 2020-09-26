namespace domain.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Divisor
    {
        public long Numero { get; set; }
        public bool Primo { get; set; }

        public Divisor(long numero, bool primo)
        {
            Numero = numero;
            Primo = primo;
        }

        public Divisor()
        {
        }
    }
}
