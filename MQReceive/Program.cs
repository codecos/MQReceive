using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQReceive
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() {
                HostName = MQConfig.HostName,
                UserName = MQConfig.UserName,
                Password = MQConfig.Password,
            };

            Receive.ReceiveData(factory);

        }
    }
}
