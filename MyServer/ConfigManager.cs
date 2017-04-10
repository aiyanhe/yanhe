using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer
{
    class ConfigManager
    {
        private static ConfigManager _instance;
        static ConfigManager()//静态构造函数，不懂的话可以去“中级视频/构造函数”那边看下
        {
            _instance = new ConfigManager();
        }

        protected ConfigManager()//构造函数
        {
        }
        internal static ConfigManager Instance
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

        public void Init(Action<int , int >progress = null,Action Finished = null)
        {
            LoadConfigs();

        }

    }
}
