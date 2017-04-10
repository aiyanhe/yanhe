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

            if (IsPreLoad)
            {
                LoadConfigs(AsnycConfigs, progress, Finished);
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
            if (configs == null || configs.Count == 0)
            {
                if (Finished != null)
                {
                    Finished();
                }
                return;
            }
            int count = configs.Count;
            int index = 1;

            foreach (var item in configs)
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
        private void LoadConfig(Type item)
        {

            var c = item.GetProperty("",~BindingFlags.DeclaredOnly);

            if (c!=null)
            {
                c.GetGetMethod().Invoke(null,null);
            }
        }

        /// 暴露出去调用反序列化的方法*
        public T FormatConfig<T>(string fileName,AbsConfig.E_ConfigType type)where T:AbsConfig,new()
        {

            switch (type)
            {
                case AbsConfig.E_ConfigType.XML:
                    return FormatXMLConfig<T>(fileName);
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
        protected string GetPath(string fileName)
        {

            return ResPath + fileName;
        }

    }
}
