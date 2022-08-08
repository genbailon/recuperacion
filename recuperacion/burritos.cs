using System;

namespace Program
{
    public class burritos : menu
    {
        public override double CalculoTotalPrecio()
        {
            Console.Write("Total del pedido: ");
            var burritos = 2.00;
            return burritos;
        }
    }
}
