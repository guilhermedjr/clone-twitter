﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Peep.Wings.Domain.Dtos
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
