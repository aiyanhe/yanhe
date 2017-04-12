using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyConfig
{
    public  class ConfigManager
    {
        private static ConfigManager _instance;
        static ConfigManager()//静态构造函数，不懂的话可以去“中级视频/构造函数”那边看下
        {
            _instance = new ConfigManager();
        }

        protected ConfigManager()//构造函数
        {
        }
        public  static ConfigManager Instance
        {
            get
            {
                return _instance;
            }
        }

        //是否开启异步加载
        public static bool IsPreLoad = false;
        //默认的预加载配置文件
        public List<Type> DefaultConfigs;
        //异步加载配置文件
        public List<Type> AsnycConfigs;
        //配置文件的资源路径 例如：F:\9期服务器\策划\Config
        public static string ResPath;
        //异步加载进度
        protected Action<int, int> progress;
        //加载完成的回调
        protected Action Finished;

        public void Init(Action<int, int> progress = null, Action Finished = null)
        {
            LoadConfigs(DefaultConfigs, progress);

            if (IsPreLoad)//如果开启异步加载
            {
                LoadConfigs(AsnycConfigs, progress, Finished);//就加载异步加载配置文件
            }
            else
            {
                if (Finished != null)
                {
                    Finished();
                }
            }

        }
        /// 加载一组配置文件
        public void LoadConfigs(List<Type> configs, Action<int, int> progress = null, Action Finished = null)
        {
            if (configs == null || configs.Count == 0)//当加载文件无内容或文件不存在时，return;
            {
                if (Finished != null)
                {
                    Finished();//有委托就执行委托
                }
                return;
            }
            int count = configs.Count;
            int index = 1;

            foreach (var item in configs)//逐个抽出预加载文件
            {
                LoadConfig(item);
                if (progress!=null)
                {
                    progress(index,count);
                }
                index++;
            }
            if (Finished!=null)
            {
                Finished();
            }
        }
        //加载一个配置文件
        private void LoadConfig(Type item)//参数为Type 表示传进什么参数类型，item就是什么类型
        {

            var c = item.GetProperty("Config", ~BindingFlags.DeclaredOnly);//item.GetProperty（）使用指定的绑定约束搜索指定属性。
                                                                           //因为有个"~"反的意思，所以仅搜索父类(仅让其搜索同一级别的属性)     //BindingFlags.DeclaredOnly，指定只应考虑在所提供类型的层次结构级别上声明的成员。不考虑继承成员。

            if (c!=null)
            {
                //将预加载文件序列化和反序列化为一个对象；
                c.GetGetMethod().Invoke(null,null);// GetGetMethod()：返回一个MethodInfo对象,表示此属性的公共 get 访问器，
                                                   //Invoke():返回一个对象，包含被调用方法的返回值，如果调用的是构造函数，则为 null。
                                                   //这里的话就是执行 public static T Config {get {if (config == null) { config = GetConfig<T>(); } return config; }}
            }
        }

        /// 暴露出去调用反序列化的方法
        public T FormatConfig<T>(string fileName,AbsConfig.E_ConfigType type)where T:AbsConfig,new()
        {

            switch (type)
            {
                case AbsConfig.E_ConfigType.XML:
                    return FormatXMLConfig<T>(fileName);
                    break;
                case AbsConfig.E_ConfigType.Json:
                    return FormatJsonConfig<T>(fileName);
                    break;
                case AbsConfig.E_ConfigType.Consten:
                    return FormatConstenConfig<T>(fileName);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("type",type,null);
                    break;
            }
        }



        private T FormatXMLConfig<T>(string fileName)where T:AbsConfig
        { 
        
            //调用xml序列化
            return XMLHelper.FormatConfig<T>(GetPath(fileName));
        }
        private T FormatJsonConfig<T>(string fileName) where T : AbsConfig, new()
        {
            return JsonHelp.FormatConfig<T>(GetPath(fileName));
        }
        private T FormatConstenConfig<T>(string fileName) where T : AbsConfig, new()
        {
            return ConstenHelp.FormatConfig<T>(GetPath(fileName));
        }

       
        protected string GetPath(string fileName)
        {

            return ResPath + fileName;// 前半部路径+相对路径+文件名+扩展名 拼接成绝对路径+文件全称
        }

    }
}
