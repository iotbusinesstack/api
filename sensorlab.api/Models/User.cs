using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sensorlab.api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Account Account { get; set; }
        public string UniqueId { get; set; }
    }
}