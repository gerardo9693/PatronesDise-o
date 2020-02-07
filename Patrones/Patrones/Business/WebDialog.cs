
using PatronesDiseño.FactoryMetod.Interfaces;

namespace PatronesDiseño.FactoryMetod.Business
{
    public class WebDialog : Dialog
    {
        public override IButton FactoryMethod()
        {
            return new Html();
        }
    }
}
