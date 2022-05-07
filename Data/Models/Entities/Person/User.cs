using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Kamall_foods_server_aspNetCore.Data.Models
{
    [Table("Users")]
    public class User : Person.Person
    {
        public List<string> DeliveryAdresses { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}