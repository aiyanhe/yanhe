using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyServer.Common.Tools
{
    public delegate void ExecutorDelegate();
    /// <summary>
    /// 一个单例委托工具,往工具的委托加方法，通过工具的方法执行委托
    /// </summary>
    class ExecutorManager
    {
        private static ExecutorManager instance;

        static ExecutorManager()//懒惰的单例模式
        {
            instance = new ExecutorManager();

        }
        /// <summary>
        /// 互斥锁，每个对象都对应于一个可称为" 互斥锁" 的标记，这个标记用来保证在任一时刻，只能有一个线程访问该对象。
        /// </summary>
        private Mutex mutex= new Mutex();
        /// <summary>
        /// 通过mutex和lock两把锁确保同一时间只有一个线程执行委托;
        /// </summary>
        /// <param name="func"></param>
        private void ExecuteEx(ExecutorDelegate func)
        {
            lock (this)
            {
                mutex.WaitOne();//锁了
                func();
                mutex.ReleaseMutex();//解锁
            }
        }
        /// <summary>
        /// 仅仅是为了静态类可以直接点到ExecuteEx方法
        /// </summary>
        /// <param name="func"></param>
        public static void Execute(ExecutorDelegate func)
        {
            instance.ExecuteEx(func);
        }
    }
}
