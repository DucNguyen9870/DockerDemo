using System;
using System.Collections.Generic;

#nullable disable

namespace DockerDemo.Models
{
    public partial class Person
    {
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
    }
}
