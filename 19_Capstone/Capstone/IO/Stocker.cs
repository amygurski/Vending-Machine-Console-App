﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    class Stocker
    {
        //TODO: Add error handling if stock file not found
        public string[] GetStock()
        {
            string inputfile = "vendingmachine.csv";
            string[] stock;

            //using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\" + inputfile))
            //{
            //    stock = sr.ReadToEnd();
            //}

            //TODO: Add error handling if stock file not found
            stock = File.ReadAllLines(Environment.CurrentDirectory + "\\" + inputfile);

            return stock;
        }
       
    }
}
