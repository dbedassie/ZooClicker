using System;
namespace ZooClicker.Models
{
    public abstract class Habitat
    {
        protected int level;
        protected int cost;
        protected int donations;
        protected string name;

        public int Level { get => level; }
        public int Cost { get => cost; }
        public int Donations { get => donations; set => donations = value; }
        public string Name { get => name; set => name = value; }

        public Habitat(int lvl = 1, int cst = 1, int don = 1, string n = "Habitat")
        {
            level = lvl;
            cost = cst;
            donations = don;
            name = n;
        }

        public int LevelUp()
        {
            level++;
            cost = (int)Math.Floor((float)cost * 1.5f);
            Donations += (int)Math.Floor((float)Donations / 5);
            return cost;
        }

        public bool CheckIfBuy(int money)
        {
            return money < cost ? false : true;
        }
    }
}
