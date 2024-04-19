public class Expedicao : IObservador
{
    public void Enviar(IObservavel observavel){
        await busManager.SendMessageAsync("expedicaomercadoria", "Mensagem de expedição");
    }
}