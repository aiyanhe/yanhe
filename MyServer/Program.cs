using ServerFrame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCommon;

namespace MyServer
{
    class Program
    {
        public static void SettingServer()
        {
            ServerAgent server = new ServerAgent();
            ServerSetting setting = new ServerSetting();
            setting.LengthDncoad = LengthEncoding.Dncoad;
            setting.LengthEncoad = LengthEncoding.Encoad;
            setting.MessageEncoad = MessageEncoding.Encoad;
            setting.MessageDncoad = MessageEncoding.Dncoad;
            setting.Center = new HandlerCenter();
            UserToken.Setting = setting;
            server.StartServer(setting);

        }

        static void Main(string[] args)
        {
            SettingServer();
            Console.ReadKey();

        }
    }
}
