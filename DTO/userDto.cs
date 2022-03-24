using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WeSafe.Models;

namespace WeSafe.DTO
{
    public class UserDto
    {
       
        public int UserId { get; set; }
        public string IdentificationCard { get; set; }

        public Role Role { get; set; }

    }

}