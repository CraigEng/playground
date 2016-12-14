using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSkeleton.services
{
    public class Person : IPerson
    {
        public string GetPerson()
        {
            return "Jesse Jude Engelbrecht";
        }
    }
}
