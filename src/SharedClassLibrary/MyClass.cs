using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharedClassLibrary
{
    public class MyClass
    {
        public MyClass() { }

        public async Task<string> ToString(string addPrefix)
        {
            return $"\"{addPrefix}\" _MyClass";
        }
    }
}
