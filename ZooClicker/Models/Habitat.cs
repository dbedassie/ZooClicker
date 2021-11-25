using System;
namespace ZooClicker.Models
{
    public class Habitat
    {
        protected int level;
        protected float cost;
        protected float donations;
        protected string name;

        public int Level { get => level; }
        public float Cost { get => cost; }
        public float Donations { get => donations; set => donations = value; }
        public string Name { get => name; set => name = value; }

        public Habitat(int lvl = 1, float cst = 1, float don = 1, string n = "Habitat")
        {
            level = lvl;
            cost = cst;
            donations = don;
            name = n;
        }

        public void LevelUp()
        {
            // In the future, check total $$$ and do the math

            level++;
        }
    }
}
