using System;
using System.Collections.Generic;


namespace Laboratotio5
{
    class Calculadora
    {
        private int numero;
        public List<ICalcular> calculadoras;

        public Calculadora(int num)
        {
            this.numero = num;
            calculadoras = new List<ICalcular>();

        }
        public int GetNumero()
        {
            return numero;
        }
        public void Calcular(string input)
        {
            int resultado = 0;
            if (input == "1")
            {
                resultado = calculadoras[0].Calcular(numero);
            }
            if (input == "2")
            {
                resultado = calculadoras[1].Calcular(numero);
            }
            if (input == "3")
            {
                resultado = calculadoras[2].Calcular(numero);
            }
            if (input == "4")
            {
                resultado = calculadoras[3].Calcular(numero);
            }
            if (input == "5")
            {
                resultado = calculadoras[4].Calcular(numero);
            }
            numero = resultado;
        }
    }
}
