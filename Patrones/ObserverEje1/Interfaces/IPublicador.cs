
namespace ObserverEje1.Interfaces
{
    public interface IPublicador
    {
        void AgregaPublicador(IObservador observador);
        void EliminaPublicador(IObservador observador);
        void Notificar(string msg);
    }
}
