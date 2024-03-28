using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    [Serializable]
    class GrassType : Pokemon
    {
        public GrassAtk ultraAtk { get; set; }


        public override string useBasicAtk()
        {
            return this.Name + " used " + basicAtk;
        }

        public override string useUltraAtk()
        {
            if (ultraAtk == GrassAtk.FrenzyPlant)
            {
                return this.Name + " used " + ultraAtk.ToString() + " for " + (int)ultraAtk + " Dammage!";
            }

            return this.Name + " used " + ultraAtk.ToString() + " for " + (int)ultraAtk + " Damage!";
;
        }
        public GrassType(string name, int hp, GrassAtk ultra)
        {
            this.weakTo = "Fire";
            this.type = "Grass";
            this.basicAtk = "Razor Leaf";
            this.UltraAtkName = ultra.ToString();
            this.Name = name;
            this.Hp = hp;
            this.ultraAtk = ultra;
            this.basicDmg = 10;
        }

    }
}
