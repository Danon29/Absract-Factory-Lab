using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class ElephantFactory : INature
    {
        public IAbstractMale CreateMaleAnimal()
        {
            return new ElephantMale();
        }

        public IAbstractFemale CreateFemaleAnimal()
        {
            return new ElephantFemale();
        }
    }
}
