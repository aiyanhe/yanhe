using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfig
{
    public class AbsConfig
    {
        public enum E_ConfigType//配置表的类型
        {
            None,
            XML,
            Json,
            Consten
        }

        public class ConfigData
        {
            //配置表的文件名,解决类名和配置表名的不同情况
            public string Name;
            //配置表的相对路径
            public string Path;
            //配置表的扩展名
            public string Extension;
            //默认配置表的类型
            public E_ConfigType ConfigType = E_ConfigType.None;

            public string GetPath<T>()
            {
                var type = typeof(T);//typeof(T);返回一个T类型
                if (string.IsNullOrEmpty(Name))//string.IsNullOrEmpty（value）如果 value 参数为 null 或空字符串 ("")，则为 true；否则为 false。
                                               //当Name为空时，赋值于它
                {
                    Name = type.Name;//默认为类名为Xml的名称
                }
                return Path + Name + Extension;//路径+文件名+扩展名
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        //当不想序列化一个属性时，使用[System.Xml.Serialization.XmlIgnore]标记，能用于属性;
        //[NonSerializable] 应用于属性无效，能用于类，结构体等
        public ConfigData Data = new ConfigData();

        private string GetFileName<T>()//获取路径+文件名+扩展名
        {
            return Data.GetPath<T>();
        }

        protected virtual void Init()//默认相对路径和扩展名赋值
        {
            Data.Path = "/Xml/";
            Data.Extension = ".xml";
        }

        public AbsConfig()//构造函数
        {
            Init();
        }
        protected static T GetConfig<T>() where T : AbsConfig,new()
        //where T：new()指明了创建T的实例时应该具有构造函数。正常时是不能创建实例的
        {
            T config = new T();//new()的作用；
            Stopwatch sw = new Stopwatch();//提供一组方法和属性，可用于准确地测量运行时间。
            sw.Start();
            //加载配置文件，进行反序列化变成对象

            config = ConfigManager.Instance.FormatConfig<T>(config.GetFileName<T>(), config.Data.ConfigType);
            sw.Stop();
            float loadTime = sw.ElapsedMilliseconds;
            Console.WriteLine("加载文件：{0}，消耗了{1}毫秒时间",typeof(T).Name,loadTime);
            return config;
        }
    }

    public abstract class AbsConfig<T> : AbsConfig where T : AbsConfig, new()  //注意：AbsConfig<T> 继承于AbsConfig
     //abstract修饰类，会使这个类成为一个抽象类，这个类将不能生成对象实例，但可以做为对象变量声明的类型，也就是编译时类型，抽象类就像当于一类的半成品，需要子类继承并覆盖其中的抽象方法。

    {

        private static T config;
        public static T Config//属性
        {
            get 
            {
                if (config==null)
                {
                    config = GetConfig<T>();
                }
                return config;
            }
        }
    }

    public abstract class XmlConfig<T> : AbsConfig<T> where T : AbsConfig, new()//注意：XmlConfig<T> 继承于AbsConfig<T>
    {
        protected override void  Init()
        {
            base.Init();
            Data.ConfigType = E_ConfigType.XML;
        }
    
    }

    public abstract class jsonConfig<T> : AbsConfig<T> where T : AbsConfig, new()//注意：jsonConfig<T> 继承于AbsConfig<T>
    {
        protected override void Init()
        {
            base.Init();
            Data.ConfigType = E_ConfigType.Json;
        }

    }

    public abstract class Constenfig<T> : AbsConfig<T> where T : AbsConfig, new()//注意：jsonConfig<T> 继承于AbsConfig<T>
    {
        protected override void Init()
        {
            base.Init();
            Data.ConfigType = E_ConfigType.Consten;
        }

    }
}
