﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    partial class Program
    {
        static void Main(string[] arg)
        {
            Text text = new Text();
            Shape shape = text;


            text.Width = 200;
            shape.Width = 100;



            Console.WriteLine(text.Width);
        }

    }
      
}