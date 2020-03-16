using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Vs._Dinosaurs
{
    class Dinosaur
    {
        //Member Variables
        Random rand = new Random();
        public string type;
        public int health;
        public int energy;
        public bool isDead = false;
        public AttackType[] tRexAttacks;
        public AttackType[] triceratopsAttacks;
        public AttackType[] velociraptorSwarmAttacks;

        //Constructor
        public Dinosaur(int a)
        {
            tRexAttacks = new AttackType[3];

            AttackType bigChomp = new AttackType();
            bigChomp.name = "CHOMP";
            bigChomp.attackPower = rand.Next(50, 100);
            bigChomp.energyReduction = 100;
            tRexAttacks[0] = bigChomp;

            AttackType headButt = new AttackType();
            headButt.name = "Headbutt";
            headButt.attackPower = rand.Next(25,50);
            headButt.energyReduction = 50;
            tRexAttacks[1] = headButt;

            AttackType roar = new AttackType();
            roar.name = "ROAR";
            roar.attackPower = rand.Next(10, 25);
            roar.energyReduction = 25;
            tRexAttacks[2] = roar;
        }

        public Dinosaur(int a, int b)
        {
            triceratopsAttacks = new AttackType[3];

            AttackType charge = new AttackType();
            charge.name = "CHARGE";
            charge.attackPower = rand.Next(45, 90);
            charge.energyReduction = 100;
            triceratopsAttacks[0] = charge;

            AttackType stomp = new AttackType();
            stomp.name = "STOMP";
            stomp.attackPower = rand.Next(30, 65);
            stomp.energyReduction = 80;
            triceratopsAttacks[1] = stomp;

            AttackType bite = new AttackType();
            bite.name = "Bite";
            bite.attackPower = rand.Next(10, 20);
            bite.energyReduction = 20;
            triceratopsAttacks[2] = bite;
        }

        public Dinosaur(int a, int b, int c)
        {
            velociraptorSwarmAttacks = new AttackType[3];

            AttackType swarm = new AttackType();
            swarm.name = "SWARM";
            swarm.attackPower = rand.Next(50, 70);
            swarm.energyReduction = 80;
            velociraptorSwarmAttacks[0] = swarm;

            AttackType claw = new AttackType();
            claw.name = "Claw";
            claw.attackPower = rand.Next(20, 35);
            claw.energyReduction = 30;
            velociraptorSwarmAttacks[1] = claw;

            AttackType pounce = new AttackType();
            pounce.name = "Pounce";
            pounce.attackPower = rand.Next(45, 50);
            pounce.energyReduction = 60;
            velociraptorSwarmAttacks[2] = pounce;
        }

        //Member Methods
        
    }
}
