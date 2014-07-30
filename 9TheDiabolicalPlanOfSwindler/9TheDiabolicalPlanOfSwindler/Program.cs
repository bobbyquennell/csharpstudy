﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _9TheDiabolicalPlanOfSwindler
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Test\secret_plan.txt");
            sw.WriteLine("How I'll defeat Captain Amazing");
            sw.WriteLine("Another genius secret plan by The Swindler");
            sw.Write("I'll create an army of clones and ");
            sw.WriteLine("unleash them upon the citizens of Objectville.");
            string location = "the mall";
            for (int number = 0; number <= 6; number++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", number, location);
                if (location == "the mall") { location = "downtown"; }
                else { location = "the mall"; }
            }
            sw.Close();

            StreamReader reader = new StreamReader(@"c:\Test\secret_plan.txt");
            StreamWriter writer = new StreamWriter(@"c:\Test\emailToCaptainAmazing.txt");
            writer.WriteLine("To: CaptainAmazing@objectiville.net");
            writer.WriteLine("From: Commissioner@objectiville.net");
            writer.WriteLine("Subject: Can you save the day...again?");
            writer.WriteLine();
            writer.WriteLine("We've discovered the Swindler's plane:");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("The plan -> " + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Can you help us?");
            writer.Close();
            reader.Close();

        }
    }
}
