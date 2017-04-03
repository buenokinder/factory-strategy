# Delivery How-to


## Project test using C# and 2 Patterns (Strategy and Factory)

###Usage Example 

 ```csharp

[DeliveryId(3)] // Put delivery Id 
public class FedEx : IDelivery  // Implement the Interface IDelivery
{
    public string GetDeliveryNote() // Create with algorithm  
    {
        return "FedEx Delivery Note";
    }
}


//For using you need only write this bellow code:

 IDelivery courier = DeliveryFactory.Create(3);   
  
}
 ```
