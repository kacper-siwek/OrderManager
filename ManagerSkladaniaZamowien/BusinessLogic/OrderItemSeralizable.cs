using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSkladaniaZamowien.BusinessLogic
{
    /// <summary>
    /// Special class, created in order to translate OrderItem to a serializable version.
    /// The original OrderItem class implements an interface, which makes it impossible to serialize.
    /// </summary>
    public class OrderItemSeralizable
    {
        public string ItemName { get; set; }
        public double Amount { get; set; }
        public decimal Price { get; set; }
    }
}
