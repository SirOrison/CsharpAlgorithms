﻿using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Lasagna lasagna = new Lasagna();

            int minutes = lasagna.ExpectedMinutesInOven();

            Console.WriteLine(lasagna.RemainingMinutesInOven(30));

            QuestLogic logic = new QuestLogic();

            Console.WriteLine(logic.CanFastAttack(false)); 
        }
    }
}


