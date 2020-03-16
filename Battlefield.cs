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
        List<Robot> robots = new List<Robot>();
        List<Dinosaur> dinosaurs = new List<Dinosaur>();
        
       
        //Member Methods
        /*public string FindOutFirstTurn()
        {
            

            int firstTurn;
            firstTurn = rand.Next(fighters.Count);
            string firstFighter = fighters[firstTurn];
            return firstFighter;
        }
        public void PerformFirstTurn()
        {
            string firstFighter = FindOutFirstTurn();

            for (int i = 0; i < fighters.Count - 1; i++)
            {
                int choice = 0;
                {

                    

                }

            }
            

        } */


        public void Fight()
        {
            robots.Add(fleet.ganon);
            robots.Add(fleet.kingKRool);
            robots.Add(fleet.rob);
            dinosaurs.Add(herd.tRex);
            dinosaurs.Add(herd.triceratops);
            dinosaurs.Add(herd.velociraptorSwarm);
            
            while((fleet.ganon.health > 0 || fleet.kingKRool.health > 0 || fleet.rob.health > 0) &&
                  ( herd.tRex.health > 0 || herd.triceratops.health > 0 || herd.velociraptorSwarm.health > 0))
            {
                for (int i = 0; i < robots.Count; i++)
                {
                    Console.WriteLine($"It's {robots[i].name}'s turn. Choose who he should attack\n1) T-Rex ({herd.tRex.health} HP)" +
                                                                                                $"\n2) Triceratops ({herd.triceratops.health} HP)" +
                                                                                                $"\n3) Velociraptor Swarm ({herd.velociraptorSwarm.health} HP)");
                    int attackChoice = Convert.ToInt32(Console.ReadLine());
                    
                    switch (attackChoice)
                    {
                        case 1:
                            fleet.AttackDinosaur(herd.tRex, robots[i]);
                            Console.WriteLine($"{dinosaurs[i].type}'s health is now: {dinosaurs[i].health}");
                            continue;
                        case 2:
                            fleet.AttackDinosaur(herd.triceratops, robots[i]);
                            Console.WriteLine($"{dinosaurs[i].type}'s health is now: {dinosaurs[i].health}");
                            continue;
                        case 3:
                            fleet.AttackDinosaur(herd.velociraptorSwarm, robots[i]);
                            Console.WriteLine($"{dinosaurs[i].type}'s health is now: {dinosaurs[i].health}");
                            continue;
                        default:
                            Console.WriteLine("Please type the number matching the dinosaur");
                            continue;

                    }

                }

                for (int j = 0; j < dinosaurs.Count - 1; j++)
                {
                    Console.WriteLine($"It's {dinosaurs[j].type}'s turn. Choose who it should attack\n1) Ganon ({fleet.ganon.health} HP)" +
                                                                                                  $"\n2) King K. Rool ({fleet.kingKRool.health} HP)" +
                                                                                                  $"\n3) R.O.B. ({fleet.rob.health} HP)");
                    int attackChoice = Convert.ToInt32(Console.ReadLine());

                    switch (attackChoice)
                    {
                        case 1:
                            herd.AttackRobot(fleet.ganon, dinosaurs[j]);
                            Console.WriteLine($"{robots[j].name}'s health is now: {robots[j].health}");
                            continue;
                        case 2:
                            herd.AttackRobot(fleet.kingKRool, dinosaurs[j]);
                            Console.WriteLine($"{robots[j].name}'s health is now: {robots[j].health}");
                            continue;
                        case 3:
                            herd.AttackRobot(fleet.rob, dinosaurs[j]);
                            Console.WriteLine($"{robots[j].name}'s health is now: {robots[j].health}");
                            continue;
                        default:
                            continue;
                    }
                }
            
            }

        }


    }
}
