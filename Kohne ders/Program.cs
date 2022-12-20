using System;

namespace Kohne_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Yazini daxil edin");
            string text = Console.ReadLine();
            FixSentence(ref text);
            Console.WriteLine(text);


            // TASK2

            Console.WriteLine(FindCount(text));

            //TASK 3

            int[] numbers = { 1, 2, 3, 4 ,5 , 6  , 7  , 8};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            add(ref numbers, 20);

            //TASK 4
            string[] fullnames = { "Cavid Aliyev", "Hesen Hesenov", "Abdul Abbasov" };
            var names = makename(fullnames);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);

            }

            //TASk 5
            Console.WriteLine(" Fullname Daxil Edin");
            var str = Console.ReadLine();    
            var namees = Isfullname(str);
            Console.WriteLine(namees);
            
           


        }

        // Task1
        static void FixSentence(ref string str)
        {
            str = str.Trim();
            string newStr = "";
            var arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    newStr += arr[i];
                    if (i < arr.Length - 1)
                    {
                        newStr += ' ';
                    }

                }


            }
            str = newStr;

        }

        // TASK2
        static int FindCount(string strr)
        {
            FixSentence(ref strr);
            return strr.Split(' ').Length;

        }

        // TASK 3
        static void add(ref int[] arr, int value)
        {
            int[] newarr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];

            }
            newarr[arr.Length - 1] = value;
            arr = newarr;
        }
        // TASK 4
        static string[] makename(string[] fullnames)
        {
            string[] arr = new string[fullnames.Length];
            for (int i = 0; i < fullnames.Length; i++)
            {
                arr[i] = fullnames[i].Substring(0,fullnames[i].IndexOf(' '));

            }
            return arr;
        }
        // TASK 5
        static bool tapan(string str)
        {
            if (Char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(str[i]))
                {
                    return false;
                }
            }
            return false;
        }
        static bool Isfullname(string str)
        {
            var words = str.Split(' ');
            if (words.Length != 2)
            {
                return false;
            }
            if (!tapan(words[0]) || !tapan(words[1]))
            {
                return false;
            }
            return true;
        }


    }

}




