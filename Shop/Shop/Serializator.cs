using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Shop
{
    public static class Serializator
    {
        public static List<T> InitializeList<T>(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            List<T> result = new List<T>();

            if (!fileInfo.Exists)
                File.WriteAllText(filePath, "");
            if (fileInfo.Length != 0)
            {
                T[] items = DesirializeList<T>(filePath);

                for (int i = 0; i < items.Length; i++)
                    result.Add(items[i]);
            }
            return result;
        }

        public static void SerializeList<T>(List<T> currentList, string filePath)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            File.WriteAllText(filePath, "");

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, currentList);
            }
        }

        private static T[] DesirializeList<T>(string filePath)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T[]));
            
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return (T[])formatter.Deserialize(fs);
            }
        }
    }
}
