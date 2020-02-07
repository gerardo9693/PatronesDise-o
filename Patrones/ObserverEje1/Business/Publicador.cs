using ObserverEje1.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ObserverEje1.Business
{
    public class Publicador : IPublicador
    {
        List<IObservador> lstObservers = new List<IObservador>();

        public void AgregaPublicador(IObservador observador)
        {
            this.lstObservers.Add(observador);
        }

        public void EliminaPublicador(IObservador observador)
        {
            this.lstObservers.Remove(observador);
        }

        public void Notificar(string msg)
        {
            foreach (var observador in lstObservers)
            {
                Thread.Sleep(2000);
                observador.AccionTarea();
            }
            Thread.Sleep(2000);
            Console.WriteLine("\nTransacción correcta: " + msg);
            Thread.Sleep(2000);
            Consola.TerminaProceso();
        }

        public void TareaRealizada(string msg)
        {
            Notificar(msg);
        }
    }
}
