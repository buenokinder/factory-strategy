using System;
namespace Farfetch
{

    [DeliveryId(2)]
    public class CorreiosBr : CourierStrategy
	{
		public override String GetDeliveryNote()
		{
			return "Correios BR";
		}

	}
}
