using System;
using System.Collections.Generic;

namespace DotNetPsql.Models
{
    public partial class Person
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Avatar { get; set; }
        public long? CarId { get; set; }

        public virtual Car? Car { get; set; }
    }
}
