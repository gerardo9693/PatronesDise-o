using PatronesDiseño.FactoryMetod.Interfaces;

namespace PatronesDiseño.FactoryMetod.Business
{
    public class WindowsDialog : Dialog
    {
        public override IButton FactoryMethod()
        {
            return new Windows();
        }
    }
}
