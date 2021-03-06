﻿using System;
using System.Collections.Generic;
using MyConfig;

namespace ConfigsTest
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfigManager.ResPath = @"C:\Users\123\Desktop\MyConfig";
            ConfigManager.Instance.DefaultConfigs = new List<Type>() { typeof(ErrorCodeConfig) };//默认的预加载配置文件集
            ConfigManager.Instance.Init(null,null);//确定是否异步加载，及逻辑下的委托执行，
            Console.WriteLine(ErrorCodeConfig.GetErrorById(2));
            //Console.WriteLine(SkillsCfg.GetSkillsName(1));

            foreach (var item in SkillsJsonCfg.Config.Skills)
            {
                Console.WriteLine("ID："+item.ID+"   "+"名称："+item.IntoGameName);
            }
            foreach (var item in SkillConstenfig.Config.Skills)
            {
                Console.WriteLine("Destail:：" + item.Destail + "   " + "SkillName：" + item.SkillName);
            }
            Console.ReadKey();
        }
    }
}
