using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(String[] args)
        {
            switch (Console.ReadLine().ToString())
            {
                case "1":
                    var x = new Lineage();
                    x.走路();
                    break;

                case "2":
                    var y = new 角色();
                    y.喝體力藥水();
                    break;

                case "3":
                    var z = new Lineage();
                    z.打怪物();
                    break;
            }
        }
    }
}