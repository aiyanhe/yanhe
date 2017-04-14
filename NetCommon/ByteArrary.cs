using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon
{
    public class ByteArrary
    {
        /// <summary>
        /// 支持存储区为内存的流
        /// </summary>
        private MemoryStream ms;
        /// <summary>
        /// 将流的内容读出来转成二进制
        /// </summary>
        private BinaryReader br;
        /// <summary>
        /// 将二进制写入流
        /// </summary>
        private BinaryWriter bw;
        /// <summary>
        /// 构造函数——用来写的
        /// </summary>
        public ByteArrary()
        {
            ms = new MemoryStream();
            br = new BinaryReader(ms);
            bw = new BinaryWriter(ms);
        }
        /// <summary>
        /// 构造函数——用来读的
        /// </summary>
        /// <param name="bt"></param>
        public ByteArrary(byte[] bt)
        {
            ms = new MemoryStream(bt);
            br = new BinaryReader(ms);
            bw = new BinaryWriter(ms);
        }

        #region Write写

        public void Write(Protocol value)
        {
            bw.Write((byte)value);
        }

        public void Write(short value)
        {
            bw.Write(value);
        }
        public void Write(long value)
        {
            bw.Write(value);
        }
        public void Write(int value)
        {
            bw.Write(value);
        }
        public void Write(float value)
        {
            bw.Write(value);
        }
        public void Write(char value)
        {
            bw.Write(value);
        }
        public void Write(byte[] value)
        {
            bw.Write(value);
        }
        public void Write(byte value)
        {
            bw.Write(value);
        }
        public void Write(decimal value)
        {
            bw.Write(value);
        }
        public void Write(object value)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms,value);
            byte[] bt = ms.GetBuffer();
            bw.Write(bt);
            ms.Dispose();
            ms.Close();
        }
        #endregion

        #region Read读
        public void Read(out Protocol value)
        {
            value = (Protocol)br.ReadByte();
        }

        public void Read(out bool value)
        {
            value = br.ReadBoolean();
        }
        public void Read(out char value)
        {
            value = br.ReadChar();
        }
        public void Read(out decimal value)
        {
            value = br.ReadDecimal();
        }
        public void Read(out short value)
        {
            value = br.ReadInt16();
        }
        public void Read(out int value)
        {
            value = br.ReadInt32();
        }
        public void Read(out long value)
        {
            value = br.ReadInt64();
        }
        public void Read(out float value)
        {
            value = br.ReadSingle();
        }
        public void Read(out string value)
        {
            value = br.ReadString();
        }
        public void Read(out byte value)
        {
            value = br.ReadByte();
        }

        public void Read(out byte[] value,int len)
        {
            value = br.ReadBytes(len);
        }

        public void Read(int len, out object value)
        {
            if (!Readable)//当前流的位置超出流的最大长度，无法读取
            {
                value = null;
                return;
            }
            byte[] bt;
            Read(out bt,len);
            MemoryStream msd = new MemoryStream(bt); 
            BinaryFormatter bf = new BinaryFormatter();
            value = bf.Deserialize(msd);
            msd.Dispose();
            msd.Close();
        }

        #endregion
        /// <summary>
        /// 当前流的长度
        /// </summary>

        public int Length
        {
            get { return (int)ms.Length; }
        }
        /// <summary>
        /// 当前流的位置
        /// </summary>
        public int Position {
            get { return (int)ms.Position; }
        }
        /// <summary>
        /// 判断当前流的位置是否在末尾的前面还是后面,true为前面,false为后面
        /// </summary>
        public bool Readable
        {
            get { return Length > Position; }
        }
        /// <summary>
        /// 复位流的当前位置于0，即开头处
        /// </summary>
        public void RestPosition()
        {
            ms.Position = 0;

        }
        /// <summary>
        /// 将当前流的二进制克隆转成Byte[]输出
        /// </summary>
        /// <returns></returns>
        public Byte[] GetCopyBytes()
        {
            byte[] buffer = new byte[ms.Length];
            Buffer.BlockCopy(ms.GetBuffer(),0,buffer,0,Length);
            return buffer;
        }
        /// <summary>
        /// 关闭当前流
        /// </summary>
        public void Close()
        {
            ms.Dispose();
            ms.Close();
            br.Close();
            bw.Close();
        }





    }
}
