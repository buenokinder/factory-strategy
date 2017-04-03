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
            //Posso escrever todo código referente ao DeliveryNote, que é igual para todos, como exmploe abaixo
            string commonAlgorithm = "Common Delivery + ";
            commonAlgorithm += _strategy.GetDeliveryNote();
            return commonAlgorithm;

        }

	}
}
