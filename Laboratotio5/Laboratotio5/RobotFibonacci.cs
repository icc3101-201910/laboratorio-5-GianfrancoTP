namespace Laboratotio5
{
    class RobotFibonacci : ICalcular
    {
        public int Calcular(int numero)
        {
            int antePenultimo = 0;
            int penultimo = 1;
            int ultimo = 1;
            if (numero > 2)
            {
                for (int i = 0; i < numero - 1; i++)
                {
                    ultimo = antePenultimo + penultimo;
                    antePenultimo = penultimo;
                    penultimo = ultimo;
                }
                return ultimo;
            }
            else
            {
                return 1;
            }
        }
    }
}
