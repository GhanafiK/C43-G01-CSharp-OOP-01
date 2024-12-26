using Common;
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
    ///enum Permissions:byte
    ///{
    ///    Delete=1,Excute=2,Read=4,Write=8
    ///}
    
    ///class Employee
    ///{
    ///    public string name;
    ///    public int age;
    ///    public Permissions permission;
    ///}
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


            #endregion
        }
    }
}
