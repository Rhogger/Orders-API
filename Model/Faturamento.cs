public class Faturamento : IObservador
{
    public async void Enviar(IObservavel observavel)
    {
        var serviceBusManager = new ServiceBusManager("Endpoint=sb://pedidovenda.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=DZVvHjAc/NQS5fAXAZO2c9uEyAIRFzTkF+ASbLF3kFA=");

        await serviceBusManager.SendMessageAsync("notificarfaturamento", "Mensagem de notificação de faturamento");
    }
}