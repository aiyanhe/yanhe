using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_异常处理
{
  public   class Program
    {
        static void Main(string[] args)
        {
            try//找出异常；
            {
                //throw new InsufficientMemoryException();
                int[] array = { 10, 521, 21, 21, 5215, 2432, 165, 465, 4 };
                Console.WriteLine(array[10]);//这里的错误是IndexOutOfRangeException，索引超出了数组界限;

            }
            catch (IndexOutOfRangeException e)//当错误类型为IndexOutOfRangeException时，执行这个catch语句块；
            {                                 //把IndexOutOfRangeException命名为e;

                Console.WriteLine("有异常错误1");
                //throw new Exception(e.Message);

                //你catch就是其他代码throw的异常。你什么都不做又抛一遍当然就交给系统了，程序就挂了呗。
                //自己只throw不处理的情况，一般只在当你也搞不清异常是如何产生的，会不会产生，
                //并且异常出现时不进行处理会导致比程序挂了更惨的事发生（比如数据一致性错误）的情况下，直接抛出，让程序完蛋了事。

                //会让程序中断；
                //throw的作用是当代码执行到此处时人为的让程序出错，出错原因是你指定的内容
                //重新抛出异常: 从上面的处理机制可以看到,只有一个catch可能被执行, 如果一个catch被执行,其他后续的catch就会被跳过了. 
                //有时候一个catch中可能无法完成异常的全部处理,需要将 异常提交给更高的层,以期望得到处理.重新抛出异常实现 了这种可能性. 
                //语法: throw ; 空的throw语句,只能在catch中使用.   
                //它重新抛出异常对象,其外层的catch可能可以捕捉这个重新抛出的异常并做适当处理.
            }
            //catch (Exception)
            //{


            //    Console.WriteLine("有异常错误2");

            //}
            catch //有其它类型错误时，执行这个catch语句块；
            {


                Console.WriteLine("有异常错误");
               

            }
            finally//finally可以没有，也可以只有一个。无论有没有发生异常，它总会在这个异常处理结构的最后运行。
                   //即使你在try块内用return返回了，在返回前，finally总是要执行，这以便让你有机会能够在异常处理最后做一些清理工作。如关闭数据库连接等等。
                   //注意：如果没有catch语句块，那么finally块就是必须的。
            {

                Console.ReadKey();


            }
        }
    }
}
