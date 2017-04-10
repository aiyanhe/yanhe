using System;
using System.Collections.Generic;
using MyConfig;

namespace ConfigsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigManager.ResPath = @"C:\Users\爱言和\Desktop\MyConfig";
            ConfigManager.Instance.DefaultConfigs = new List<Type>() { typeof(ErrorCodeConfig) };
            ConfigManager.Instance.Init(null,null);
            Console.WriteLine(ErrorCodeConfig.GetErrorById(1));
            Console.ReadKey();
        }
    }
}
