using Strategy.Business;
using Strategy.Interfaces;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre de la imagen:  ");
            string cNombreImg = Console.ReadLine();

            var opt = MenuOpciones();
            var save = GuardarFormatoImagen(opt);

            string msg = save.SaveImg(cNombreImg);

            Repository.printMsg(msg);
            Console.ReadKey();
        }


        public static string MenuOpciones()
        {
            Console.WriteLine("\nEliga el formato en que desea guardar la imagen" +
             "\n1. PNG" +
             "\n2. JPG" +
             "\n3. GIF");
            string opt = Console.ReadLine();

            return opt;
        }

        public static ISaveImage GuardarFormatoImagen(string option)
        {
            ISaveImage saveImage = null;

            switch (option)
            {
                case "1":
                    saveImage = new GIFImage();
                    break;
                case "2":
                    saveImage = new JPGImage();
                    break;
                case "3":
                    saveImage = new PNGImage();
                    break;
                default:
                    break;
            }

            return saveImage;
        }
    }
}
