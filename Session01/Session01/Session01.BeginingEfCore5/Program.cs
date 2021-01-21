using Session01.BeginingEfCore5.DataAccess;
using Session01.BeginingEfCore5.Models;
using System;
using System.Collections.Generic;

namespace Session01.BeginingEfCore5
{
    public 
    class Program
    {
        static void Main(string[] args)
        {
            //DataClass.ReadAllCourse();
            //DataClass.WriteCourse();
            DataClass.Update(1, "ASP.NET Core 5 And EF");
            Console.WriteLine("Press any Key ...");
            Console.Read();
        }
    }
}
