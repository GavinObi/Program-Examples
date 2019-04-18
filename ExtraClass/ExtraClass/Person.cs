using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraClass
{
    abstract class Person //abstract parent class
    {
        private string alias;
        private double health;
        private int attack;
        private int chance;

        public double Health
        {
            get { return health; }
            set { health = value; }
        }        
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }        
        public int Chance
        {
            get { return chance; }
            set { chance = value; }
        }
        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }

        public Person()
        {

        }
        public Person(string aliasParam, double healthParam, int chanceParam, int attackParam)
        {
            alias = aliasParam;
            health = healthParam;
            chance = chanceParam;
            attack = attackParam;
        }
       

    }
}
