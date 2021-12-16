using System;
namespace ZooClicker.Models
{
    public class FrogHabitat : Habitat
    {
        public FrogHabitat(int lvl = 1, int cst = 100, int don = 10, string n = "Frog")
            : base(lvl, cst, don, n)
        {
        }
    }
}
