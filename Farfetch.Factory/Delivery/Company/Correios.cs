using Farfetch.Factory.Annotation;
using Farfetch.Factory.Delivery.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farfetch.Factory.Delivery.Company
{
    [DeliveryId(2)]
    public class Correios : IDelivery
    {
        public string GetDeliveryNote()
        {
            return "Correios Brasil  Delivery Note";
        }
    }
}
