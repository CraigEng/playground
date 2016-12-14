using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSkeleton.services
{
    public class Person : IPerson
    {
        public string GetName()
        {
            return "Jesse Jude Engelbrecht";
        }
    }
}
