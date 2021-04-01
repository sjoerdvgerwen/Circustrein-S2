using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    if (wagon.AddAnimalToWagon(animal))
                    {
                        break;
                    }

                    else if (wagons.IndexOf(wagon) == wagons.Count - 1)
                    {
                        Wagon newWagon = new Wagon();
                        newWagon.AddAnimalToWagon(animal);
                        wagons.Add(newWagon);
                        break;
                    }
                }
            }
            return false;
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
