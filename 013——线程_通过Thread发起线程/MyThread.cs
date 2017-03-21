using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _013__线程_通过Thread发起线程
{
    class MyThread
    {
        private string fileName;
        private string dissce;

        public MyThread(string fileName,string dissce)
        {
            this.fileName = fileName;
            this.dissce = dissce;
        }
        public void Text()
        {
            Console.WriteLine ("开始下载" + fileName+dissce);
            Thread.Sleep(2000);
            Console.WriteLine("下载完成");
        }
    }
}
