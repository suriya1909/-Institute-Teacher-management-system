using Repository_project.DI;
using Repository_project.Institute;
using Repository_project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestAll test=new TestAll();
            test.OnlyDisplay();
            Console.ReadKey();
        }

        
    }
}
