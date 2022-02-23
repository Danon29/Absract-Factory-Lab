using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class LionFactory : INature
    {
        public IAbstractMale CreateMaleAnimal()
        {
            return new LionMale();
        }

        public IAbstractFemale CreateFemaleAnimal()
        {
            return new LionFemale();
        }
    }
}
