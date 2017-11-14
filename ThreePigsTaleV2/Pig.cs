using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreePigsTaleV2
{
    class Pig : Animal
    {
        public House House { get; private set; }
        bool inSafety = true;
        public static Dictionary<Pig, int?> neighbors = new Dictionary<Pig, int?>();
        
        public Pig(string name) : base(name)
        {
        }

        public void BuildHouse(Material material)
        {
            House = new House(this, material);
            neighbors[this] = House.Distance;
            House.GiveShelter(this);
            House.GetBroken += RunAway;
        }

        public void Tease(Wolf wolf)
        {
            Console.WriteLine($"{Name} teases {wolf.Name}");
            wolf.GetTeased(this);
        }

        public void RunAway(Wolf wolf)
        {
            inSafety = false;
            neighbors.Remove(this);
            Console.WriteLine($"{Name} runs away from {wolf.Name}");
            wolf.Chase(this);
        }

        public void HideNearestHouse(Wolf wolf)
        {
            Console.WriteLine($"{Name} hides nearest friend's house");
            neighbors.OrderBy(k => k.Value).First().Key.House.GiveShelter(this);
            inSafety = true;
            wolf.Blow(this);
        }
    }
}
