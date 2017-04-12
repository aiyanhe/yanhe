using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyConfig
{
    class JsonHelp
    {
        /// <summary>
        /// 反序列化json数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T FormatConfig<T>(string path) where T : class
        {//利用json的工具包进行解析
            string jsonData = File.ReadAllText(path);
            JsonReader jr = new JsonReader(jsonData);

            var t = JsonMapper.ToObject<T>(jr);

            return t;

        }

    }

}

