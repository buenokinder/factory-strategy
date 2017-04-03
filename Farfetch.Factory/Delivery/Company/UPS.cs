using Farfetch.Factory.Annotation;
using Farfetch.Factory.Delivery.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farfetch.Factory.Delivery.Company
{
    [DeliveryId(1)]
    public class UPS : IDelivery
    {
        public string GetDeliveryNote()
        {
            return "UPS  Delivery Note";
        }
    }
}
