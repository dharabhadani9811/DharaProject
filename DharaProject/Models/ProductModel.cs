using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DharaProject.Models
{
    public class ProductModel
    {
        [Key]
        public Guid ProductID { get; set; }

        public Guid CategoryID { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public double ProductPrice { get; set; }

        public string ProductImage { get; set; }
    }
}
