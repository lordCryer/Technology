﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer
    {
        public double Ram { get; set; }
        public readonly double ScreenSize;
        public string OS { get; set; }
        public Computer(double ram, double screenSize, string oS)
        {
            Ram = ram;
            ScreenSize = screenSize;
            OS = oS;

        }

        public void PrintStats ()
        {
            Console.WriteLine($"RAM: {Ram}{Environment.NewLine}" +
                $"Screen Size: {ScreenSize}{Environment.NewLine}" +
                $"OS: {OS}");
        }
        public void UpgradRam(double uRam)
        {
            Ram += uRam;
        }

}
