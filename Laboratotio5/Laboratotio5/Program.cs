using System;

namespace Laboratotio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero: ");
            string input = Console.ReadLine();
            int numero = Convert.ToInt32(input);
            var calculadora = new Calculadora(numero);
            calculadora.calculadoras.Add(new PersonaQueSuma5());
            calculadora.calculadoras.Add(new RobotFibonacci());
            calculadora.calculadoras.Add(new PerroFactorial());
            calculadora.calculadoras.Add(new Cubo());
            calculadora.calculadoras.Add(new Cuadrado());
            Console.WriteLine("¿Que operacion desea hacer?\n[1] Sumar 5\n[2] Fibonacc\n[3] Factorial\n[4] Cubo\n[5] Cuadrado");
            input = Console.ReadLine();
            calculadora.Calcular(input);
            Console.WriteLine("Resultado: {0}",calculadora.GetNumero());
        }
    }
}
