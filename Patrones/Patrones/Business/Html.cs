using PatronesDiseño.FactoryMetod.Interfaces;

namespace PatronesDiseño.FactoryMetod.Business
{
    public class Html : IButton
    {
        public string OnClick()
        {
            return $"click boton html";
        }

    }
}
