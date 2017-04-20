using ServerFrame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCommon;
using Maticsoft;

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
            //setting.MessageEncrypt = DEncrypt.Encrypt;
            //setting.MessageDecrypt = DEncrypt.Decrypt;
            //setting.CompressEncode = CompressEncoding.Encode;
            //setting.CompressDecode = CompressEncoding.Decode;
            setting.Center = new HandlerCenter();
            UserToken.Setting = setting;
            server.StartServer(setting);

        }

        static void Main(string[] args)
        {
            SettingServer();
            //string inFile = @"C:\Users\123\Desktop\test\xxx02.txt";
            //string outFile = @"C:\Users\123\Desktop\test\aiyanhe.txt";
            //FileStream fileStream = File.Open(inFile, FileMode.Open);
            //FileStream outStream = File.Open(outFile, FileMode.Create);
            ////解密
            //byte[] bt= new byte[fileStream.Length];
            //fileStream.Read(bt,0,bt.Length);
            // byte[] ht = DEncrypt.Decrypt(bt);
            ////解压
            // byte[] lt = CompressEncoding.Decode(ht);
            //outStream.Write(lt,0,lt.Length);
            //outStream.Flush();
            //fileStream.Close();
            //outStream.Close();
            



            Console.CancelKeyPress += Console_CancleKeyPress;
            while (true)
            {
                
            }

        }

        private static void Console_CancleKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("正在关闭服务器！！！！！");
        }
    }
}
