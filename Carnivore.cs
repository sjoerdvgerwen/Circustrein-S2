using System;


namespace Circustrein
{
    public class Carnivore : Animal
    {
        public AnimalSize Size { get; set; }

        public Carnivore(AnimalSize size) : base(size, AnimalType.Carnivore)
        {
            Size = size;
            
        }

        
    }
}