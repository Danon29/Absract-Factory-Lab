using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class God
    {
        public void MaxAge(INature factory)
        {
            Console.WriteLine($"Средний возраст животного равен {GodPower(factory)} лет ");
        }
        public int GodPower(INature factory)
        {
            var male = factory.CreateMaleAnimal();
            var female = factory.CreateFemaleAnimal();


            return ((male.GetMaxAge() + female.GetMaxAge()) / 2);
        }
    }
}
