using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farfetch
{
    [DeliveryId(3)]
    public class FedEx : CourierStrategy
    {
        public override String GetDeliveryNote()
        {
            return "Fedex";
        }

    }
}
