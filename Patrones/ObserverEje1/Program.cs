using ObserverEje1.Business;
using System;

namespace ObserverEje1
{
    class Program
    {
        static void Main(string[] args)
        {
            var publicador = new Publicador();

            Console.WriteLine(" \n1:Subir código: \n2: Compilar: \n3:Ejecución de pruebas unitarias: \n4. Instalar versión: \n5. Correo de notificación: \n \nSelecciona una opción: \n");
            string opt;
            opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    var subirCodigo = new SubirCodigo();
                    publicador.AgregaPublicador(subirCodigo);
                    publicador.TareaRealizada("");
                    break;
                case "2":
                    var compilar = new Compilar();
                    publicador.AgregaPublicador(compilar);
                    publicador.TareaRealizada("");
                    break;
                case "3":
                    var unitTest = new UnitTest1();
                    publicador.AgregaPublicador(unitTest);
                    publicador.TareaRealizada("");
                    break;
                case "4":
                    var instalarVersion = new InstalarVersion();
                    publicador.AgregaPublicador(instalarVersion);
                    publicador.TareaRealizada("");
                    break;
                case "5":
                    var notificar = new CorreoElectroncio();
                    publicador.AgregaPublicador(notificar);
                    publicador.TareaRealizada("");
                    break;
                default:
                    break;
            }
        }
    }
}
