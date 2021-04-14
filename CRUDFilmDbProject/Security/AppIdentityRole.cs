﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandFinder.Security
{
    public class AppIdentityRole : IdentityRole
    {
        public string RoleDescription { get; set; }
    }
}
