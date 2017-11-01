﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class DiceRollerCommandParser
    {
        //kommentaar
       
       
        public List<Dice> Source(string input)
        {

            List<Dice> korrad = new List<Dice>();

            var dices = new List<Dice>();

            string täringud = input;
            string[] täring = täringud.Split(' ');

            foreach (var osa in täring)
            {

                var a = osa.Split('d')[0];
                int kordused = Int32.Parse(a); 
                var täringuSuurus = osa.Split('d')[1];
                korrad.Add(new Dice(kordused, täringuSuurus));
                
            }
            foreach (var kord in korrad)
            {
                if (kord.Description == "6")
                {
                    for (int i = 0; i < kord.Sides; i++)
                    {
                        dices.Add(Dice.D6);
                    }
                     
                }
                else if (kord.Description == "8")
                {
                    for (int i = 0; i < kord.Sides; i++)
                    {
                        dices.Add(Dice.D8);
                    }
                }
                else if (kord.Description == "20")
                {
                    for (int i = 0; i < kord.Sides; i++)
                    {
                        dices.Add(Dice.D20);
                    }
                }
               else if (kord.Description == "4")
                {
                    for (int i = 0; i < kord.Sides; i++)
                    {
                        dices.Add(Dice.D4);
                    }
                }
                else if (kord.Description == "12")
                {
                    for (int i = 0; i < kord.Sides; i++)
                    {
                        dices.Add(Dice.D12);
                    }
                }
                else if (kord.Description == "10")
                {
                    for (int i = 0; i < kord.Sides; i++)
                    {
                        dices.Add(Dice.D10);
                    }
                }
            }


            /*

            if (input == "/roll 3d6 2d8")
            {
                dices.Add(Dice.D6);
                dices.Add(Dice.D6);
                dices.Add(Dice.D6);
                dices.Add(Dice.D8);
                dices.Add(Dice.D8);

            }
            if (input == "/roll 1d20")
            {
                dices.Add(Dice.D20);
             
            }
            if (input == "/roll 3d6 2d10")
            {
                dices.Add(Dice.D6);
                dices.Add(Dice.D6);
                dices.Add(Dice.D6);
                dices.Add(Dice.D10);
                dices.Add(Dice.D10);

            }
            if (input == "/roll 12d4 1d12")
            {
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D4);
                dices.Add(Dice.D12);
                

            }*/

            return dices;
        }
    }
}
