﻿namespace day19assignment
{

    class Program
    {
        static void Main(String[] args)
        {
            Patterns patterns = new Patterns();
            //Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
            if (patterns.validateString("91 7440551190"))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}