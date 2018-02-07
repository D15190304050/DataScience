﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;

namespace MachineLearning
{
    public class Program
    {
        public static int Main(string[] args)
        {
            //UnitTest.MachineLearningUtilTest();
            //ClassifyPerson();

            UnitTest.SvmTest();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return 0;
        }
    }
}