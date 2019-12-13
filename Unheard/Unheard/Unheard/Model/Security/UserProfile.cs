﻿using Unheard.Services.Interfaces;

namespace Unheard.Model.Security
{
    public class UserProfile : IUserProfile
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        public string Gender { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }



 }
}

