using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    [Serializable]
    class FireType : Pokemon
    {
       
        public FireAtk ultraAtk { get; set; }
        



        public override string useBasicAtk()
        {
            return this.Name + " used " + basicAtk;
        }

        public override string useUltraAtk()
        {
            return this.Name + " used " + ultraAtk.ToString() + " for " + (int)ultraAtk + " Dammage!";
                   
        }

        public FireType(string name,int hp,FireAtk ultra)
        {
            this.weakTo = "Water";
            this.type = "Fire";
            this.basicAtk = "Ember";
            this.UltraAtkName = ultra.ToString();
            this.Name = name;
            this.Hp = hp;
            ultraAtk = ultra;
            this.basicDmg = 20;

        }

    }

    
}
