using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using eShop.Domain.Entities;

namespace eShop.Domain.Auth
{
    public class AuthenticationResponse
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserNameSurname { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public List<string> Permissions { get; set; }
        public byte[] Image { get; set; }
        public string JWToken { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
    }
}
