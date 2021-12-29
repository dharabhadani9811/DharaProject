using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DharaProject.Api.Controller
{
    public class UserController
    {
        //Get Al users
        [HttpGet("/api/user/getall")]
        public  IActionResult<Guid> GetAllUser(CancellationToken token) 
            {
                    var user = ApplicationDbContext();
              //user.
             }
            
    
    }
}
