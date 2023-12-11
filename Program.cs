using System.Collections;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {   
        
    Console.WriteLine("enter a number from keyboard");
    int count = int.Parse(Console.ReadLine());
    Console.WriteLine(count);
    if(count<9){
        Console.Write("lower than 10");
        switch(count)
        {
            case 0: Console.WriteLine("zero");
            break;
            case 1: Console.WriteLine("one");
            break;
            case 2: Console.WriteLine("two");
            break;
            case 3: Console.WriteLine("three");
            break;
            case 4: Console.WriteLine("four");
            break;
            case 5: Console.WriteLine("five");
            break;
            case 6: Console.WriteLine("six");
            break;
            case 7: Console.WriteLine("seven");
            break;
            case 8: Console.WriteLine("eight");
            break;
            case 9: Console.WriteLine("nine");
            break;
            
        }
    }
    else if(count<20){
        int chuc = (int) count/10;
        int dv = (int) count%10;
        Console.Write("ten ");
        switch (dv){
            case 1: Console.WriteLine("one");
            break;
            case 2: Console.WriteLine("two");
            break;
            case 3: Console.WriteLine("three");
            break;
            case 4: Console.WriteLine("four");
            break;
            case 5: Console.WriteLine("five");
            break;
            case 6: Console.WriteLine("six");
            break;
            case 7: Console.WriteLine("seven");
            break;
            case 8: Console.WriteLine("eight");
            break;
            case 9: Console.WriteLine("nine");
            break; 
        }
    }
    else if(count<99){
        int chuc = (int) count/10;
        int dv = (int) count%10;
        switch(chuc){
            case 2: Console.WriteLine("two");
            break;
            case 3: Console.WriteLine("three");
            break;
            case 4: Console.WriteLine("four");
            break;
            case 5: Console.WriteLine("five");
            break;
            case 6: Console.WriteLine("six");
            break;
            case 7: Console.WriteLine("seven");
            break;
            case 8: Console.WriteLine("eight");
            break;
            case 9: Console.WriteLine("nine");
            break; 
        }
        Console.Write("ten ");
        switch (dv){
            case 1: Console.WriteLine("one");
            break;
            case 2: Console.WriteLine("two");
            break;
            case 3: Console.WriteLine("three");
            break;
            case 4: Console.WriteLine("four");
            break;
            case 5: Console.WriteLine("five");
            break;
            case 6: Console.WriteLine("six");
            break;
            case 7: Console.WriteLine("seven");
            break;
            case 8: Console.WriteLine("eight");
            break;
            case 9: Console.WriteLine("nine");
            break; 
    
    }   
        
    }
    }

}


            
            
            



             

    
