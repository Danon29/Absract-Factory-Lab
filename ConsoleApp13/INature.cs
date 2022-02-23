using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public interface INature
    {
        public IAbstractMale CreateMaleAnimal();

        public IAbstractFemale CreateFemaleAnimal();

    }

}