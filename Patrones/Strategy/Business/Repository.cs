using System;

namespace Strategy.Business
{
    public class Repository
    {
        public static void printMsg(string msgImage)
        {
            Console.WriteLine("Se ha guardado la imagen {0}", msgImage);
        }
    }
}
