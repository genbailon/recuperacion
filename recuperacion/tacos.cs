using System;

namespace Program
{
    public class tacos : menu
    {
        public override double CalculoTotalPrecio()
        {
            Console.Write("Total del pedido: ");
            var tacos = 2.50;
            return tacos;
        }
    }
}
