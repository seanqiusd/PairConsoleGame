using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PairProgramGame
{

    public class ProgramUI
    {
        private bool _isRunning = true;
        private bool _isAlive = true; // Address whether we want this?
        private int Lives = 1;
        public void Start()
        {
            Menu();
        }

        private void Menu()
        {
            while (_isRunning)
            {
                string input = GetMenuSelection();
                OpenMenuItem(input);
            }
        }

        private string GetMenuSelection()
        {
            Console.Clear();
            //Console.WriteLine($"Lives: {Lives}");
            Console.WriteLine("In a place far, far, far, far, farrrrrrrrrr away, you wake up, unsure of where you're at. Suddenly, words appear out of thin air in front of you! And yes, we are aware we're being extra melodramatic, but just go with it. Anyways, the message reads:");
            Thread.Sleep(6000);
            Console.Clear();
            Console.WriteLine(
                "Hello, courageous adventurer! Welcome to Castle Saga!\n" +
                "Select an Option!\n" +
                "1. Right - Go right into a spooky room\n" +
                "2. Left - Go left into the Dungeon\n" +
                "3. Turn Around\n"
                );
            string input = Console.ReadLine();
            return input;
        }

        private void OpenMenuItem(string input)
        {
            Console.Clear();
            switch (input)
            {
                case "1":
                    Console.WriteLine("You went right");
                    UserWentRightFirst();
                    return;
                case "2":
                    Console.WriteLine("You went left");
                    Lives -= 1; // Address this lives thing
                    UserWentLeftFirst();
                    return;
                case "3":
                    Console.WriteLine("You went nowhere");
                    TurnAroundScreen(); // Look at notes I left at method
                    Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("That's not an option. What's wrong with you?");
                    break;
            }
            Console.WriteLine("Press a key to return to menu...");
            Console.ReadKey();

        }

        private void UserWentRightFirst()
        {
            Console.Clear();
            //Console.WriteLine($"Lives: {Lives}");
            Console.WriteLine(
                "You went Right!\n" +
                "Which way now?\n" +
                "1. Take a right to where the mouth-watering aroma of freshly baked bread is calling to your poor starved soul.\n" +
                "2. Left towards the melodic singing.\n" +
                "3. Go back because ya chicken.\n"
                );
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    WentRightOffTheBat();
                    break;
                case "2":
                    WentLeftOffTheBat();
                    break;
                case "3":
                    Menu();
                    //gittest
                    return;
            }
            Console.WriteLine("Press a key to return to menu...");
            Console.ReadKey();

            //return input;
        }

        private void WentRightOffTheBat()
        {
            Console.Clear();
            //Console.WriteLine($"Lives: {Lives}");
            Console.WriteLine(
                "So you decided to follow your stomach. Can't say we blame ya.\n" +
                "Now where do you go from here?\n" +
                "1. Down the stairs to where the sweet smell of sustenance is strongest.\n" +
                "2. Left because you came to your senses that maybe you shouldn't be trying to eat anything from a strange place.\n"
                );
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You fell down the stairs and woke up at the start");
                    break;
                case "2":
                    Console.WriteLine("Dead End. Hey, don't blame us. You're the one in control remember, but you should probably turn around. ");
                    Console.WriteLine("Press a key to go back...");
                    Console.ReadKey();
                    UserWentRightFirst();
                    return;
            }
        }

        private void WentLeftOffTheBat()
        {
            Console.Clear();
            //Console.WriteLine($"Lives: {Lives}");
            Console.WriteLine(
                "Where to next?\n" +
                "1. Down the hallway towards the direction you feel a draft coming.\n" +
                "2. To the Doors where the singing is growing louder.\n"
                );

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CongratsScreen();
                    break;
                case "2":
                    Console.WriteLine("You opened the doors to be met with a sandy beach and beautiful merfolk. You take one step towards them, but then got killed, GG. Little too late for your realization, but they weren't merfolk; they were sirens waiting to drown ya.");
                    _isRunning = false;
                    return;
            }
        }

        private void CongratsScreen()
        {
            Console.Clear();
            Console.WriteLine(
                "Congatulations!!! You made it out of that weirdness!!\n" //+
                //"\nPath to win if you went Right: \n" + // What is this stuff from this line to the end here?
                //"Right\n" +
                //"Left\n" +
                //"Down to the hallway\n"
                );
        }

        private void TurnAroundScreen()
        {
            Console.Clear();
            Console.WriteLine(
                "Congratulations, Took the easy way out huh, but the jokes on you, you just ended up in the same spot." // Should we add, but the jokes on you bc turning around just gets you right back to the beginning?
                );
            //Console.ReadLine();
            //Thread.Sleep(1000);
            //gittest3
        }

        private void UserWentLeftFirst()
        {
            Console.Clear();
            //Console.WriteLine($"Lives: {Lives}");
            Console.WriteLine(
                "You went Left\n" +
                "Door Slammed Behind You!\n" +
                "Which way now?\n" +
                "1. Straight because you're too startled to go in any other direction.\n" + // User Dies
                "2. Upstairs because you might as well take a chance.\n"
                );
            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    Console.WriteLine("You got attacked by a ghoul and now ya dead.");
                    //Console.ReadLine();
                    _isRunning = false; //this is for testing, will put something here.
                    break;
                case "2":
                    UserWentUpStairs();
                    break;
                default:
                    Console.WriteLine("We see what you're trying to do, but we're not gonna let ya."); // do we want every default to go right to the beginning? 
                    Thread.Sleep(1000);
                    //Console.ReadLine();
                    UserWentLeftFirst();
                    break;
            }
            Console.WriteLine("Press a key to return to menu...");
            Console.ReadLine();
        }

        private void UserWentUpStairs()
        {
            Console.Clear();
            Console.WriteLine(
                "So you wanted to be ballsy and act like a protagonist, huh?.\n" +
                "What do you do now?\n" +
                "1. You take the dusty cloth off what appears to be a hallway mirror directly in front of you.\n" +
                "2. You take a right towards the light.\n" +
                "3. You go to the left where there's a toy monkey standing in the middle of that hallway with a piece of paper clutched in its creepily realistic hands.\n");
            string input = Console.ReadLine();
            bool hasLight = true;
            switch (input)
            {
                case "1":
                    _isRunning = false; // Come back later to replace with death
                    Console.WriteLine("You died because your reflection was just that frieghtening. What a sad way to go. Some protagonist you are.");
                    break;
                case "2":
                    if (hasLight)
                    {
                        Console.Clear();
                        Console.WriteLine(
                            "You head towards the light, but it turns out that was just the light emanating from a ghost.\n" +
                            "What should you do now?\n" +
                            "1. Sneak past the ghost.\n" +
                            "2. Greet the ghost.\n" +
                            "3. Grab the cordless vacuum, praying to the gods that you pull out some Ghostbuster move.\n");
                        string input3 = Console.ReadLine();
                        switch (input3)
                        {
                            case "1":
                                Console.WriteLine("You get possessed by the ghost and it takes you back to where you started.");
                                Thread.Sleep(5000);
                                //_isRunning = false;
                                Menu();
                                break;
                            case "2":
                                Console.WriteLine("You greet the ghost and now you're friends. It guides you out in one piece.");
                                Thread.Sleep(5000);
                                CongratsScreen();
                                break;
                            case "3":
                                Console.WriteLine("You didn't succeed in capturing the ghost in the vaccuum. The ghost ends up violently killing you. Jeez, you had one job to do.");
                                _isRunning = false; // Come back
                                break;
                            default:
                                Console.WriteLine("Invalid entry. You're not getting past this one!");
                                Thread.Sleep(1000);
                                //Console.ReadLine();
                                UserWentUpStairs();
                                return;
                        }
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("You wrangle the piece of paper out of the toy monkey's hands. There's a message on it that says to look up.\n" +
                        "What do you do?\n" +
                        "1. You look up.\n" +
                        "2. You don't trust the toy monkey. Something about its smile bothers you, so you look down.\n");
                    string input2 = Console.ReadLine();
                    switch (input2)
                    {
                        case "1":
                            Console.WriteLine("Ya dead. Looked right into the eyes of a basilisk and got petrified forever. And yes, it is the same basilisk from a certain series that sounds like Harry Pothead.");
                            Thread.Sleep(5000);
                            Menu();
                            //_isRunning = false; // Come back
                            break;
                        case "2":
                            Console.WriteLine("As you looked down, magical silvery marks appear before you (magik!), showing you the way out.");
                            Thread.Sleep(5000);
                            CongratsScreen();
                            break;
                            //default: // We need to fix this issue where if they press an invalid entry, right now it just goes right back to the beg
                            //Console.WriteLine("How many times must we repeat to you! You made a choice and now you must endure the consequences. Choose wisely from the selections you've given you!");
                            //return;
                    }
                    break;

            }
            }

        }

    }


