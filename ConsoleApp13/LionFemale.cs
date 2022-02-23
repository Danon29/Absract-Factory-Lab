using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class LionFemale : IAbstractFemale
    {
        public string name = "Lion";
        public int GetMaxAge()
        {
            return 14;
        }
    }
}
