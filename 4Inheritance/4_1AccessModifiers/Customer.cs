﻿using System;

namespace AccessModifiers
{
    public class Customer
    {
       
        public string Name { get; set; }
        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed.");

        }
        
       
    }
  
}