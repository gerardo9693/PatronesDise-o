using ObserverEje1.Interfaces;
using System;

namespace ObserverEje1.Business
{
    public class Compilar : IObservador
    {
        public void AccionTarea()
        {
            Console.WriteLine("Compilación de código correcta");
        }
    }
}
