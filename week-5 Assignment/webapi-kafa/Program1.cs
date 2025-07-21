using Confluent.Kafka;
using System;
using System.Threading.Tasks;

class Program
{
    public static async Task Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Kafka Chat Publisher started.");
        Console.WriteLine("Type your message and press Enter to send (type 'exit' to quit):");

        while (true)
        {
            var message = Console.ReadLine();
            if (message.ToLower() == "exit")
                break;

            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
            Console.WriteLine($"Sent: {message}");
        }
    }
}
