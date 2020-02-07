using ObserverEje1.Interfaces;
using System;

namespace ObserverEje1.Business
{
    public class UnitTest1 : IObservador
    {
        public void AccionTarea()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
