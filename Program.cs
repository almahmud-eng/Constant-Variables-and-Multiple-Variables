using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantandMultipleVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            String bachelorUniversityName = "AIUB"; //Variable Declaration & Initialaisation
            Console.WriteLine(bachelorUniversityName);

            bachelorUniversityName = "MIT"; //Change value after initialisation

            Console.WriteLine(bachelorUniversityName);

            //In constant variables we cant change value after initialisation Note that we have to declare and initialaisation at a same time for constant variables

            
                  const String yourName = "Mahmud"; //use of constant variable
            Console.WriteLine(yourName);
            //yourName = "Apon";
            //Console.WriteLine(yourName);      //Cant change name after using const keyword    

            // MultipleVariables


            int num1,num2, num3;
            num1 = num2 = num3 = 10;
            //we can also write as int num1= 10, num2 =10; num3= 10; (also works)
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.ReadLine();
        }
    }
}
