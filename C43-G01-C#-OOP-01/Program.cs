﻿using Common;
using System.Threading.Channels;
namespace C43_G01_C__OOP_01
{
    //enum Gender
    //{
    //    male,female
    //}
    //enum Days{
    //    saturday=10,sunday,monday,tuesday,wendnesday,thrusday,friday
    //}

    ///[Flags]
    ///enum Permissions : byte
    ///{
    ///    Read = 1, Write = 2, Delete = 4, Excute = 8
    ///}

    ///class Employee
    ///{
    ///    public string name;
    ///    public int age;
    ///    public Permissions permission;
    ///}

    //enum WeekDays
    //{
    //    monday,tuesday,wednesday,thursday,friday,saturday,sunday
    //}

    ///enum Season
    ///{
    ///    Spring, Summer, Autumn, Winter
    ///}
    

    //enum Colors
    //{
    //    Red,Green,Blue
    //}

    internal class Program
    {
        //public static void DoSomeCode()
        //{
        //    int x, y, z;
        //    x=int.Parse(Console.ReadLine()); // Format Exception if u try to enter other format
        //    y=int.Parse(Console.ReadLine()); // Format Exception if u try to enter other format

        //    z = x / y;// Divided by zero exception if y = 0

        //    int[] numbers = { 1, 2, 3 };

        //    numbers[10] = 100;
        //}
        //public static void ProtectiveCode()
        //{
        //    int x, y, z;
        //    bool flag1, flag2;
        //    //Handling format exception
        //    do
        //    {
        //        Console.Write("Enter First Number: ");
        //        flag1 = int.TryParse(Console.ReadLine(), out x);
        //    }while (!flag1);

        //    //Handling format exception & divided by zero exception
        //    do
        //    {
        //        Console.Write("Enter second Number: ");
        //        flag2 = int.TryParse(Console.ReadLine(), out y);
        //    }while (!flag2 ||y==0);


        //    z = x / y;

        //    int[] numbers = { 1, 2, 3 };

        //    // handling index out of range & null reference exception
        //    if (numbers?.Length > 10)
        //    {
        //    numbers[10] = 100;
        //    }

        //}
        static void Main(string[] args)
        {
            #region Demo

            #region Exception Handling

            //try
            //{
            //    ProtectiveCode();
            //    throw new Exception();
            //}
            //catch(Exception ex)
            //{
            //    //open file to store error 
            //    //store into DB
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //colse - free - delete - dealocate unmanaged resources
            //    //like close DB
            //    Console.WriteLine("After Try and catch");
            //}

            #endregion

            #region Access Modifier
            //TypeA a =new TypeA();
            //a.x = 5; // error because it is private so it only be accessed inside it's class
            //a.y = 5; // error because it is internal so it only be accessed inside it's project
            //a.z = 5;
            #endregion

            #region Enum
            //Gender g = Gender.male;
            //if (g == Gender.male)
            //{
            //    Console.WriteLine(";)");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}

            //Days day = (Days)12;// it will check if value of lable == 12 if  found it return lable else return the number u entered
            //Console.WriteLine(day);
            //Days d = (Days)100; // couldn;t found value of a day=100
            //Console.WriteLine(d);

            ////take value from user
            //// first method
            //Gender G1 =(Gender) Enum.Parse(typeof(Gender), Console.ReadLine());
            //// it can cause Argument Exception if user entered any thing not in enum lables

            //// second method using TryParse
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), out object Result);
            //Gender G2 = (Gender)Result;
            //// it is very bad because we made alot of casting and if user enter Male to be print we must go to gender then add 
            //// Male and amke it's value equal to value of male and so on in cases like MAle,MaLe,...

            //// Third method using generics Tryparse
            //Enum.TryParse<Gender>(Console.ReadLine(), true, out Gender Result1);
            #endregion

            #region Permissions

            //Employee emp = new Employee();
            //emp.name = "Gamal";
            //emp.age = 23;
            //emp.permission = (Permissions)1;
            //Console.WriteLine(emp.permission);

            //// add new permission to eemployee by ( XOR ^ ) 
            //// XOR works as if employee not has this permission it will added it to him but if he already has this permission 
            //// it will remove this permission from him
            //emp.permission = emp.permission ^ Permissions.Read;
            //Console.WriteLine(emp.permission);

            //// Using ( and & ) to check if employee doesn't have this permission add it to hime if he already has this permission 
            //// don't do any thing
            //if ((emp.permission & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Permission already Exist");
            //}
            //else
            //{
            //    emp.permission = emp.permission ^ Permissions.Read;
            //}
            //Console.WriteLine(emp.permission);

            //// Using ( OR | ) it check if employee doesn't has this permission it will added this permission to hif
            //// if he has this permission it will do nothing
            //emp.permission = emp.permission | Permissions.Write;
            //Console.WriteLine(emp.permission);

            #endregion

            #region Struct

            //// it defined parameter less construcor and initiate variables with it's default value

            //Point p01 = new(); // call parameter less constructor
            //Console.WriteLine(p01.x);//0 

            //Point p02 = new Point(); // call parameter less constructor
            //Console.WriteLine(p02.x+" "+p02.y);//0 for x and 0 for y

            //Point p03 = new Point(5); // call parameterized constructor with one paramenter 
            ////== Point p03 = new(5);
            //Console.WriteLine(p03.x+" "+p03.y);//5 for x and 5 for y

            //Point p04 = new Point(5,7); // call parameterized constructor with two paramenter 
            ////== Point p03 = new(5);
            //Console.WriteLine(p04.x+" "+p04.y);//5 for x and 7 for y

            //Console.WriteLine(p01); //C43_G01_C__OOP_01.Point [namespace.struct name]
            //Console.WriteLine(p01.ToString()); //C43_G01_C__OOP_01.Point [namespace.struct name]

            //// we should change behaviour of ToString to print x,y
            //// after change ToString() behaviour 
            //Console.WriteLine(p01); //(0,0)
            //Console.WriteLine(p01.ToString()); //(0,0)

            #endregion


            #endregion

            #region Assignment

            #region Q1

            //// display all days 
            //for(int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}

            #endregion

            #region Q2

            //bool flag,flag2;
            //Season S;
            //do
            //{
            //    Console.Write("Enter Season Name: ");
            //    string seison = Console.ReadLine();
            //    flag = Enum.TryParse<Season>(seison, true, out S);
            //    flag2 = int.TryParse(seison, out int number);
            //} while (!flag||flag2);

            //if (S == Season.Spring)
            //{
            //    Console.Write($"Months in {S}: march , april , may");
            //}
            //else if (S == Season.Summer)
            //{
            //    Console.Write($"Months in {S}: june , july , august");
            //}
            //else if (S == Season.Autumn)
            //{
            //    Console.Write($"Months in {S}: september , october , november");
            //}
            //else if (S == Season.Winter)
            //{
            //    Console.Write($"Months in {S}: december , january , february");
            //}

            #endregion

            #region Q3

            //Permissions per=Permissions.Write;
            //Console.WriteLine($"permission now= {per}");
            ////check if permission has read or not if doesn't have read add it
            //if((per & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Existed permission");
            //}
            //else
            //{
            //    per = per ^ Permissions.Read;
            //}
            //Console.WriteLine($"permission now= {per}");

            ////check if permission has read or not if it have read remove it
            //if ((per & Permissions.Read) == Permissions.Read)
            //{
            //    per = per ^ Permissions.Read;
            //    Console.WriteLine("remove read permission");
            //}
            //else
            //{
            //    Console.WriteLine("didn't find this permission");
            //}
            //Console.WriteLine($"permission now= {per}");

            ////we can use OR | so if it not found permission it will add it else do nothing 
            //per = per | Permissions.Write;
            //Console.WriteLine($"permission now= {per}");
            //per = per | Permissions.Excute;
            //Console.WriteLine($"permission now= {per}");


            #endregion

            #region Q4

            //bool flag,flag2;
            //Console.Write("Enter Color Name: ");
            //string mycolor = Console.ReadLine();
            //flag =Enum.TryParse<Colors>(mycolor, true, out Colors color);
            //flag2 = int.TryParse(mycolor, out int number);
            //if (flag && !flag2)
            //{
            //    Console.WriteLine($"{color} is a primary color");
            //}
            //else
            //{
            //    Console.WriteLine("Not Primary Color");
            //}

            #endregion

            #region Q5

            //bool flag1, flag2;
            //Point p1;
            //do
            //{
            //    Console.Write("Enter x1: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out p1.x);
            //} while (!flag1);
            //do
            //{
            //    Console.Write("Enter y1: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out p1.y);
            //} while (!flag1);
            //Point p2;
            //do
            //{
            //    Console.Write("Enter x2: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out p2.x);
            //} while (!flag1);
            //do
            //{
            //    Console.Write("Enter y2: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out p2.y);
            //} while (!flag1);

            //double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            //Console.WriteLine($"Distance between {(p1.x,p1.y)} and {(p2.x,p2.y)} = {distance}");

            #endregion

            #endregion
        }
    }
}
