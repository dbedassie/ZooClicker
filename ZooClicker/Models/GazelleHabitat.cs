using System;
namespace ZooClicker.Models
{
    public class FrogHabitat : Habitat
    {
        public FrogHabitat(int lvl = 1, float cst = 100, float don = 10, string n = "Frog")
            : base(lvl, cst, don, n)
        {
        }
    }
}
