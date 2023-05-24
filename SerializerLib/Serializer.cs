using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializerLib
{
    public class Serializer
    {
        public static T? Load<T>(string path)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                T? obj = JsonConvert.DeserializeObject<T>(json);
                return obj;
            }
            else
            {
                return default(T);
            }
        }

        public static void Save<T>(string path, T obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(path, json);
        }
    }
}
