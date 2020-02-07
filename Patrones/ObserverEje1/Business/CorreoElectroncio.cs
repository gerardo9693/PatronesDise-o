using ObserverEje1.Interfaces;
using System;

namespace ObserverEje1.Business
{
    public class CorreoElectroncio : IObservador
    {
        public void AccionTarea()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
