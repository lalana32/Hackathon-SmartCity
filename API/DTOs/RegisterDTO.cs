using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDTO
    {
        public required string Username { get; set; }
        public required string Email {get;set;}
        public required string Password {get;set;}
    }
}