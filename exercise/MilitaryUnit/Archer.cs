using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_william
{
    class Archer : Samurai
    {
        
        public Archer()
        {
            Archer.class_name = "Archer";
            Archer.weapon = "Short Bow";
            Archer.base_hit_Point = 25;
            Archer.base_attack = 3;
            Archer.base_armor = 1.5;
            Archer.attack_range = 22.5;
            Archer.movement_speed = 3.3;
            Archer.travel_method = "walk";
            Archer.counter = "Spearman";
            Archer.combat_action = "shoots";

        }
        public override void Attack(string enemy)
        {
            base.Attack(enemy);
        }
        public override void Defend()
        {
            base.Defend();
        }
        public override void Mission()
        {
            base.Mission();
        }
        public override void Travel()
        {
            base.Travel();
        }

    }
}
