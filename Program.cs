using System;

namespace _21122022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car()
            {
                Brand = "Mercedes",
                Model = "CLS 550",
                FuelCapacity = 100,
                Currentfuel = 80,
                Addfuel = 0,
            };

            Console.WriteLine("Elave Edilen Yanacaq Miqdarini daxil edin");
            string litreStr = Console.ReadLine();
            int litre = Convert.ToInt32(litreStr);
            car1.Addlitr(litre);
            Console.WriteLine(car1.Currentfuel );


            //TASK 3 

            Console.WriteLine("Isci sayini daxil et");
            var isci = Console.ReadLine();
            int counter = Convert.ToInt32( isci );
            Employee[] humans = new Employee[counter];
            for (int i = 0; i < humans.Length; i++)
            {
                Console.WriteLine(" Iscinin Adini daxil et daxil et");
                var name = Console.ReadLine();
                Console.WriteLine(" Iscinin Soyadini daxil et daxil et");
                var surname = Console.ReadLine();   
                Console.WriteLine("Isci yasini daxil et");
                var ageStr = Console.ReadLine();
                int age = Convert.ToInt32(ageStr);

                Console.WriteLine("Isci maasini  daxil et");
                var salaryStr = Console.ReadLine();
                int salary = Convert.ToInt32(salaryStr);

                Console.WriteLine("Iscinin vezifesini daxil edin");
                var position = Console.ReadLine();

                humans[i] = new Employee(name ,surname ,age ,salary,position);



            }

        }
        
            
           
        

        
        
    }
}
