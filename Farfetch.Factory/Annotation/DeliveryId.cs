using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farfetch.Factory.Annotation
{
 

    [AttributeUsage(AttributeTargets.Class)]
    public class DeliveryId : System.Attribute
    {

        public readonly int Id;


        public DeliveryId(int id)
        {
            this.Id = id;

        }
    }
}
