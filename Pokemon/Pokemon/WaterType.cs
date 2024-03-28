using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    [Serializable]
    class WaterType : Pokemon
    {

        public WaterAtk ultraAtk { get; set; }

        public override string useBasicAtk()
        {
            return this.Name + " used " + basicAtk;
        }

        public override string useUltraAtk()
        {
            return this.Name + " used " + ultraAtk.ToString() + " for " + (int)ultraAtk + " Dammage!";
        }
        public WaterType(string name, int hp, WaterAtk ultra)
        {
            this.weakTo = "Grass";
            this.type = "Water";
            this.basicAtk = "Bubble";
            this.UltraAtkName = ultra.ToString();
            this.Name = name;
            this.Hp = hp;
            this.ultraAtk = ultra;
            this.basicDmg = 15;
        }




    }
}
