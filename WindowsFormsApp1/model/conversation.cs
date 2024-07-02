using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.model
{
    [Serializable]
    public class conversation
    {
        private string prompt;
        private string message;
        private DateTime timeofdate;
        private DateTime timeofmess;
        public conversation() {
        prompt = string.Empty;
        message = string.Empty;
        timeofdate = DateTime.Now;
        }
        public conversation(string input,string output)
        {
            this.prompt = input;
            this.message = output;
            this.timeofdate = DateTime.Now;
        }

        public string Prompt
        {
            get {return prompt ;} 
            set { prompt = value;}
        }
        public string Message
        {
            get { return message; }
            set { message = value;}
        }
        public DateTime TimeOfChat
        {
            get { return timeofdate; }
        }
        public DateTime TimeOfMessage
        {
            get { return timeofmess; }
            set {  timeofmess = value;}
        }
    }
}
