using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        public List<Wagon> wagons;

        public Train()
        {
            wagons = new List<Wagon>()
            {
                new Wagon()
            };
        }

        public bool AddAnimalToWagon(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                foreach (Wagon wagon in wagons)
                {
                    if (wagon.CanAnimalBeAddedToWagon(animal))
                    {
                        break;
                    }

                    else if (wagons.IndexOf(wagon) == wagons.Count - 1)
                    {
                        Wagon newWagon = new Wagon();
                        newWagon.CanAnimalBeAddedToWagon(animal);
                        wagons.Add(newWagon);
                        break;
                    }
                }
            }
            return false;
        }

        public void AreAnimalsDistributedTheBestWay(Animal animal)
        {
            foreach (var wagon in wagons)
            {
                wagon.CurrentCapacity += wagon.CurrentCapacity;
            }

        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("");
            builder.AppendLine("          +------+          ");
            builder.AppendLine("          |  {}  |          ");
            builder.AppendLine("         X|      |X         ");
            builder.AppendLine("         X|      |X         ");
            builder.AppendLine("          |      |          ");
            builder.AppendLine("        +-+      +-+        ");
            builder.AppendLine("        |          |        ");
            builder.AppendLine("       X|          |X       ");
            builder.AppendLine("       X|          |X       ");
            builder.AppendLine("        +----------+        ");

            foreach (var wagon in wagons)
            {
                builder.Append(wagon.ToString());
            }
            return builder.ToString();
        }
    }
}
