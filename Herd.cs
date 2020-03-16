using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Vs._Dinosaurs
{
    class Herd
    {
        Random rand = new Random();
        public Dinosaur tRex;
        public Dinosaur triceratops;
        public Dinosaur velociraptorSwarm;
        public Herd()
        {
            tRex = new Dinosaur(1);
            tRex.type = "T-Rex";
            tRex.health = 150;
            tRex.energy = 100;

            triceratops = new Dinosaur(1,2);
            triceratops.type = "Triceratops";
            triceratops.health = 200;
            triceratops.energy = 100;

            velociraptorSwarm = new Dinosaur(1,2,3);
            velociraptorSwarm.type = "Velociraptor Swarm";
            velociraptorSwarm.health = 75;
            velociraptorSwarm.energy = 100;

        }
        public void AttackRobot(Robot target, Dinosaur dinosaur)
        {
            AttackType attack = ChooseAttack(dinosaur);
            target.health -= attack.attackPower;
            dinosaur.energy -= attack.energyReduction;
        }

        public AttackType ChooseAttack(Dinosaur dinosaur)
        {
            AttackType attackChoice;

                if (dinosaur == tRex)
                {
                    Console.WriteLine($"Choose which attack you would like to use \n1) {dinosaur.tRexAttacks[0].name}\n" +
                                                                             $"Damage: {dinosaur.tRexAttacks[0].attackPower}\n" +
                                                                                  $"2) {dinosaur.tRexAttacks[1].name}\n" +
                                                                             $"Damage: {dinosaur.tRexAttacks[1].attackPower}\n" +
                                                                                  $"3) {dinosaur.tRexAttacks[2].name}\n" +
                                                                             $"Damage: {dinosaur.tRexAttacks[2].attackPower}");
                    int attackOption = Convert.ToInt32(Console.ReadLine());
                    switch (attackOption)
                    {
                        case 1:
                            attackChoice = tRex.tRexAttacks[0];
                        return attackChoice;
                    case 2:
                            attackChoice = tRex.tRexAttacks[1];
                        return attackChoice;
                    case 3:
                            attackChoice = tRex.tRexAttacks[2];
                        return attackChoice;
                    default:
                            Console.WriteLine("First attack will be chosen");
                            attackChoice = tRex.tRexAttacks[0];
                        return attackChoice;
                }

                }
                else if (dinosaur == triceratops)
                {
                    Console.WriteLine($"Choose which attack you would like to use \n1) {dinosaur.triceratopsAttacks[0].name}\n" +
                                                                             $"Damage: {dinosaur.triceratopsAttacks[0].attackPower}\n" +
                                                                                  $"2) {dinosaur.triceratopsAttacks[1].name}\n" +
                                                                             $"Damage: {dinosaur.triceratopsAttacks[1].attackPower}\n" +
                                                                                  $"3) {dinosaur.triceratopsAttacks[2].name}\n" +
                                                                             $"Damage: {dinosaur.triceratopsAttacks[2].attackPower}");
                    int attackOption;

                    attackOption = Convert.ToInt32(Console.ReadLine());
                    switch (attackOption)
                    {
                        case 1:
                            attackChoice = triceratops.triceratopsAttacks[0];
                        return attackChoice;
                    case 2:
                            attackChoice = triceratops.triceratopsAttacks[1];
                        return attackChoice;
                    case 3:
                            attackChoice = triceratops.triceratopsAttacks[2];
                        return attackChoice;
                    default:
                            Console.WriteLine("First attack will be chosen");
                            attackChoice = triceratops.triceratopsAttacks[0];
                        return attackChoice;
                }
                }
                else if (dinosaur == velociraptorSwarm)
                {
                    Console.WriteLine($"Choose which attack you would like to use \n1) {velociraptorSwarm.velociraptorSwarmAttacks[0].name}\n" +
                                                                             $"Damage: {velociraptorSwarm.velociraptorSwarmAttacks[0].attackPower}\n" +
                                                                                  $"2) {velociraptorSwarm.velociraptorSwarmAttacks[1].name}\n" +
                                                                             $"Damage: {velociraptorSwarm.velociraptorSwarmAttacks[1].attackPower}\n" +
                                                                                  $"3) {velociraptorSwarm.velociraptorSwarmAttacks[2].name}\n" +
                                                                             $"Damage: {velociraptorSwarm.velociraptorSwarmAttacks[2].attackPower}");
                    int attackOption;

                    attackOption = Convert.ToInt32(Console.ReadLine());
                    switch (attackOption)
                    {
                        case 1:
                            attackChoice = velociraptorSwarm.velociraptorSwarmAttacks[0];
                        return attackChoice;
                    case 2:
                            attackChoice = velociraptorSwarm.velociraptorSwarmAttacks[1];
                        return attackChoice;
                    case 3:
                            attackChoice = velociraptorSwarm.velociraptorSwarmAttacks[2];
                        return attackChoice;
                    default:
                            Console.WriteLine("First attack will be chosen");
                            attackChoice = velociraptorSwarm.velociraptorSwarmAttacks[0];
                        return attackChoice; 
                    }
                }
            else
            {
                attackChoice = tRex.tRexAttacks[0];
                return attackChoice;
            }

            
            
                
        }

    }
}
