using Strategy.Interfaces;

namespace Strategy.Business
{
    public class PNGImage : ISaveImage
    {
        public string SaveImg(string name)
        {
            return $"{name} con el formato .PNG";
        }
    }
}
