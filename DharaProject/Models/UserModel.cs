using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DharaProject.Models
{
    public class UserModel
    {
        public Guid UserID { get; protected set; }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public string EmailID { get; protected set; }

  
        public string Address { get; protected set; }
    }
}
