using System;
using System.IO;
using SevenZip;
using SevenZip.Compression.LZMA;

namespace NetCommon
{
    
    /// <summary>
    /// 压缩，解压
    /// </summary>
   public  static class CompressEncoding
    {
        #region 压缩、解压byte[]数据，输出byte[]

        /// <summary>
        /// 压缩byte[]数据，输出byte[]
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public static byte[] Encode(byte[] buff, ICodeProgress progress = null)
        {
            //使用压缩Encoder
            Encoder coder = new Encoder();
            using (MemoryStream instream = new MemoryStream(buff))
            using (MemoryStream outstream = new MemoryStream())
            {
                //写入5字节coder属性
                coder.WriteCoderProperties(outstream);
                //写入4字节，压缩文件的长度
                outstream.Write(BitConverter.GetBytes(buff.Length), 0, 4);
                //压缩数据，属性和长度可以看出没被压缩，内容才被压缩
                coder.Code(instream, outstream, instream.Length, -1, progress);
                buff = outstream.ToArray();
                outstream.Close();
            }
            return buff;
        }

        /// <summary>
        /// 解压byte[]数据，输出byte[]
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public static byte[] Decode(byte[] buff, ICodeProgress progress = null)
        {
            //使用解压Decoder
            Decoder coder = new Decoder();
            using (MemoryStream intStream = new MemoryStream(buff))
            using (MemoryStream outStream = new MemoryStream())
            {
                //先读出属性，5个字节
                byte[] progressBytes = new byte[5];
                intStream.Read(progressBytes, 0, 5);
                //再读出长度，4个字节
                byte[] len = new byte[4];
                intStream.Read(len, 0, 4);
                //设置解压属性
                coder.SetDecoderProperties(progressBytes);
                //解压
                coder.Code(intStream, outStream, intStream.Length, BitConverter.ToInt32(len, 0), progress);
                buff = outStream.ToArray();
                outStream.Close();
                intStream.Close();
            }
            return buff;
        }

        #endregion

        #region 压缩，解压文件



        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public static void Encode(string inFile, string outFlie, ICodeProgress progress = null)
        {
            Encoder coder = new Encoder();
            using (FileStream inFileStream = new FileStream(inFile, FileMode.Open))
            using (FileStream outFileStream = new FileStream(outFlie, FileMode.Create))
            {
                //先写入压缩属性,5字节
                coder.WriteCoderProperties(outFileStream);
                //再写入长度，4字节
                byte[] buff = BitConverter.GetBytes((int) inFileStream.Length);
                outFileStream.Write(buff, 0, 4);
                //压缩文件
                coder.Code(inFileStream, outFileStream, inFileStream.Length, -1, progress);
                //将压缩好的流转入存储文件
                outFileStream.Flush();
                //收尾
                outFileStream.Close();
                inFileStream.Close();
            }
        }

        /// <summary>
        /// 解压文件
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public static void Decode(string inFile, string outFlie, ICodeProgress progress = null)
        {
            Decoder coder = new Decoder();
            using (FileStream inFileStream = new FileStream(inFile, FileMode.Open))
            using (FileStream outFileStream = new FileStream(outFlie, FileMode.Create))
            {
                //先读出属性,设置属性
                byte[] progressBytes = new byte[5];
                outFileStream.Read(progressBytes, 0, 5);
                coder.SetDecoderProperties(progressBytes);
                //再读出长度
                byte[] len = new byte[4];
                outFileStream.Read(len, 0, 4);
                //最后读出内容
                coder.Code(inFileStream, outFileStream, inFileStream.Length, BitConverter.ToUInt16(len, 0), progress);

                //内容存到文件
                outFileStream.Flush();
                //收尾
                outFileStream.Close();
                inFileStream.Close();
            }
        }
    

    #endregion 
    }

    public class CompressProgress : ICodeProgress
    {
        public string Name;

        public CompressProgress()
        {
            Name = "7Zip Progress";
        }

        public CompressProgress(string name)
        {
            Name = name;
        }

        public void SetProgress(long inSize, long outSize)
        {
            Console.WriteLine("Name:{0}  Compress Progress in:{1} out:{2}", Name, inSize, outSize);
        }
    }
}
