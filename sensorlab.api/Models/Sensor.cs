using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sensorlab.api.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UniqueId { get; set; }
        public Account Account { get; set; }
        public User User { get; set; }
        public Service Service { get; set; }

    }
}