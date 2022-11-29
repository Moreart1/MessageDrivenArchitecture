using MassTransit;
using Restaurant.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Kitchen
{
    public class Manager
    {      
        public Manager(IBus bus)
        {
            
        }

        public bool CheckKitchenReady(Guid orderId, Dish? dish)
        {
            return true;
        }

    }
}
