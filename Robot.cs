using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Vs._Dinosaurs
{
    class Robot
    {
        //Member Variables
        Random rand = new Random();
        public string name;
        public int health;
        public int powerLevel;
        public bool isDead = false;
        public List<Weapon> ganonWeapons = new List<Weapon>();
        public List<Weapon> kingWeapons = new List<Weapon>();
        public List<Weapon> robWeapons = new List<Weapon>();

        //Weapons for Ganon
        public Weapon shadowFist = new Weapon();
        public Weapon shadowSword = new Weapon();
        public Weapon shadowKick = new Weapon();
       
        //Weapons for King K. Rool
        public Weapon blunderBuss = new Weapon();
        public Weapon kingCrown = new Weapon();
        public Weapon metalGut = new Weapon();

        //Weapons for ROB
        public Weapon lazerEyes = new Weapon();
        public Weapon spinningRotor = new Weapon();
        public Weapon rocketBlast = new Weapon();

        public Robot(int a) //Asks for 1 int so these weapons are only available to Ganondorf
        {
            //Ganon weapon stats
            shadowFist.name = "Shadow Fist";
            shadowFist.attackPower = rand.Next(10, 100);
            shadowFist.powerLevelReduction = 100;

            shadowSword.name = "Shadow Sword";
            shadowSword.attackPower = rand.Next(40, 60);
            shadowSword.powerLevelReduction = 75;

            shadowKick.name = "Shadow Kick";
            shadowKick.attackPower = rand.Next(10, 30);
            shadowKick.powerLevelReduction = 50;

            ganonWeapons.Add(shadowFist);
            ganonWeapons.Add(shadowSword);
            ganonWeapons.Add(shadowKick);
        }
        public Robot(int a, int b) // Asks for 2 ints so these weapons are only available to King K. Rool 
        {
            //King K. Rool weapon stats
            blunderBuss.name = "Blunderbuss";
            blunderBuss.attackPower = rand.Next(25, 45);
            blunderBuss.powerLevelReduction = 60;

            kingCrown.name = "King Crown";
            kingCrown.attackPower = rand.Next(10, 30);
            kingCrown.powerLevelReduction = 40;

            metalGut.name = "Da Belly";
            metalGut.attackPower = rand.Next(40, 80);
            metalGut.powerLevelReduction = 100;

            kingWeapons.Add(blunderBuss);
            kingWeapons.Add(kingCrown);
            kingWeapons.Add(metalGut);
        }

        public Robot(int a, int b, int c) //Asks for 3 ints so these weapons are only available to R.O.B.
        {
            //ROB weapon stats
            lazerEyes.name = "Lazer Eyes";
            lazerEyes.attackPower = rand.Next(50, 65);
            lazerEyes.powerLevelReduction = 80;

            spinningRotor.name = "Spinning Rotor";
            spinningRotor.attackPower = rand.Next(10, 25);
            spinningRotor.powerLevelReduction = 25;

            rocketBlast.name = "Rocket Blast";
            rocketBlast.attackPower = rand.Next(35, 50);
            rocketBlast.powerLevelReduction = 50;

            robWeapons.Add(lazerEyes);
            robWeapons.Add(spinningRotor);
            robWeapons.Add(rocketBlast);
        }

        //Member Methods
        

        

    }
}
