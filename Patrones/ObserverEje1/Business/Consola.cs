using System;
using System.Threading;

namespace ObserverEje1.Business
{
    public class Consola
    {
        public static void TerminaProceso()
        {
            Console.WriteLine("Cerrando Consola . . .");
            Thread.Sleep(2000);
            Environment.Exit(-1);
        }
    }
}
