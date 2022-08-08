using System;

namespace Program
{
    public class carme : Decorador
    {
        public carme (menu orden) : base(orden)
        {
        }

        public override double CalculoTotalPrecio()
        {
            var Adiccion = base.CalculoTotalPrecio() + 1.50;

            return Adiccion;
        }
    }
}