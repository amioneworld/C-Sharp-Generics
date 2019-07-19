using System;
using static System.Console;

namespace AutoFac_Container
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("AutoFac IoC Container Usage Snippet");
            WriteLine("--------------------------------");

            // NOTE: You must use AutoFacConfig.RegisterContainer(); 
            // in your Global.asax in ASP.NET MVC project 
            // or Startup.cs in ASP.NET Core project.

            AutoFacConfig.RegisterContainer();





        }
    }
}

 