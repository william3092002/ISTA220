using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_william
{
    class Bowmaster : Archer
    {
        public Bowmaster()
        {
            Samurai.class_name = "Bowmaster";
            Samurai.attack_range = 38.2;
            Samurai.base_armor = 2.0;
            Samurai.base_hit_Point = 25;
            Samurai.base_attack = 5;
            Samurai.combat_action = "shoots";
            Samurai.counter = "Spearman and Archer";
            Samurai.movement_speed = 3.8;
            Samurai.weapon = "Long Bow";
            Samurai.travel_method = "jog";
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
