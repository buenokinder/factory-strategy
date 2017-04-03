using System;
namespace Farfetch
{
	public abstract class CourierStrategy : IDeliveryStrategy
    {
		public abstract String GetDeliveryNote();
	}
}
