﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _21122022
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public int Millage;


        public Vehicle(string brand, string model, int millage )
        {
            this.Brand = brand;
            this.Model = model;
            this.Millage = millage ;
        }
        public Vehicle() 
        { 

        }
    }
}
