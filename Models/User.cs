﻿using Microsoft.AspNetCore.Identity;

namespace ElevateProjectFinal.Models
{
    public class User : IdentityUser
    {
       
        public string ScreenName { get; set; }
    }
}