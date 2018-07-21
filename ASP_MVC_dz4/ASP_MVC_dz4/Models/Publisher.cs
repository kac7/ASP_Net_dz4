using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_dz4.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Clear()
        {
            Id = 0;
            Name = null;
        }
    }
}