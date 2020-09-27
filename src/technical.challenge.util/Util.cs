namespace util
{
    public static class Util
    {
        public static bool ChecaPrimo(long numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            var m = numero / 2;
            for (var i = 2; i <= m; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ChecarDivisor(long numero, long divisor)
        {
            if (numero % divisor == 0)
            {
                return true;
            }

            return false;
        }
        

            

    }
}
