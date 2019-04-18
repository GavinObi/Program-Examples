using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraClass
{
    class SideKick:Person
    {
        public SideKick()
        {

        }
         public SideKick(string aliasParam, double healthParam, int attackParam, int chanceParam):base(aliasParam, healthParam, attackParam, chanceParam)
        {

        }
         public override string ToString()
         {
             return string.Format("{0},{1},{2},{3}", Alias, Health, Attack, Chance);
         }
    }
}
