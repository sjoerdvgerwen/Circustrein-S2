 using System.Runtime.Serialization;

namespace Circustrein
{
    public class Herbivore : Animal
    {
        public AnimalSize Size { get; set; }
        
        public Herbivore(AnimalSize size) : base(size, AnimalType.Herbivore)
        {
            Size = size;
        }
    }
}