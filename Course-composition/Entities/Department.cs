using System;

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
