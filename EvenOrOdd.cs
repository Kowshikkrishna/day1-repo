using System;
 
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int n;
        Console.WriteLine("Enter the Number :");
        n = int.Parse(Console.ReadLine());  
        if(n>=18)
        {
            Console.WriteLine("{0} number is Even");
        }
        else{
            Console.WriteLine("{0} number is Odd",n);
        }
        }
    }
}
