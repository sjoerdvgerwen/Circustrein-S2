namespace Circustrein
{
    public class Carnivore : Animal
    {
        public AnimalSize Size { get; set; }
        public Carnivore(AnimalSize size) : base(size)
        {
            Size = size;
        }
        public override string ToString()
        {
            return Size.ToString() + "Carnivore";
        }
    }
}


