using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex06_william
{
    class Samurai
    {
        public static string class_name;
        public static string weapon;
        public static double base_hit_Point;
        public static double base_armor;
        public static int base_attack;
        public static double attack_range;
        public static double movement_speed;
        public static string travel_method;
        public static string counter;
        public static string combat_action;

        public Samurai()
        {
            class_name = "Samurai";
            weapon = "katana";            
            base_hit_Point = 45;
            base_armor = 5.5;
            base_attack = 7;
            attack_range = 3.2;
            movement_speed = 2.5;
            travel_method = "walk";
            counter = "Spearman";
            combat_action = "slash";
        }
        
        public virtual void Mission()
        {
            Console.WriteLine($"I am a {Samurai.class_name}. I counter {Samurai.counter}.");
        }
        public virtual void Attack(string enemy)
        {
            string damage_dealt = $"0 to {Samurai.base_attack}";
            Console.WriteLine($"A {Samurai.class_name} can {Samurai.combat_action} at his enemy with {Samurai.weapon} and deals: {damage_dealt} damage if his enemy is within {Samurai.attack_range} ft.");
        }
        public virtual void Travel()
        {
            Console.WriteLine($"{Samurai.class_name} can {Samurai.travel_method} {Samurai.movement_speed} miles per hour");
        }
        public virtual void Defend()
        {
            Console.WriteLine($"Current hp: {Samurai.base_hit_Point}, can block incoming damage up to {Samurai.base_armor}");
        }
    }
}
