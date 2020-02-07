using PatronesDiseño.FactoryMetod.Interfaces;

namespace PatronesDiseño.FactoryMetod.Business
{
    public abstract class Dialog
    {
        public abstract IButton FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Messaje: Presione el botón aceptar para continuar "
                + product.OnClick();

            return result;
        }

    }
}
