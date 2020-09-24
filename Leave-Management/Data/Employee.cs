using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Data
{
    public class Employee : IdentityUser   //Here Employee class inherits IdentityUser class which is readily available when we select ASP.NET MVC application template with Individual User Accounts as Authentication Type. The Employee class is now made available with the properties of IdentityUser class in addition to the properties defined below (This class refers to dbo.AspNetUsers table in the database) 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }  
    }
}
