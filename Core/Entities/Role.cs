﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TempProject.Core.Entities
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
