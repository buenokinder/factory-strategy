using System;
namespace Farfetch
{
	
	public class DeliveryContext : IDeliveryContext
	{
		private IDeliveryStrategy _strategy;

		public DeliveryContext(IDeliveryStrategy strategy)
		{
			this._strategy = strategy;
		}
		public string GetDeliveryNote()
		{
			return _strategy.GetDeliveryNote();
		}

	}
}
