using System;

namespace Program
{
    public class sinchile : Decorador
    {
        public sinchile(menu orden) : base(orden)
        {
        }

        public override double CalculoTotalPrecio()
        {
            var Adiccion = base.CalculoTotalPrecio() + 0.50;

            return Adiccion;
        }
    }
}