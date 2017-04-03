using Farfetch.Factory.Annotation;
using Farfetch.Factory.Delivery.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farfetch.Factory.Delivery
{
 
    public static class DeliveryFactory
    {

        public static IDelivery Create(int value)
        {
           return GetDeliveryById(value);
        }

        private static IDelivery GetDeliveryById(int Id)
        {
            Type deliveryType = ReturnTypeIfExist(Id, GetDeliveryType());
            return (IDelivery)Activator.CreateInstance(deliveryType);

        }

        private static IEnumerable<Type> GetDeliveryType() {
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
            throw new Exception("Delivery *** Id "+ Id +" *** not implemented");

        }
        
    }
}
