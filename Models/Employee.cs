using System;
using System.Collections.Generic;

namespace DBFirstApproachDemo.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public string Salary { get; set; } = null!;
    }
}
