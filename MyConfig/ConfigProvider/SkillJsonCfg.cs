
using System.Collections.Generic;
namespace MyConfig
{
    public class Skill
    {
        public int ID { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillType { get; set; }
        public int Expend { get; set; }
        public int Value { get; set; }
        public string Destail { get; set; }
        public string IntoGameName { get; set; }
        public int KillsForUserId { get; set; }
    }

    public class SkillsJsonCfg:jsonConfig<SkillsJsonCfg>
    {
        protected override void Init()
        {
            base.Init();
            Data.Name = "JsonCfg";
            Data.Path = "/Json/";
            Data.Extension = ".txt";
        }
        public List<Skill> Skills { get; set; }
    }

}
