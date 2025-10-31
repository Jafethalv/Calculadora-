namespace Calculadora1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Elija la operación (+, -, *, /): ");
            char operacion = Convert.ToChar(Console.ReadLine());

            double resultado = 0;

            if (operacion == '+')
                resultado = num1 + num2;
            else if (operacion == '-')
                resultado = num1 - num2;
            else if (operacion == '*')
                resultado = num1 * num2;
            else if (operacion == '/')
            {
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Error: no se puede dividir entre cero.");
            }
            else
            {
                Console.WriteLine("Operación no válida.");
                return;
            }

            // Mostrar el resultado
            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}
