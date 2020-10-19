using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_william
{
    class Spearman : Samurai
    {
        public Spearman()
        {
            Samurai.class_name = "Spearman";
            Samurai.attack_range = 7.0;
            Samurai.base_armor = 3.5;
            Samurai.base_hit_Point = 40;
            Samurai.base_attack = 5;
            Samurai.combat_action = "thrusts";
            Samurai.counter = "Calvery";
            Samurai.movement_speed = 3.1;
            Samurai.weapon = "Spear";
            Samurai.travel_method = "walk";
        }
        public override void Mission()
        {
            base.Mission();
        }
        public override void Attack(string enemy)
        {
            base.Attack(enemy);
        }
        public override void Defend()
        {
            base.Defend();
        }
        public override void Travel()
        {
            base.Travel();
        }
    }
}
