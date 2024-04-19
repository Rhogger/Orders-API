using Azure.Messaging.ServiceBus;

public class ServiceBusManager
{
    private readonly string _connectionString;
    private readonly ServiceBusClient _client;

    public ServiceBusManager(string connectionString)
    {
        _connectionString = connectionString;
        _client = new ServiceBusClient(connectionString);
    }

    public async Task SendMessageAsync(string queueName, string messageBody)
    {
        ServiceBusSender sender = _client.CreateSender(queueName);
        ServiceBusMessage message = new ServiceBusMessage(messageBody);
        await sender.SendMessageAsync(message);
    }
}

// string connectionString = "Endpoint=sb://pedidovenda.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=DZVvHjAc/NQS5fAXAZO2c9uEyAIRFzTkF+ASbLF3kFA=";
// ServiceBusManager busManager = new ServiceBusManager(connectionString);

// // Enviar para a fila de expedição
// await busManager.SendMessageAsync("expedicaomercadoria", "Mensagem de expedição");

// // Enviar para a fila de notificação de faturamento
// await busManager.SendMessageAsync("notificarfaturamento", "Mensagem de notificação de faturamento");
