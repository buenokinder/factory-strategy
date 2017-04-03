using System;
namespace Farfetch
{
    [DeliveryId(1)]
    public class Ups : CourierStrategy
	{
		public override String GetDeliveryNote()
		{
			return "UPS";
		}

	}
}
