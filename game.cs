using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace GameClassQ
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter character name");
            string Character0=Console.ReadLine();
            Console.WriteLine("enter level");
            int Level = int.Parse(Console.ReadLine());
            Console.WriteLine("enter HealthPoints");
            int HealthPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("enter AttackPower");
            int AttackPower = int.Parse(Console.ReadLine());
            Console.WriteLine("enter DefencePower");
            int DefencePower = int.Parse(Console.ReadLine());
            Console.WriteLine("enter ExperiencePower");
            int ExperiencePower = int.Parse(Console.ReadLine());
            Console.WriteLine("enter stamina");
            int Stamina= int.Parse(Console.ReadLine());
            Console.WriteLine("enter character specialAbility");
            string SpecialAbility = Console.ReadLine();
            Console.WriteLine("enter  damage:");
            int Damage= int.Parse(Console.ReadLine());

            Character s1 = new Character(Character0 , Level, HealthPoints, AttackPower, DefencePower, Stamina, Damage,SpecialAbility,ExperiencePower);
            s1.DamageUpdate();
            s1.level();
            s1.UsePotion();
            s1.TotalPowerScore();
            s1.DisplayAll();

            s1.DamageUpdate();
            Console.WriteLine($"After damage, Health: {s1.HealthPoints}");
            s1.UsePotion();
            Console.WriteLine($"After potion, Health: {s1.HealthPoints}");

            Console.WriteLine($"Total Power Score: {s1.TotalPowerScore()}");
            Console.WriteLine($"Stamina: {Stamina}");


        }



    }
    class Character
    {
        public string CharacterName;
        public int Level;
        public int HealthPoints;
        public int AttackPoint;
        public int DefensePower;
        public int ExperiencePower;
        public int Stamina;
        public string SpecialAbility;
        public int Damage;
       

        public Character(string Character , int Level , int HealthPoint , int AttackPoint , int DefensePower , int ExperiencePower ,int Stamina ,string specialAbility , int Damage)
        {
            this.CharacterName = Character;
            this.Level = Level;
            this.HealthPoints = HealthPoint;
            this.AttackPoint = AttackPoint;
            this.DefensePower = DefensePower;
            this.ExperiencePower = ExperiencePower;
            this.Stamina = Stamina;
            this.SpecialAbility = specialAbility;
            this.Damage= Damage;
        }

        public int level()
        {
            Level++;
            return Level;
        }
        
        public int DamageUpdate()
        {
            HealthPoints = HealthPoints - Damage;
            return HealthPoints;
        }
        public int UsePotion()
        {
            HealthPoints = HealthPoints + 50;
            return HealthPoints;
        }
        public int TotalPowerScore()
        {
            int TotalPowerScore = AttackPoint + DefensePower;
            return TotalPowerScore;
        }

        public void DisplayAll()
        {
            Console.WriteLine("-----All info of character is here-----");
            Console.WriteLine($"Character:{CharacterName}");
            Console.WriteLine($"Level:{Level}");
            Console.WriteLine($"healthPoint:{HealthPoints}");
            Console.WriteLine($"DefencePoints:{DefensePower}");
            Console.WriteLine($"ExpereincePoints:{ExperiencePower}");
            Console.WriteLine($"Astamina:{Stamina}");
            Console.WriteLine($"SpecialAbility:{SpecialAbility}");
            Console.WriteLine($"damage:{Damage}");
        }




    }

}