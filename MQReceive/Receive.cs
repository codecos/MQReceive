using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQReceive
{
    public class Receive
    {
        public static void ReceiveData(ConnectionFactory factory)
        {
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine("Received {0}", message);
                    };
                    channel.BasicConsume(queue: "hello", autoAck: true, consumer: consumer);
                    Console.WriteLine("Press [enter] to exit");
                    Console.ReadLine();
                }
            }
        }
    }
}
