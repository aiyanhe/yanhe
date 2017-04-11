using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfig
{
    public partial class SkillsCfg:XmlConfig<SkillsCfg>
    {
        public static string GetSkillsName(int id)
        {
            foreach (var item in SkillsCfg.Config.Content)
            {
                if (item.ID==id)
                {
                    return item.IntoGameName;
                }
            }
            return "配置表中没有找到该错误信息！ Error ID:" + id;
        }
    }
}
