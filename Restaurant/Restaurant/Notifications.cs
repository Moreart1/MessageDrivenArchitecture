using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Notifications
    {
        public int SendDelay { get; init; }

        public async Task Send(string message)
        {
            await Task.Delay(SendDelay);
            Console.WriteLine("Уведомление: " + message);
        }
    }
}
