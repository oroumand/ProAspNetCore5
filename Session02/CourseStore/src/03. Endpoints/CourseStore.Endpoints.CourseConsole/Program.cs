using CourseStore.Infra.Data.Sql;
using System;

namespace CourseStore.Endpoints.CourseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandRepository.CreateCourseWithDiscount("Microservice", "Microservice Desc", 2100,1600,"Nowrooz");
            Console.WriteLine("Press any key ...");
            Console.Read();
        }
    }
}
