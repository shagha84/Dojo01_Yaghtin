using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo01_Yaghtin
{
    class TestObject
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Age}";
        }

        public TestObject(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}