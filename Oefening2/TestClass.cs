using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class TestClass
    {
        public String string_text { get; set; }
        public TestClass(string string_text)
        {
            this.string_text = string_text;

        }

        public override string ToString()
        {
            return this.string_text;
        }
    }
}
