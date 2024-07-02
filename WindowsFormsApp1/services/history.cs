using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.data;
using WindowsFormsApp1.model;
namespace WindowsFormsApp1.services
{
    [Serializable]
    public class historywork
    {
        private Dictionary<string, LinkedList<conversation>> history ;

        public historywork()
        {
           history = new Dictionary<string, LinkedList<conversation>>();
           history=DataAccess.LoadFile("data.txt");
        }
        public void add(conversation chat)
        {
            if (!history.ContainsKey(chat.TimeOfChat.Date.ToString("dd/MM/yyyy")))
            {
                LinkedList<conversation> tem = new LinkedList<conversation>();
                history.Add(chat.TimeOfChat.Date.ToString("dd/MM/yyyy"), tem);
            }
            history[chat.TimeOfChat.Date.ToString("dd/MM/yyyy")].AddLast(chat);
        }
        public LinkedList<conversation> find(string date)
        {
            try { return history[date]; }
            catch {  return null; }
        }
        public Dictionary<string, LinkedList<conversation>> getHistory()
        {
            return history;
        }
    }
}
