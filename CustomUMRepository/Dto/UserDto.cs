﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace CustomUserManagerRepository.Dto
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string DisplayName { get; set; }

        public Claim[] Claims
        {
            get
            {
                return new Claim[]
                {
                    new Claim("preferred_username", UserName),
                    new Claim("name", DisplayName),
                    new Claim("email", UserEmail)
                };
            }
        }
    }
}
