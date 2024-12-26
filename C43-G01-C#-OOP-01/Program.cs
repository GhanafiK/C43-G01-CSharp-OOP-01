using Common;
namespace C43_G01_C__OOP_01
{
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



            #endregion
        }
    }
}
