using CourseStore.Core.Domain;
using CourseStore.Infra.Data.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CourseStore.Endpoints.CourseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TipsAndTricksRepository.CheckAddEntity();
            Console.WriteLine("Press any key ...");
            Console.Read();
        }
    }
}
