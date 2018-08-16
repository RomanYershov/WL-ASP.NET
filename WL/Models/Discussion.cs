using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WL.Models
{
    public class Discussion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; } 
    }
}