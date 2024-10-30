﻿using System.ComponentModel.DataAnnotations;

namespace techiz.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
