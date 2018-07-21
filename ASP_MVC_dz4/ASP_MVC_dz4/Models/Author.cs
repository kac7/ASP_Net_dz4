using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_dz4.Models
{
    public class Author
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public DateTime DateOfDeath { get; set; }
    }
}