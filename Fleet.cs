using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Vs._Dinosaurs
{
    class Fleet
    {
        public Robot ganon;
        public Robot kingKRool;
        public Robot rob;
        Random rand = new Random();

        public Fleet()
        {
            ganon = new Robot(1);
            {
                ganon.name = "Ganondorf";
                ganon.health = 150;
                ganon.powerLevel = 100;
            }

            kingKRool = new Robot(1, 2);
            {
                kingKRool.name = "King K. Rool";
                kingKRool.health = 200;
                kingKRool.powerLevel = 100;
            }
            
            rob = new Robot(1, 2, 3);
            {
                rob.name = "R.O.B.";
                rob.health = 100;
                rob.powerLevel = 100;
            }
            
        }

        public void AttackDinosaur(Dinosaur target, Robot robot, Weapon weapon)
        {
            while(robot.powerLevel < weapon.powerLevelReduction)
            {
                Console.WriteLine("Not enough power to use that weapon");
                weapon = ChooseWeapon(robot);
            }
            if(robot.powerLevel >= weapon.powerLevelReduction)
            {
                target.health -= weapon.attackPower;
                robot.powerLevel -= weapon.powerLevelReduction;

                if (target.health <= 0)
                {
                    Console.WriteLine($"{target.type.ToUpper()} HAS DIED!");
                }
            }
            
            
        }

        public Weapon ChooseWeapon(Robot robot)
        {
            if(robot == ganon)
            {
                Console.WriteLine($"Choose which weapon Ganondorf will use \n1) {robot.ganonWeapons[0].name}\n" +
                                                                           $"Damage: {robot.ganonWeapons[0].attackPower}\n" +
                                                                           $"Power Level Reduction: {robot.ganonWeapons[0].powerLevelReduction}\n" +
                                                                           $"2) {robot.ganonWeapons[1].name}\n" +
                                                                           $"Damage: {robot.ganonWeapons[1].attackPower}\n" +
                                                                           $"Power Level Reduction: {robot.ganonWeapons[1].powerLevelReduction}\n" +
                                                                           $"3) {robot.ganonWeapons[2].name}\n" +
                                                                           $"Damage: {robot.ganonWeapons[2].attackPower}\n" +
                                                                           $"Power Level Reduction: {robot.ganonWeapons[2].powerLevelReduction}");
                Console.WriteLine("---------------------------------");
                int weaponChoice;
                weaponChoice = Convert.ToInt32(Console.ReadLine());

                switch (weaponChoice)
                {
                    case 1:
                        return ganon.ganonWeapons[0];
                    case 2:
                        return ganon.ganonWeapons[1];
                    case 3:
                        return ganon.ganonWeapons[2];
                    default:
                        return ganon.ganonWeapons[0];
                }
            }
            else if(robot == kingKRool)
            {
                Console.WriteLine($"Choose which weapon King K. Rool will use \n1) {kingKRool.kingWeapons[0].name}\n" +
                                                                                $"Damage: {kingKRool.kingWeapons[0].attackPower}\n" +
                                                                                $"Power Level Reduction: {kingKRool.kingWeapons[0].powerLevelReduction}\n" +
                                                                                $"2) {kingKRool.kingWeapons[1].name}\n" +
                                                                                $"Damage: {kingKRool.kingWeapons[1].attackPower}\n" +
                                                                                $"Power Level Reduction: {kingKRool.kingWeapons[1].powerLevelReduction}\n" +
                                                                                $"3) {kingKRool.kingWeapons[2].name}\n" +
                                                                                $"Damage: {kingKRool.kingWeapons[2].attackPower}\n" +
                                                                                $"Power Level Reduction: {kingKRool.kingWeapons[2].powerLevelReduction}");
                Console.WriteLine("---------------------------------");
                int weaponChoice;
                weaponChoice = Convert.ToInt32(Console.ReadLine());

                switch (weaponChoice)
                {
                    case 1:
                        return robot.kingWeapons[0];
                    case 2:
                        return robot.kingWeapons[1];
                    case 3:
                        return robot.kingWeapons[2];
                    default:
                        return robot.kingWeapons[0];
                }
            }
            else if(robot == rob)
            {
                Console.WriteLine($"Choose which weapon R.O.B. will use\n1) {rob.robWeapons[0].name}\n" +
                                                                         $"Damage: {rob.robWeapons[0].attackPower}\n" +
                                                                         $"Power Level Reduction: {rob.robWeapons[0].powerLevelReduction}\n" +
                                                                         $"2) {rob.robWeapons[1].name}\n" +
                                                                         $"Damage: {rob.robWeapons[1].attackPower}\n" +
                                                                         $"Power Level Reduction: {rob.robWeapons[1].powerLevelReduction}\n" +
                                                                         $"3) {rob.robWeapons[2].name}\n" +
                                                                         $"Damage: {rob.robWeapons[2].attackPower}\n" +
                                                                         $"Power Level Reduction: {rob.robWeapons[2].powerLevelReduction}");
                Console.WriteLine("---------------------------------");
                int weaponChoice;
                weaponChoice = Convert.ToInt32(Console.ReadLine());

                switch (weaponChoice)
                {
                    case 1:
                        return robot.robWeapons[0];
                    case 2:
                        return robot.robWeapons[1];
                    case 3:
                        return robot.robWeapons[2];
                    default:
                        return robot.robWeapons[0];
                }
            }
            else
            {
                return ganon.ganonWeapons[0];
            }
        }
    }
}
