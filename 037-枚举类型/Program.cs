using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_枚举类型
{
    //GameState是个类名！！！
    enum GameState : byte//修改该枚举类型的存储类型，默认为int.
    { 
        Pause = 100,//默认代表的是整数0
        Failed = 101,//默认代表的是整数1
        Success = 102,//默认代表的是整数2
        Start = 200//默认代表的是整数3
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //利用定义好的枚举类型去声明变量
            GameState d = GameState.Start;
            if (d==GameState.Start)//枚举类型比较
            {
                Console.WriteLine("当前处于游戏开始状态");
            }
            Console.WriteLine(d);
            int num = (int)d;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
