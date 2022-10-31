using System;
class main
{
    static void Main()
    {
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //int dif = a - b;
        //sum = a + b;
        //Console.WriteLine(sum);
        //Console.WriteLine(dif);

        //byte
        //byte b1 = 0xF7;
        //byte b2 = 0xAB;
        //byte temp;
        //temp = (byte)(b1 & b2);
        //Console.Write(temp + " ");
        //temp = (byte)(b1 ^ b2);
        //Console.WriteLine(temp);

        //ternary
        //int num;
        //Console.WriteLine("the value of num is: {0}",num);
        //bool isnum = num == 25 ? true : false;
        //Console.WriteLine("Num==25 is {0}", isnum);
        //string Name = "Ayush\\Kishor\\PascalCase";
        //Console.WriteLine(Name);`

        //swapping of 2nos
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int temp;
        //temp = a;
        //a = b;
        //b = temp;
        //Console.WriteLine("THE VALUES OF a & b are: {0},{1}", a, b);

        //FIBONACCI
        //int a = 0;
        //int b = 1;
        //int n = Convert.ToInt32(Console.ReadLine());
        //int fib = 0;
        //Console.WriteLine("{0},{1}", a, b);
        //for(int i = 0; i <= n; i++)
        //{
        //    fib = a + b;
        //    a = b;
        //    b = fib;

        //    Console.WriteLine(fib);
        //}

        //loops
        //int age = Convert.ToInt32(Console.ReadLine());
        //int n= Convert.ToInt32(Console.ReadLine());
        //for(int i = 0; i <= n; i++)
        //{
        //    if (age > n)
        //    {
        //        Console.WriteLine("{0}",
        //        "You look older than you are !");
        //    }
        //}

        //pattern[square]
        //int n = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        Console.Write("@");
        //    }
        //    Console.WriteLine(" ");
        //}

        //factorial
        //int n = Convert.ToInt32(Console.ReadLine());
        //int fact = 1;
        //for (int i = 1; i <= n; i++)
        //{
        //    fact = fact * i;
        //    //Console.WriteLine("THE VALUE OF FACT IS:{0}",fact);

        //}
        //Console.WriteLine("THE VALUE OF FACT IS:{0}", fact);

        //PATTERN1
        //int n = Convert.ToInt32(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = i; j <= n; j++)
        //    {
        //        Console.Write("@");
        //    }
        //    Console.WriteLine(" ");
        //}

        //pattern2
        //int n = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i <= n; i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write("@");
        //    }
        //    Console.WriteLine(" ");
        //}

        //intialisation of array !
        //int[] arr = new int[10];
        //int n = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i <= n; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        //for (int i = 0; i <= n; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}
    }
}


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//nullables
using System;
class Program1
{
    static void Main()
    {
        //int? ticketsonsale = null;
        //int? ticketsonsale = Convert.ToInt32(Console.ReadLine());
        //int AvailableTickets;
        //if (ticketsonsale == null)
        //{

        //    AvailableTickets = 0;
        //}
        //else
        //{
        //    AvailableTickets = ticketsonsale ?? 3;
        //}
        //Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

        //int? a = null;
        //int? b = 1234;
        //Console.WriteLine(a);
        //Console.WriteLine(b);

        //Datatype conversion

        //float f = 12.2F;
        //int i = (int)f;
        //Console.WriteLine(i);

        //String num = "2529";
        //int i = int.Parse(num);
        //Console.WriteLine(num);

        //String num1 = "100G";
        //int j = 0;
        //int.TryParse(num1, out j);
        //Console.WriteLine(j);

        //String num1 = Console.ReadLine();
        //int j = 0;
        //bool IsConvSuccs = int.TryParse(num1, out j);
        //if (IsConvSuccs)
        //{
        //    Console.WriteLine(j);

        //}
        //else
        //{
        //    Console.WriteLine("Enter a Valid Number");
        //}

        //ARRAY INTIALIZATION
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] PRU = new int[n];
        ////int i = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i <= n; i++)
        //{
        //    PRU[i] = Convert.ToInt32(Console.ReadLine());

        //}
        //for (int i = 0; i < PRU.Length; i++)
        //{
        //    Console.WriteLine(PRU[i].ToString());
        //}

   }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using System;
//class Pgm
//{
//    static void Main()
//    {
//        int Age = Convert.ToInt32(Console.ReadLine());
//        if (Age >= 18)
//        {
//            Console.WriteLine("You are eligible for voting");
//        }
//        else
//        {
//            Console.WriteLine("You are not eligible for voting");
//        }
//    }
//}





//SWITCH
//Console.WriteLine("Enter Your Number");
//int UserNo = Convert.ToInt32(Console.ReadLine());
//switch (UserNo)
//{
//    case 1:
//        Console.WriteLine("You are bad");
//        break;

//    case 2:
//        Console.WriteLine("You are avg");
//        break;

//    case 3:
//        Console.WriteLine("You are good");
//        break;

//    default:
//        Console.WriteLine("i doonoo");
//        break;
//}

//Console.WriteLine("Enter Your Number");
//int UserNo = Convert.ToInt32(Console.ReadLine());
//switch (UserNo)
//{
//    case 1:
//    case 15:
//    case 3:
//        Console.WriteLine("Your number is {0}", UserNo);
//        break;
//    default:
//        Console.WriteLine("YOUR NUM IS NOT MENTIONED");
//        break;
//}

//Console.WriteLine("Enter your Age");
//int AGE = Convert.ToInt32(Console.ReadLine());
//switch (AGE)
//{
//    case 18:
//        Console.WriteLine("YOU ARE ELIGIBLE FOR VOTING");
//        break;

//    case 17:
//        Console.WriteLine("YOUR ARE NOT ELIGIBLE");
//        break;

//    default:
//        Console.WriteLine("NOT SURE ABOUT IT!");
//        break;
//}

//Console.WriteLine("Enter you age:");
//int Age = Convert.ToInt32(Console.ReadLine());
//switch (Age)
//{
//    case 18:
//        Console.WriteLine("YOU ARE ELIGIBLE");
//        break;

//    case 17:
//        Console.WriteLine("YOU ARE NOT ELIGIBLE");
//        break;

//    default:
//        Console.WriteLine("Specify your age properly!!");
//        break;
//}


//produce a bill amount using switch

//int CoffeeCost = 0;

//Console.WriteLine("1-small, 2-medium, 3-large");

//int CustomerChoice = Convert.ToInt32(Console.ReadLine());

//switch (CustomerChoice)
//{
//    case 1:
//        CoffeeCost += 1;
//        Console.WriteLine("Your coffee price is: {0}", CoffeeCost);
//        break;

//    case 2:
//        CoffeeCost += 3;
//        Console.WriteLine("Your coffee price is: {0}",CoffeeCost);
//        break;

//    case 3:
//        CoffeeCost += 4;
//        Console.WriteLine("Your coffee price is: {0}", CoffeeCost);
//        break;

//    default:
//        Console.WriteLine("Coffee isnt ready!");
//        Console.WriteLine(CoffeeCost);
//        break;
//}



//Start:
//int CoffeeCost = 0;
//int TotalCost = 0;
//TotalCost = TotalCost + CoffeeCost;

//Console.WriteLine("Please select your coffe size: 1-small, 2-medium, 3-large, 4-want more");

//int CustomerChoice = Convert.ToInt32(Console.ReadLine());

//switch (CustomerChoice)
//{
//    case 1:
//        CoffeeCost += 1;
//TotalCost = CoffeeCost + TotalCost;
//Console.WriteLine("Your coffee price is: {1}", CoffeeCost);
//break;

//case 2:
//    CoffeeCost += 3;
//TotalCost = CoffeeCost + TotalCost;
//Console.WriteLine("Your coffee price is: {2}", CoffeeCost);
//break;

//case 3:
//    CoffeeCost += 4;
//TotalCost = CoffeeCost + TotalCost;
//Console.WriteLine("Your coffee price is: {3}", CoffeeCost);
//break;

//case 4:
//    goto Start;


//default:
//    Console.WriteLine("Coffee isnt ready!");
//    Console.WriteLine(CoffeeCost);
//    goto Start;

//Console.WriteLine("THE TOTAL BILL AMOUNT IS: {0}", CoffeeCost);
//}

//Console.WriteLine("Do you like to bouy another COFFEE:: YES OR NO ");
//String UserChoice = Console.ReadLine();
//switch (UserChoice.ToUpper())
//{
//    case "YES":
//        TotalCost = CoffeeCost;
//        goto Start;

//    case "NO":
//        break;

//}
//Console.WriteLine("THANKS FOR PURCHASING");
//Console.WriteLine("THE TOTAL BILL AMOUNT IS: {0}", CoffeeCost);


//print the even values using the target variable
//Console.WriteLine("Enter your target variable:");
//int Target = int.Parse(Console.ReadLine());
//int Start = 0;
//Console.WriteLine(Start);
//while(Start <= Target)
//{
//    Start = Start + 2;
//    Console.WriteLine(Start);
//}


//print the odd values using the target variable
//Console.WriteLine("Enter your target variable:");
//int Target = int.Parse(Console.ReadLine());
//int Start = 1;
//String UserChoice;

//while (Start < Target)
//{
//    Start = Start + 2;
//    Console.Write(Start + " ");
//}

//FOR AND FOR-EACH LOOPS

//sum of n numbers ?

//Console.WriteLine("enter the numbers you want to sum");
//int n = int.Parse(Console.ReadLine());
//int sum = 0;
//for(int i = 0; i <= n; i++)
//{
//    sum = sum + i;
//    Console.Write(sum);
//}

//for-each
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("enter the array elements:");
//int[] pascal = new int[n];

//pascal[0] = 25;
//pascal[1] = 28;
//pascal[2] = 29;
//pascal[3] = 31;
////pascal[4] = 21;

//foreach(int i in pascal)
//{
//    Console.WriteLine(i);
//}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using 1 instance ad 1 static methods
//using System;
//class pgm1
//{
//    public static void Main()
//    {
//        Console.WriteLine("this is all about methods.");
//        pgm1 p = new pgm1();
//        p.EvenNum();
//    }

//    public void EvenNum()
//    {
//        int strt = 0;
//        int n = int.Parse(Console.ReadLine());
//        for(int i = 0; i <= n; i++)
//        {
//            Console.WriteLine(strt);
//            strt = strt + 2;

//        }
//    }
//}

//using 2 static methods in the same program
//using System;
//class demo
//{
//    public static void Main()
//    {
//        Console.WriteLine("this is all about methods.");
//        demo.EvenNum();
//    }

//    public static void EvenNum()
//    {
//        int strt = 0;
//        int n = int.Parse(Console.ReadLine());
//        for (int i = 0; i <= n; i++)
//        {
//            Console.WriteLine(strt);
//            strt = strt + 2;

//        }
//    }
//}

//USING METHIDS BY PASSING THE PARAMETERS
//using System;
//class demo
//{
//    public static void Main()
//    {
//        Console.WriteLine("this is all about methods.");
//        demo.EvenNum(20);
//    }

//    public static void EvenNum(int n)
//    {
//        int strt = 0;
//        for (int i = 0; i <= n; i++)
//        {
//            Console.WriteLine(strt);
//            strt = strt + 2;

//        }
//    }
//}

//sum of 2no's using methods and parameters
//using System;
//class demo
//{
//    public static void Main()
//    {
//        demo d = new demo();
//        int sum = d.Add(3, 5);
//        Console.WriteLine(sum);
//    }

//    public int Add(int a, int b)
//    {
//        return a + b;
//    }
//}

//pass by value
//using System;
//class Coffeee
//{
//    public static void Main()
//    {
//        int i = 0;
//        Demo1(i);
//        Console.WriteLine(i);
//    }
//    public static void Demo1(int j)
//    {
//        j = 2529;
//    }
//}

//pass by reference
//using System;
//class Coffeee
//{
//    public static void Main()
//    {
//        int i = 0;
//        Pascal(ref i);
//        Console.WriteLine(i);
//    }
//    public static void Pascal(ref int j)
//    {
//        j = 2529;
//    }
//}

//out parameter
//using System;
//class DEMO
//{
//    public static void Main()
//    {
//        int sum = 0;
//        int product = 0;
//        greeshma(2, 10, out sum, out product);
//        Console.WriteLine(sum);
//        Console.WriteLine(product);

//    }

//    public static void greeshma(int a, int b, out int sum, out int product)
//    {
//        sum = a + b;
//        product = a * b;
//    }
//}

//parameters array












































