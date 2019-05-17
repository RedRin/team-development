using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Lib
{
    public class GetValue
    {
        public static bool GetValue1(string json, int index, out string value)
        {
            //解析失败的默认返回值
            value = "";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            try
            {
                object[] obj_json = serializer.DeserializeObject(json) as object[];
                if (obj_json.Length > index)
                {
                    value = serializer.Serialize(obj_json[index]);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
