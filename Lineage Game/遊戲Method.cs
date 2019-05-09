using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lineage_Game;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(String[] args)
        {
            void Start()
            {
                角色 A = new 角色();
                A.角色名稱 = "基隆維尼熊";
                A.走路();
                A.喝體力藥水();
                A.打怪物();

                怪物 哥布林 = new 怪物();
                哥布林.怪物名稱 = "哥布林";
                哥布林.攻擊力 = 1;
                哥布林.經驗值 = 3;
                哥布林.挑釁();
            }

            switch (Console.ReadLine().ToString())
            {
                case "1":
                    var x = new 角色();
                    x.走路();
                    break;

                case "2":
                    var y = new 角色();
                    y.喝體力藥水();
                    break;

                case "3":
                    var z = new 角色();
                    z.打怪物();
                    break;
            }
        }
    }
}