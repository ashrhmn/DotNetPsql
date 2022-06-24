using System;
using System.Collections.Generic;

namespace DotNetPsql.Models
{
    public partial class Car
    {
        public Car()
        {
            People = new HashSet<Person>();
        }

        public long Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
