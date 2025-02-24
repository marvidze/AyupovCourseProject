using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyupovCourseProject
{
    public class TestClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TestClass() { }
        public TestClass(string name, string description) { Name = name; Description = description; }

        public override string ToString()
        {
            return Name + " | " + Description;
        }
    }
}
