using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduLearningOOP.Animals
{
    public class Panda : AbstractAnimal
    {
        public Panda(string name, double age) : base(name, age)
        {
            IsPredator = true;
            sound = "Woo Woo";
        }
    }
}
