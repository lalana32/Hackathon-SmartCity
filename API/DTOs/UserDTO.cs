using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserDTO
    {
        public required string Email { get; set; }
        
        public required string Token {get;set;}
      
        public string? Username {get;set;}
    }
}