﻿using System;

namespace DockerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World!");

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
