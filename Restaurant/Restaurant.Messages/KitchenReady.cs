using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Messages
{
    public interface IKitchenReady
    {
        public Guid OrderId { get; }

        public bool Ready { get; }
    }

    public class KitchenReady : IKitchenReady
    {
        public KitchenReady(Guid orderId, bool ready)
        {
            OrderId = orderId;
            Ready = ready;
        }

        public Guid OrderId { get; }
        public bool Ready { get; }
    }
}
