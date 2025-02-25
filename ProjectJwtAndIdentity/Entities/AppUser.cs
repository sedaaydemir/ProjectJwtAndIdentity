﻿using Microsoft.AspNetCore.Identity;

namespace ProjectJwtAndIdentity.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
