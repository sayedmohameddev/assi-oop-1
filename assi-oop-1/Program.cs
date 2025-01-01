using System;

namespace assi_oop_1
{
    #region 
    //enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}
    #endregion
    #region
    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}
    #endregion
    #region
    //enum Permissions
    //{
    //    None = 0,      
    //    Read = 1,    
    //    Write = 2,     
    //    Delete = 4,   
    //    Execute = 8    
    //}
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region q-01
            //Console.WriteLine("Days of the Week:");

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region q-02

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Season selectedSeason))
            //{
            //    switch (selectedSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}

            #endregion

            #region q-03
            //Permissions userPermissions = Permissions.None;

            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;
            //Console.WriteLine($"Current Permissions: {userPermissions}");

            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Permissions after removing Write: {userPermissions}");

            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read permission is granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Read permission is not granted.");
            //}

            //if ((userPermissions & Permissions.Execute) == Permissions.Execute)
            //{
            //    Console.WriteLine("Execute permission is granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Execute permission is not granted.");
            //}
            #endregion
        }
    }
}
