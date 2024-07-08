using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.Models.Employees
{
    public class EmpRole : IdentityUserRole<int>
    {
        public Employee Employee { get; set; }
        public Role Role { get; set; }
    }
}
