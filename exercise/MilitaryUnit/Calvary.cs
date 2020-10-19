using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_william
{
    class Calvary : Samurai
    {
        public Calvary()
        {
            Samurai.class_name = "Calvary";
            Samurai.attack_range = 3.2;
            Samurai.base_armor = 5.0;
            Samurai.base_hit_Point = 50;
            Samurai.base_attack = 6;
            Samurai.combat_action = "charge and ram";
            Samurai.counter = "Archer and Bowmaster";
            Samurai.movement_speed = 20.5;
            Samurai.weapon = "Lance";
            Samurai.travel_method = "ride on horse and travel";
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
