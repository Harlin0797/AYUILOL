using System;
using System.IO;
using System.Xml.Serialization;

namespace LOLSkinGetter.DAL
{
    public class FileHelper
    {
        #region 方法

        /// <summary>
        /// 读文件
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns>输出文件内容</returns>
        public static string Read(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("文件不存在,请检查路径是否正确。[{0}]", path);

            return File.ReadAllText(path);
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="content">文件内容</param>
        public static void Write(string path, string content)
        {
            CreateDirectory(path.Remove(path.LastIndexOf('\\') + 1));
            using (StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                writer.Write(content);
                writer.Close();
            }
        }


        /// <summary>
        /// 创建目录
        /// <remarks>
        /// 支持创建多级目录
        /// </remarks>
        /// </summary>
        /// <param name="dir">路径</param>
        public static void CreateDirectory(string dir)
        {
            if (!Directory.Exists(dir) && string.IsNullOrEmpty(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        /// <summary>
        /// 删除目录
        /// <remarks>
        /// 删除该目录中的任何子目录
        /// </remarks>
        /// </summary>
        /// <param name="dir">路径</param>
        public static void DeleteDirectory(string dir)
        {
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir, true);
            }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        /// <summary>
        /// 加载XML文件
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="objectType">反序列化的对象类型</param>
        /// <returns></returns>
        public static object LoadXmlFile(string path, Type objectType)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                object obj = new XmlSerializer(objectType).Deserialize(stream);
                stream.Close();
                return obj;
            }
        }

        #endregion

    }





}
