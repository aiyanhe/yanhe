
using System.Collections.Generic;
namespace MyConfig
{
    partial class SkillConstenfig
    {
        public List<Ked> Skills{get;set;}

    }
   public  partial class SkillConstenfig : Constenfig<SkillConstenfig>, IRead
    {
        protected override void Init()
        {
            base.Init();
            Data.Name = "Consten";
            Data.Path = "/Consten/";
            Data.Extension = ".txt";
        }


        public void Read(string name)
        {
            Skills = new List<Ked>();

            string[] str = name.Split('\n');
            foreach (var item in str)
            {
                Ked k = new Ked();
                k.Read(item);
                Skills.Add(k);
            }
        }
    }
    public class Ked:IRead
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

        public void Read(string name)
        {
            string[] str = name.Split('!');
            ID = int.Parse( str[1]);
            SkillId = int.Parse(str[2]);
            SkillName = str[3];
            SkillType = str[4];
            Expend = int.Parse(str[5]);
            Value = int.Parse(str[6]);
            Destail = str[7];
            IntoGameName = str[8];
            KillsForUserId = int.Parse(str[9]);
        }
     
    }
}
