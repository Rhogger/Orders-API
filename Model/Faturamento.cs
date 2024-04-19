public class Faturamento : IObservador
{
    public void Enviar(IObservavel observavel){
        await busManager.SendMessageAsync("notificarfaturamento", "Mensagem de notificação de faturamento");
    }
}