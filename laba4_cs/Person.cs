using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4_cs
{
    [Serializable]
    class Person
    {
        public string memuary { get; set; }
        public Person(string mem)
        {
            memuary = mem;
        }
    }
}
