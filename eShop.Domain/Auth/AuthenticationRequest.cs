﻿namespace eShop.Domain.Auth
{
    public class AuthenticationRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
