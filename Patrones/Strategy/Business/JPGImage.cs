using Strategy.Interfaces;

namespace Strategy.Business
{
    public class JPGImage : ISaveImage
    {
        public string SaveImg(string name)
        {
            return $"{name} con el formato .JPG";
        }
    }
}
