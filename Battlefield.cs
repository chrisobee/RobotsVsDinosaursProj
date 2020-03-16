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


        //Member Methods

        /*public void ChooseRobotWeapons(List<Robot> robots)
        {
            foreach (Robot robot in robots)
            {
                fleet.ChooseWeapon(robot);
            }
        }*/
        public void AddPowerLevel(List<Robot> robots)
        {
            foreach (Robot robot in robots)
            {
                robot.powerLevel += 50;
            }
        }
        
        public void AddEnergy(List<Dinosaur> dinosaurs)
        {
            foreach (Dinosaur dinosaur in dinosaurs)
            {
                dinosaur.energy += 50;
            }
        }


        public void Fight()
        {
            robots.Add(fleet.ganon);
            robots.Add(fleet.kingKRool);
            robots.Add(fleet.rob);
            dinosaurs.Add(herd.tRex);
            dinosaurs.Add(herd.triceratops);
            dinosaurs.Add(herd.velociraptorSwarm);

            while ((fleet.ganon.health > 0 || fleet.kingKRool.health > 0 || fleet.rob.health > 0) &&
                  ( herd.tRex.health > 0 || herd.triceratops.health > 0 || herd.velociraptorSwarm.health > 0))
            {
                for (int i = 0; i < robots.Count; i++)
                {
                    if(robots[i].health <= 0)
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
                        int attackChoice = Convert.ToInt32(Console.ReadLine());

                        switch (attackChoice)
                        {
                            case 1:
                                fleet.AttackDinosaur(herd.tRex, robots[i], fleet.ChooseWeapon(robots[i]));
                                Console.WriteLine($"{dinosaurs[0].type}'s health is now: {dinosaurs[0].health}\n" +
                                        $"---------------------------------");
                                continue;
                            case 2:
                                fleet.AttackDinosaur(herd.triceratops, robots[i], fleet.ChooseWeapon(robots[i]));
                                Console.WriteLine($"{dinosaurs[1].type}'s health is now: {dinosaurs[1].health}\n" +
                                    $"---------------------------------");
                                continue;
                            case 3:
                                fleet.AttackDinosaur(herd.velociraptorSwarm, robots[i], fleet.ChooseWeapon(robots[i]));
                                Console.WriteLine($"{dinosaurs[2].type}'s health is now: {dinosaurs[2].health}\n" +
                                    $"---------------------------------");
                                continue;
                            case 4:
                                Console.WriteLine("Turn Skipped");
                                continue;
                            default:
                                Console.WriteLine("Please type the number matching the dinosaur");
                                continue;

                        }
                    }
                    

                }

                for (int j = 0; j < dinosaurs.Count; j++)
                {
                    if(dinosaurs[j].health <= 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"It's {dinosaurs[j].type}'s turn.\n Energy: {dinosaurs[j].energy}\nChoose who it should attack\n1) Ganon ({fleet.ganon.health} HP)" +
                                                                                                  $"\n2) King K. Rool ({fleet.kingKRool.health} HP)" +
                                                                                                  $"\n3) R.O.B. ({fleet.rob.health} HP)" +
                                                                                                  $"\n4) Skip Turn (to save energy)");
                        int attackChoice = Convert.ToInt32(Console.ReadLine());

                        switch (attackChoice)
                        {
                            case 1:
                                herd.AttackRobot(dinosaurs[j], fleet.ganon, herd.ChooseAttack(dinosaurs[j]));
                                Console.WriteLine($"{robots[0].name}'s health is now: {robots[0].health}\n" +
                                    $"---------------------------------");
                                continue;
                            case 2:
                                herd.AttackRobot(dinosaurs[j], fleet.kingKRool, herd.ChooseAttack(dinosaurs[j]));
                                Console.WriteLine($"{robots[1].name}'s health is now: {robots[1].health}\n" +
                                    $"---------------------------------");
                                continue;
                            case 3:
                                herd.AttackRobot(dinosaurs[j], fleet.rob, herd.ChooseAttack(dinosaurs[j]));
                                Console.WriteLine($"{robots[2].name}'s health is now: {robots[2].health}\n" +
                                    $"---------------------------------");
                                continue;
                            case 4:
                                Console.WriteLine("Turn Skipped");
                                continue;
                            default:
                                continue;
                        }
                    }
                    
                }

                AddPowerLevel(robots);
                AddEnergy(dinosaurs);
            
            }

        }


    }
}
