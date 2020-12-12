using System;

namespace GradeBook
{
    class Program
    {
        //this is a method named main
        static void Main(string[] args) //params can have 0 or more, every param consists of a type and name (type: string array, name: args)
        {

            // var numbers = new double[3];
            // //populating array
            // numbers[0] = 12.7;
            // numbers[1] = 10.3;
            // numbers[2] = 8;

            var numbers = new [] {1, 2, 3, 4, 5}; //here we are defining the array, we don't need to tell the computer how many are in there, they're already there
            List grades;

            var result = numbers[0];
            result = result + numbers[1];
            //this does the same thing
            result += numbers[1];
            // Console.WriteLine(result);

            //here's the same thing but with a foreach
            var res = 0;
            foreach(var number in numbers)
            {
                res += number;
            }
            Console.WriteLine(res);

            if (args.Length > 0) //this makes our program good - handles bad user input
            { 
                Console.WriteLine($"Wassup {args[0]}!"); //use the $ to make this an interpolation
                //this method is called when the program is run, there's a method named main for the entrypoint of the app
            }
            else 
            {
                Console.WriteLine("Hi");
            }           
        }
    }
}
