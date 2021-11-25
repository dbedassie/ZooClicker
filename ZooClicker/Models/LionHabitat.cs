using System;
namespace ZooClicker.Models
{
    public class LionHabitat : Habitat
    {
        public LionHabitat(int lvl = 1, float cst = 100, float don = 10, string n = "Lion")
        {
            level = lvl;
            cost = cst;
            donations = don;
            name = n;
        }
    }
}
