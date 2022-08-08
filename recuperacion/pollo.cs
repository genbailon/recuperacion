using System;

namespace Program
{
    public class pollo : Decorador
    {
        public pollo (menu orden) : base(orden)
        {
        }

        public override double CalculoTotalPrecio()
        {
            var Adiccion = base.CalculoTotalPrecio() + 1.00;

            return Adiccion;
        }
    }
}