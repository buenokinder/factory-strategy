using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farfetch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                IDeliveryContext courier = DeliveryFactory.Create(1);
                Console.WriteLine(courier.GetDeliveryNote());
                courier = DeliveryFactory.Create(2);
                Console.WriteLine(courier.GetDeliveryNote());
                courier = DeliveryFactory.Create(3);
                Console.WriteLine(courier.GetDeliveryNote());
                courier = DeliveryFactory.Create(4);
                Console.WriteLine(courier.GetDeliveryNote());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
