public interface IObservavel
{
    public void Registrar(IObservador observador);
    public void Remover(IObservador observador);
    public void Notificar();
}