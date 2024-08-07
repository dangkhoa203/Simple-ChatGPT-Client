using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1.data
{
    [Serializable]
    public class DataAccess
    {
        public static Dictionary<string, LinkedList<ConversationModel>> LoadFile(string filename)
        {
            try
            {
                Dictionary<string, LinkedList<ConversationModel>> tem = new Dictionary<string, LinkedList<ConversationModel>>();
                if (!File.Exists(filename))
                {
                    return tem;
                }
                FileStream fs = new FileStream(filename, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                tem = (Dictionary<string, LinkedList<ConversationModel>>)bf.Deserialize(fs);
                fs.Close();
                return tem;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static bool SaveFile(string filename, Dictionary<string, LinkedList<ConversationModel>> history)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, history);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {   
                return false;
            }
        }
    }
}
