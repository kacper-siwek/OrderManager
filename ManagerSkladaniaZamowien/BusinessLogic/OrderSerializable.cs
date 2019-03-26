using OrderSubmissionManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSkladaniaZamowien.BusinessLogic
{
    /// <summary>
    /// Special class, created in order to translate Order to a serializable version.
    /// The original Order class implements an interface, which makes it impossible to serialize.
    /// </summary>
    public class OrderSerializable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public System.DateTime BirthDate { get; set; }
    }
}
