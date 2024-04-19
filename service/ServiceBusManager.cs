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


