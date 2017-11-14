using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreePigsTaleV2
{
    class Wolf : Animal
    {
        public int BlowStrength { get; }
        List<Pig> nastyPigs = new List<Pig>();
        public Wolf(string name) : base(name)
        {
            BlowStrength = 10;
        }

        public void GetTeased(Pig pig)
        {
            if (!nastyPigs.Contains(pig))
                nastyPigs.Add(pig);
                Console.WriteLine($"\t{Name} gets teased by {pig.Name}");
                Scare(pig);           
        }

        public void Scare(Pig pig)
        {
                Console.WriteLine($"\t{Name} scares {pig.Name}");
                pig.RunAway(this);
            
        }

        public void Chase(Pig p)
        {
            foreach (Pig pig in nastyPigs)
            {
                Console.WriteLine($"\t{Name} chases {pig.Name}");
                pig.HideNearestHouse(this);
            }
        }

        public void Blow(Pig p)
        {
            for(int i = 0; i <3; i++)
            {
                Console.WriteLine($"Wolf blows {i+1} time");
                if (p.House.BreakeDown(this))
                {
                    Console.WriteLine("House is broken");
                    break;
                }
                Console.WriteLine($"House is OK ");
            }
        }
    }
}
