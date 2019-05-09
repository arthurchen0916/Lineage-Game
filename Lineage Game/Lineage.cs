using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage_Game
{
            public class 角色  //建立角色類別
          {
            //定義角色屬性
            public string 角色名稱;
            public int 角色等級 = 1;
            public int 角色體力 = 100;
            public int 角色生命 = 300;
            public int 角色經驗值 = 0;

            //定義方法1
            public void 走路()
            {
                Console.WriteLine(角色名稱 + "往前走了一格，並扣除體力1點！");
                角色體力 -= 1;
                Console.ReadKey();
            }

            //定義方法2
            public void 喝體力藥水()
            {
                Console.WriteLine(角色名稱 + "喝下紅色藥水，並回復體力3點！");
                角色體力 += 3;
                Console.ReadKey();
              }

            //定義方法3
            public void 打怪物()
            {
                Console.WriteLine(角色名稱 + "擊殺了眼前的，並消耗了2點體力、1點生命值，獲得了exp3點！");
                int 剩餘體力=角色體力 -= 2;
                int 剩餘生命=角色生命 -= 1;
                int 總經驗值=角色經驗值 += 3;
                Console.ReadKey();
              }
        }

        public class 怪物  //建立怪物類別
        {
            //定義怪物屬性
            public string 怪物名稱;
            public int 攻擊力, 經驗值;

            //定義怪物方法
            public void 挑釁()
            {
                Console.WriteLine("我是" + 怪物名稱 + "快來與我一決死戰吧！");
            }
        }
  }


