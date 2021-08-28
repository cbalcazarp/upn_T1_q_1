using System;

namespace upn_myproject
{
    class Program
    {

        static void Main(string[] args)
        {
            Double radio, longitudCircunferencia;
            Console.Write("Ingrese radio de circunferencia: ");
            radio = Convert.ToDouble(Console.ReadLine());
            longitudCircunferencia = 2 * Math.PI * radio;
            Console.WriteLine("La longitud de circunferencia con radio "+ Convert.ToString(radio) +" es: " + Convert.ToString(longitudCircunferencia));
        }
    }
}
