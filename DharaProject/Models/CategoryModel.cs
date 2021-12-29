using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DharaProject.Models
{
    public class CategoryModel
    {   
        [Key]
        public Guid CategoryID { get; protected set; }

        public string CategoryName { get; protected set; }
        public ICollection<ProductModel> Product { get; protected set; }
    }
}
