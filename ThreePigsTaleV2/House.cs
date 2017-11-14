using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreePigsTaleV2
{
    class House
    {
        Pig owner;
        Material material;
        List<Pig> inhabitants = new List<Pig>();
        int strength;
        public int? Distance { get; private set; }

        public event Action<Wolf> GetBroken;

        public House(Pig owner, Material material)
        {
            this.owner = owner;
            this.material = material;
            strength = (int)material * 10;
            Distance = (int)material;         
        }

        public void GiveShelter(Pig pig)
        {
            inhabitants.Add(pig);
        }

        public bool BreakeDown(Wolf wolf)
        {
            strength -= wolf.BlowStrength;
            if (strength <= 0)
            {
                inhabitants.Clear();
                Distance = null;
                GetBroken?.Invoke(wolf);
                return true;
            }
            return false;
        }

        //Pig owner;
        //List<Pig> inhabitants = new List<Pig>();
        //Material material;
        //int strength;
        //public int distance { get; private set; }

        //public event Action GetBuilt;
        //public event Action GetBroken;

        //public void Build(Pig owner, Material material)
        //{
        //    this.owner = owner;
        //    this.material = material;
        //    strength = (int)material * 10;
        //    distance = (int)material;
        //    inhabitants.Add(owner);
        //    GetBuilt?.Invoke();
        //}

        //public void Breake(Pig owner, Material material)
        //{
        //    inhabitants.Clear();
        //    GetBroken?.Invoke();
        //}
    }
}
