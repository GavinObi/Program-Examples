using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraClass
{
    class Hero:Person // inherits from person class
    {
        public Hero()
        {

        }
        //Overloaded constructor inheriting from the person class
        public Hero(string aliasParam, double healthParam, int attackParam, int chanceParam):base(aliasParam, healthParam, attackParam, chanceParam)
        {

        }
        //Overriding ToString method
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}",Alias, Health, Attack, Chance);
        }
    }
}
