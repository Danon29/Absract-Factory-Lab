using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class ElephantFemale : IAbstractFemale
    {
        public string name = "Elephant";
        public int GetMaxAge()
        {
            return 60;
        }
    }
}
