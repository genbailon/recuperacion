using System;

namespace Program
{
    public class pedidos
    {
        public static void Main(string[] arg)
        {

            var taco = new tacos();
            Console.WriteLine("$" + taco.CalculoTotalPrecio());

            var aadicional1 = new pollo(taco);
            Console.WriteLine("$" + aadicional1.CalculoTotalPrecio());

            var adicional2 = new sinchile(taco);
            Console.WriteLine("$" + adicional2.CalculoTotalPrecio());

            Console.WriteLine();
        }
    }
}
