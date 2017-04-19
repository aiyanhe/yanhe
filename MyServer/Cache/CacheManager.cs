using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer.Cache
{
    /// <summary>
    /// cache的管理器,当有多个处理不同逻辑的cache的时候，每个都要new一个对象，会造成程序臃於，所以有了这个管理器来同一管理，需要用特定的cache的时候直接通过这个管理器找；
    /// </summary>
    public  class CacheManager
    {
        /// <summary>
        /// 字典，存储所有的声明的cache，key为cache类型Type,值为cache的声明对象
        /// </summary>
        private readonly static Dictionary<Type,ICache> dicCache = new Dictionary<Type, ICache>();
        /// <summary>
        /// 通过构造函数的时候声明所有的单独biz
        /// </summary>
        static CacheManager()
        {
            Add<AccountCache>();

        }

        #region cache模块的管理

        /// <summary>
        /// 声明一个T对象,放到字典dicCache中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private static void Add<T>() where T : AccountCache, new()
        {
            dicCache.Add(typeof(T),new T());
        }
        /// <summary>
        /// 通过T类型，获取T对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>() where T :class ,ICache, new()
        {
            ICache biz;
            if (dicCache.TryGetValue(typeof(T),out biz))
            {
                return biz as T;
            }
            return null;
        }
        #endregion
    }
}
