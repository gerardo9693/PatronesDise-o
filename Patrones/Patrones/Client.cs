using PatronesDiseño.FactoryMetod.Business;
using System;

namespace PatronesDiseño.FactoryMetod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: mensaje en Windows.");
            render(new WebDialog());

            Console.WriteLine("");

            Console.WriteLine("App: mensaje  en html.");
            render(new WebDialog());
        }

        public void render(Dialog cMensaje)
        {
            Console.WriteLine("Client: mensaje\n" + cMensaje.SomeOperation());
        }
    }
}
