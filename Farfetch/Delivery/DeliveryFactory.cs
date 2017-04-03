
using System;
using System.Collections.Generic;
using System.Linq;

namespace Farfetch
{


    public static class DeliveryFactory
    {

        public static IDeliveryContext Create(int value)
        {
           return new DeliveryContext(GetDeliveryById(value));
          
        }

        private static IDeliveryStrategy GetDeliveryById(int Id)
        {
            Type deliveryType = ReturnTypeIfExist(Id, GetDeliveryType());
            return (IDeliveryStrategy)Activator.CreateInstance(deliveryType);

        }

        private static IEnumerable<Type> GetDeliveryType()
        {
            return from a in AppDomain.CurrentDomain.GetAssemblies()
                   from t in a.GetTypes()
                   where t.IsDefined(typeof(DeliveryId), false)
                   select t;
        }
        private static Type ReturnTypeIfExist(int Id, IEnumerable<Type> types)
        {
            foreach (Type retorno in types)
            {

                System.Reflection.MemberInfo info = retorno;
                object[] attributes = info.GetCustomAttributes(true);
                for (int i = 0; i < attributes.Length; i++)
                {
                    if (attributes[i] is DeliveryId)
                    {
                        if (((DeliveryId)attributes[i]).Id == Id)
                            return retorno;
                    }

                }
            }
            throw new Exception("Delivery *** Id: " + Id + " *** not implemented");

        }

    }
}
