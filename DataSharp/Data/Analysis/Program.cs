﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSharp.Mathematics;

namespace DataSharp.Data.Analysis
{
    public class Program
    {
        public static int Main(string[] args)
        {
            //UnitTest.MachineLearningUtilTest();
            //ClassifyPerson();

            //UnitTest.SvmTest();
            //UnitTest.SvmRbfTest();

            //UnitTest.KmeansTest();
            //UnitTest.KmeansppTest();
            UnitTest.FcmTest();
            //UnitTest.AbcTest();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return 0;
        }
    }
}