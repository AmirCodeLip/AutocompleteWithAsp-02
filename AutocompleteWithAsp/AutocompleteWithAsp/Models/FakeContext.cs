using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutocompleteWithAsp.Models
{
    public class FakeContext
    {
        public List<string> Names
        {
            get => new List<string>
            {
                "Oliver","Jake","Noah",
                "James","Connor","Liam",
                "John","Robert","Michael",
                "William","David","Richard",
                "Joseph","Charles","Thomas",
                "Mary","Patricia","Jennifer",
                "Elizabeth","Linda","Barbara",
                "Sarah","Jessica","Olivia",
                "Emma","Ava","Sophia","Isabella",
                "Charlotte","Amelia","Mia","Harper",
                "Evelyn","Abigail","Emily"
            };
        }
    }
}
