using System;
using System.Collections.Generic;
using System.Text;

namespace Course_composition.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        {
        }
        
        public Department(string name)
        {
            Name = name;
        }
    }
}
