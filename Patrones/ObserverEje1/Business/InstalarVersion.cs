using ObserverEje1.Interfaces;
using System;

namespace ObserverEje1.Business
{
    public class InstalarVersion : IObservador
    {
        public void AccionTarea()
        {
            Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}
