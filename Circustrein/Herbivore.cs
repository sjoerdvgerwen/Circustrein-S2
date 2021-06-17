namespace Circustrein
{
    public class Herbivore : Animal
    {
        public AnimalSize Size { get; set; }

        public Herbivore(AnimalSize size) : base(size)
        {
            Size = size;
        }

        public override string ToString()
        {
            return Size.ToString() + "Herbivore";
        }
    }
}


