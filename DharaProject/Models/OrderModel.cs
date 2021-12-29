using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DharaProject.Models
{
    public class OrderModel
    {
        public Guid OrderID { get; set; }

        public Guid UserID { get; set; }

        public ICollection<ProductModel> Products { get; set; }

        public int ProductQty { get; set; }

        public DateTime OrderDate { get; set; }

        /// TODO - What is the purpose of this
        public int oID { get; set; }
    }
}
