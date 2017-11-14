using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreePigsTaleV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig NafNaf = new Pig("Naf-Naf");
            Pig NifNif = new Pig("Nif-Nif");
            Pig NufNuf = new Pig("Nuf-Nuf");
            Wolf Wolf = new Wolf("Wolf");

            NafNaf.BuildHouse(Material.Straw);
            NifNif.BuildHouse(Material.Wood);
            NufNuf.BuildHouse(Material.Stone);
            Console.WriteLine();
            NafNaf.Tease(Wolf);

            


            Console.ReadLine();
        }
    }
}
