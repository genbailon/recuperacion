using System;

namespace Program
{
    public class tamales : menu
    {
        public override double CalculoTotalPrecio()
        {
            Console.Write("Total del pedido: ");
            var tamales = 3.00;
            return tamales;
        }
    }
}
