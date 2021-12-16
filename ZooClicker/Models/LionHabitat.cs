using System;
namespace ZooClicker.Models
{
    public class LionHabitat : Habitat
    { 
        public LionHabitat(int lvl = 1, int cst = 10000, int don = 1000, string n = "Lion")
            : base(lvl, cst, don, n)
        {
            
        }
    }
}
