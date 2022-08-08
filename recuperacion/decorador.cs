using System;

namespace Program
{
    public class Decorador : menu
    {
        protected menu orden;
        public Decorador(menu orden)
        {
            this.orden = orden;

        }

        public override double CalculoTotalPrecio()
        {
            //Console.WriteLine("Calculo del precio total desde la clase decorador");
            return orden.CalculoTotalPrecio();
        }

    }
}