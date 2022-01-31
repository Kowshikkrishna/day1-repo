using System;
 
namespace Demo
{
    class LeapYear
    {
        static void Main(string[] args)
        {
        
        int a,b,c;
        Console.WriteLine("Enter three numbers :");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c  = int.Parse(Console.ReadLine());  
        if(b>a)
        {
            if(b>c)
            {
                Console.WriteLine("{0} is greater than {1},{2}",b,a,c);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1},{2}",c,a,b);
            }
        
        }
        else
        {
            if(a>c)
            {
                Console.WriteLine("{0} is greater than {1},{2}",a,b,c);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1},{2}",c,a,b);
            }
        }
        
        }
        }
    }