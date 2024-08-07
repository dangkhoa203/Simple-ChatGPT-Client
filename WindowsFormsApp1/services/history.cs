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

    public interface IHistory
    {
        void Add(ConversationModel chat);
        LinkedList<ConversationModel> Find(string date);
        Dictionary<string, LinkedList<ConversationModel>> getHistory();
    }
    [Serializable]
    public class History:IHistory
    {
        private Dictionary<string, LinkedList<ConversationModel>> history ;

        public History()
        {
           history = new Dictionary<string, LinkedList<ConversationModel>>();
           history=DataAccess.LoadFile("data.txt");
        }
        public void Add(ConversationModel chat)
        {
            if (!history.ContainsKey(chat.TimeOfChat.Date.ToString("dd/MM/yyyy")))
            {
                LinkedList<ConversationModel> tem = new LinkedList<ConversationModel>();
                history.Add(chat.TimeOfChat.Date.ToString("dd/MM/yyyy"), tem);
            }
            history[chat.TimeOfChat.Date.ToString("dd/MM/yyyy")].AddLast(chat);
        }
        public LinkedList<ConversationModel> Find(string date) {
            try { return history[date]; }
            catch {  return null; }
        }
        public Dictionary<string, LinkedList<ConversationModel>> getHistory()
        {
            return history;
        }
    }
}
