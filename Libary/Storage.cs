using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lib
{
    public static class Storage
    {
        private static BinaryFormatter bf;
        static Storage() {
            bf = new BinaryFormatter();
        }
        public static void Save(Object obj, string file)
        {
            try
            {
                Log.log.Info("Save file into path");
                Stream outStream = new FileStream(file, FileMode.OpenOrCreate);
                bf.Serialize(outStream, obj);
                outStream.Close();
            }
            catch (Exception e) {
                Log.log.Error(e.ToString());
            }
        }
        public static Object Load(string file) {
            Object result = null;
            try
            {
                Log.log.Info("Load file from path");
                Stream inStream = new FileStream(file, FileMode.Open);
                result=bf.Deserialize(inStream);
                inStream.Close();
            }
            catch (Exception e)
            {
                Log.log.Error(e.ToString());
            }
            return result;
        }
    }
}
