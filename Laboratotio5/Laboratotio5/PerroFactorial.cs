namespace Laboratotio5
{
    class PerroFactorial : ICalcular
    {
        public int Calcular(int numero)
        {
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
