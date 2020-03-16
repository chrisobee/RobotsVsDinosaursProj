using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Vs._Dinosaurs
{
    class Battlefield
    {
        //Member Variables
        
        public Herd herd = new Herd(); 
        public Fleet fleet = new Fleet();
        Random rand = new Random();
        public List<Robot> robots = new List<Robot>();
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();
        public bool aliveTarget = false;
        public bool robotFirst;
        public bool energyCheck;
        public bool dinoSecondTurn;


        //Member Methods

        public void AddPowerLevel(List<Robot> robots)
        {
            foreach (Robot robot in robots)
            {
                if(robot.powerLevel <= 50)
                {
                    robot.powerLevel += 50;
                    Console.WriteLine($"{robot.name}'s Power is now: {robot.powerLevel}");
                    Console.WriteLine("---------------------------------");
                }
                else
                {
                    robot.powerLevel = 100;
                    Console.WriteLine($"{robot.name}'s Power is now: {robot.powerLevel}");
                    Console.WriteLine("---------------------------------");
                }
                
            }
        }
        
        public void AddEnergy(List<Dinosaur> dinosaurs)
        {
            foreach (Dinosaur dinosaur in dinosaurs)
            {
                if (dinosaur.energy <= 50)
                {
                    dinosaur.energy += 50;
                    Console.WriteLine($"{dinosaur.type}'s Energy is now: {dinosaur.energy}");
                    Console.WriteLine("---------------------------------");
                }
                else
                {
                    dinosaur.energy = 100;
                    Console.WriteLine($"{dinosaur.type}'s Energy is now: {dinosaur.energy}");
                    Console.WriteLine("---------------------------------");
                }
                
            }
        }

        public void PerformRobotTurn(List<Robot> robots, List<Dinosaur> dinosaurs)
        {
            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].health <= 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"It's {robots[i].name}'s turn.\nEnergy: {robots[i].powerLevel}\nChoose who he should attack\n1) T-Rex ({herd.tRex.health} HP)" +
                                                                                  $"\n2) Triceratops ({herd.triceratops.health} HP)" +
                                                                                  $"\n3) Velociraptor Swarm ({herd.velociraptorSwarm.health} HP)" +
                                                                                  $"\n4) Skip Turn (to save power)");
                    Console.WriteLine("---------------------------------");
                    aliveTarget = false;
                    while (aliveTarget == false)
                    {
                        int attackChoice = Convert.ToInt32(Console.ReadLine());

                        switch (attackChoice)
                        {
                            case 1:
                                if (herd.tRex.isDead == true)
                                {
                                    Console.WriteLine("That target is dead! Choose another");
                                    continue;
                                }
                                else
                                {
                                    fleet.AttackDinosaur(herd.tRex, robots[i], fleet.ChooseWeapon(robots[i]));
                                    Console.WriteLine($"{dinosaurs[0].type}'s health is now: {dinosaurs[0].health}\n" +
                                            $"---------------------------------");
                                    aliveTarget = true;
                                    break;
                                }

                            case 2:
                                if (herd.triceratops.isDead == true)
                                {
                                    Console.WriteLine("That target is dead! Choose another");
                                    continue;
                                }
                                else
                                {
                                    fleet.AttackDinosaur(herd.triceratops, robots[i], fleet.ChooseWeapon(robots[i]));
                                    Console.WriteLine($"{dinosaurs[1].type}'s health is now: {dinosaurs[1].health}\n" +
                                        $"---------------------------------");
                                    aliveTarget = true;
                                    break;
                                }

                            case 3:
                                if (herd.velociraptorSwarm.isDead == true)
                                {
                                    Console.WriteLine("That target is dead! Choose another");
                                    continue;
                                }
                                else
                                {
                                    fleet.AttackDinosaur(herd.velociraptorSwarm, robots[i], fleet.ChooseWeapon(robots[i]));
                                    Console.WriteLine($"{dinosaurs[2].type}'s health is now: {dinosaurs[2].health}\n" +
                                        $"---------------------------------");
                                    aliveTarget = true;
                                    break;
                                }

                            case 4:
                                Console.WriteLine("Turn Skipped");
                                continue;
                            default:
                                Console.WriteLine("Please type the number matching the dinosaur");
                                continue;

                        }
                    }

                }


            }
        }
        
        public void PerformDinoTurn(List<Robot> robots, List<Dinosaur> dinosaurs)
        {
            for (int j = 0; j < dinosaurs.Count; j++)
            {
                if (dinosaurs[j].health <= 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"It's {dinosaurs[j].type}'s turn.\n Energy: {dinosaurs[j].energy}\nChoose who it should attack\n1) Ganon ({fleet.ganon.health} HP)" +
                                                                                              $"\n2) King K. Rool ({fleet.kingKRool.health} HP)" +
                                                                                              $"\n3) R.O.B. ({fleet.rob.health} HP)" +
                                                                                              $"\n4) Skip Turn (to save energy)");
                    aliveTarget = false;
                    while (aliveTarget == false)
                    {
                        int attackChoice = Convert.ToInt32(Console.ReadLine());

                        switch (attackChoice)
                        {
                            case 1:
                                if (fleet.ganon.isDead == true)
                                {
                                    Console.WriteLine("That target is dead! Choose another");
                                    continue;
                                }
                                else
                                {
                                    herd.AttackRobot(dinosaurs[j], fleet.ganon, herd.ChooseAttack(dinosaurs[j]));
                                    Console.WriteLine($"{robots[0].name}'s health is now: {robots[0].health}\n" +
                                        $"---------------------------------");
                                    aliveTarget = true;
                                    break;
                                }

                            case 2:
                                if (fleet.kingKRool.isDead == true)
                                {
                                    Console.WriteLine("That target is dead! Choose another");
                                    continue;
                                }
                                else
                                {
                                    herd.AttackRobot(dinosaurs[j], fleet.kingKRool, herd.ChooseAttack(dinosaurs[j]));
                                    Console.WriteLine($"{robots[1].name}'s health is now: {robots[1].health}\n" +
                                        $"---------------------------------");
                                    aliveTarget = true;
                                    break;
                                }

                            case 3:
                                if (fleet.rob.isDead == true)
                                {
                                    Console.WriteLine("That target is dead! Choose another");
                                    continue;
                                }
                                else
                                {
                                    herd.AttackRobot(dinosaurs[j], fleet.rob, herd.ChooseAttack(dinosaurs[j]));
                                    Console.WriteLine($"{robots[2].name}'s health is now: {robots[2].health}\n" +
                                        $"---------------------------------");
                                    aliveTarget = true;
                                    break;
                                }

                            case 4:
                                Console.WriteLine("Turn Skipped");
                                continue;
                            default:
                                continue;
                        }
                    }

                }

            }
        }

        public bool CheckWhoGoesFirst()
        {
            int randomCheck;
            randomCheck = rand.Next(1, 10);

            if (randomCheck <= 5)
            {
                robotFirst = true;    
            }
            else
            {
                robotFirst = false;
            }
            return robotFirst;
        }

        //the method that runs the entire fight and loops until every character on one team is dead
        public void Fight()
        {
            robots.Add(fleet.ganon);
            robots.Add(fleet.kingKRool);
            robots.Add(fleet.rob);
            dinosaurs.Add(herd.tRex);
            dinosaurs.Add(herd.triceratops);
            dinosaurs.Add(herd.velociraptorSwarm);

            if(CheckWhoGoesFirst() == true)
            {
                PerformRobotTurn(robots, dinosaurs);
            }
            else
            {
                PerformDinoTurn(robots, dinosaurs);
                energyCheck = true;
            }

            while ((fleet.ganon.health > 0 || fleet.kingKRool.health > 0 || fleet.rob.health > 0) &&
                  ( herd.tRex.health > 0 || herd.triceratops.health > 0 || herd.velociraptorSwarm.health > 0))
            {
                if (energyCheck == true)
                {
                    PerformRobotTurn(robots, dinosaurs);
                    energyCheck = false;
                    if (dinoSecondTurn == true)
                    {
                        energyCheck = false;
                        dinoSecondTurn = false;
                        continue;
                    }
                    AddPowerLevel(robots);
                    AddEnergy(dinosaurs);
                }
                else if(robotFirst == true)
                {
                    PerformDinoTurn(robots, dinosaurs);
                    AddPowerLevel(robots);
                    AddEnergy(dinosaurs);
                    robotFirst = false;
                    energyCheck = true;
                    dinoSecondTurn = true;
                } 
                else
                {
                    PerformRobotTurn(robots, dinosaurs);
                    PerformDinoTurn(robots, dinosaurs);
                }

                //adding power / energy at the end of the round
                AddPowerLevel(robots);
                AddEnergy(dinosaurs);
            
            }

            if(fleet.ganon.health > 0 || fleet.kingKRool.health > 0 || fleet.rob.health > 0)
            {
                Console.WriteLine("THE ROBOTS ARE VICTORIUS");
            }
            else if(herd.tRex.health > 0 || herd.triceratops.health > 0 || herd.velociraptorSwarm.health > 0)
            {
                Console.WriteLine("THE DINOS ARE VICTORIUS");
            }

        }


    }
}
