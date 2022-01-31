using System;
 
namespace Demo
{
    class Age
    {
        static void Main(string[] args)
        {
        
        int n;
        Console.WriteLine("Enter the Age :");
        n = int.Parse(Console.ReadLine());  
        if(n>=18)
        {
            Console.WriteLine("Age is greater than 18");
        }
        else{
            Console.WriteLine("Age is less than 18");
        }
        }
    }
}
