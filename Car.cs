using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _21122022
{
    internal class Car:Vehicle
    {
        public Car(int fuelCapacity, int currentfuel, int addfuel) 
        {
            

            this.FuelCapacity = fuelCapacity;
            this.Currentfuel = currentfuel;
            this.Addfuel = addfuel;
        }

        public Car()
        {

        }

        public int FuelCapacity;
        public int Currentfuel;
        public int Addfuel;

        //parametr olaraq neçə litr benzin əlavə etmək istənildiyi daxil edilməlidir
        //və capacity-ni aşmırsa əlavə edilməlidir
        public int Addlitr(int litre)
        {
            Addfuel = litre;
            
            if (Currentfuel + litre <= FuelCapacity)
            {
                FuelCapacity = Currentfuel + litre;
                Currentfuel= litre;
                Console.WriteLine("Benzin Elave Edildi") ;
                  
            }

            else if (Currentfuel + litre >= FuelCapacity)
            {
                Console.WriteLine("Bak 100 litrden artiq tutmur");
                Console.WriteLine(" Olan benzin ");
                
                
            }
            
            return litre;   
            
        }
    }
}
