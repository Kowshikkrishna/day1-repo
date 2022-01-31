using System;
 
namespace Demo
{
    class LeapYear
    {
        static void Main(string[] args)
        {
        
        int n;
        Console.WriteLine("Enter the Year :");
        n = int.Parse(Console.ReadLine());  
        if( (n % 400 == 0) || ((n % 4 == 0) && (n % 100 != 0)) )
        {
            Console.WriteLine("Leap year");
        }
        else{
            Console.WriteLine("Not a leap year");
        }
        }
    }
}