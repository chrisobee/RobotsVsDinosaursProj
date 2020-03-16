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
                ganon.attackPower = rand.Next(1, 90);
            }

            kingKRool = new Robot(1, 2);
            {
                kingKRool.name = "King K. Rool";
                kingKRool.health = 200;
                kingKRool.powerLevel = 100;
                kingKRool.attackPower = rand.Next(30, 55);
            }
            
            rob = new Robot(1, 2, 3);
            {
                rob.name = "R.O.B.";
                rob.health = 100;
                rob.powerLevel = 100;
                rob.attackPower = rand.Next(25, 60);
            }
            
        }

        public void AttackDinosaur(Dinosaur target, Robot robot)
        {
            target.health -= robot.attackPower;
            //robot.powerLevel -= weapon.powerLevelReduction;
        }
    }
}
