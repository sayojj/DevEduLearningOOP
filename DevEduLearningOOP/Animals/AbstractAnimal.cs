using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevEduLearningOOP.BiomType;

namespace DevEduLearningOOP.Animals
{

    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public double ConsumedFood { get; set; }
        // public BiomType Biome { get; set; }
        public double Age { get; set; }
        public double Volume { get; set; }
        public bool IsPredator { get; set; }
        protected string sound;

        public AbstractAnimal(string name, double age)
        {
            ConsumedFood = 0;
            Name = name;
            Age = age;
            IsPredator = true;
        }
    }
}
