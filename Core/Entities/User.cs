using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TempProject.Core.Entities
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Gender { get; set; }        
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public int Assigned_Manager { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string License { get; set; }

    }
}
