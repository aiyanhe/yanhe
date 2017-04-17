using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFrame
{
   public  class UserToKenCache
    {
        public Stack<UserToken> Cache;//和queue类似但是规则为后进先出

        public UserToKenCache()
        {
            Cache = new Stack<UserToken>();

        }

        public UserToKenCache(int num)//容量为num
        {
            Cache = new Stack<UserToken>(num);
            for (int i = 0; i < num; i++)
            {
                Cache.Push(new UserToken());// 插入num个客户端
            }
        }
        /// <summary>
        /// 回收token
        /// </summary>
        /// <param name="UT"></param>
        public void Push(UserToken UT)
        {

            if (UT!=null)
            {
                Cache.Push(UT);//添加对象于顶部
            }


        }
        /// <summary>
        /// 取出token
        /// </summary>
        /// <returns></returns>
        public UserToken Pop()
        {
            if (Cache.Count == 0)
            {
                return new UserToken();
            }
           return Cache.Pop();//移除并返回顶部对象

        }

        public int Size //Size属性，返回Cache的数量
        {
           get { return Cache.Count; } 
        }

    }
}
