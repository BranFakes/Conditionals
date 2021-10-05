using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static int score;
        static int health;
        static int Pistol;
        static int heal;
        static int currentweapon;

        static void ShowHUD()
        {
            Console.WriteLine("===HUD===");
            Console.WriteLine("health = " + health);
            Console.WriteLine("DMG Taken -25");
            Console.WriteLine("score = " + score);
            Console.WriteLine("Score increased ");


            Console.WriteLine("=======");
            Console.WriteLine("");
            Console.ReadKey();
        }

        
        static void ChangeWeapon()
        {

        }

        

        static void HpUp()
        {
            {
                health = health + 25;
                Console.WriteLine("Health Doubled");
            }

        }
        static void HealthIncreased()
        {
            if (health <= 100)
            {
                health = 100;
            }
        }

        static void TakeDamage()
        {
            health = health - 25;
            
        }
        static void AddScore()
        {
            score = score + 25;
        }
        static void scoreMultiplier()
        {
            score = score * 2;
        }

        


        static void Main(string[] args)
        {

            health = 100;
            score = 100;
           
            ShowHUD();



            TakeDamage();
            AddScore();
            scoreMultiplier();
            HpUp();

            ShowHUD();


            TakeDamage();
            AddScore();
            HpUp();
            scoreMultiplier();

            ShowHUD();


            TakeDamage();
            AddScore();
            HpUp();
            scoreMultiplier();

            ShowHUD();


            TakeDamage();
            AddScore();
            HpUp();
            scoreMultiplier();

            ShowHUD();
           




          

            {






                Console.ReadKey();





















                

            }
        }
    }
}

