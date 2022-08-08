using System;

namespace Program
{
    public class conchile : Decorador
    {
        public conchile(menu orden) : base(orden)
        {
        }

        public override double CalculoTotalPrecio()
        {
            var Adiccion = base.CalculoTotalPrecio() + 0.50;

            return Adiccion;
        }
    }
}