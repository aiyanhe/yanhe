using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyServer.Biz;

namespace MyServer
{
    /// <summary>
    /// biz的管理器,当有多个处理不同逻辑的biz的时候，每个都要new一个对象，会造成程序臃於，所以有了这个管理器来同一管理，需要用特定的biz的时候直接通过这个管理器找；
    /// </summary>
    public  class BizManager
    {
        //readonly 只读,被readonly修饰的值只能在初始化或者构造函数中修改/赋值;
        //const 字段只能在该字段的声明中初始化。 readonly 字段可以在声明或构造函数中初始化。
        /// <summary>
        /// 字典，存储所有的声明的biz，key为biz类型Type,值为biz的声明对象
        /// </summary>
        private readonly static Dictionary<Type,IBiz> dicBizes = new Dictionary<Type, IBiz>();
        /// <summary>
        /// 通过构造函数的时候声明所有的单独biz
        /// </summary>
        static BizManager()
        {
            Add<AccoutBiz>();

        }

        #region biz模块的管理

        /// <summary>
        /// 声明一个T对象,放到字典dicBizes中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private static void Add<T>() where T:IBiz,new()
        {
            dicBizes.Add(typeof(T),new T());
        }
        /// <summary>
        /// 通过T类型，获取T对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>() where T :class ,IBiz,new()
        {
            IBiz biz;
            if (dicBizes.TryGetValue(typeof(T),out biz))
            {
                return biz as T;
            }
            return null;
        }
        #endregion
    }
}
