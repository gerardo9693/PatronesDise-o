using ObserverEje1.Interfaces;
using System;

namespace ObserverEje1.Business
{
    public class SubirCodigo : IObservador
    {
        public void AccionTarea()
        {
            Console.WriteLine("Commit de la versión 1.1");
        }
    }
}
