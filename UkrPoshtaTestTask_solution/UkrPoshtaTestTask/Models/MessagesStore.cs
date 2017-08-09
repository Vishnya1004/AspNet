using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UkrPoshtaTestTask.Models
{
    public class MessagesStore
    {
        private const int storeUserSize = 10;
        private const int storeGlobalSize = 20;

        public List<Message> Messages { get; set; }

        public MessagesStore()
        {
            Messages = new List<Message>();
        }
        public void Add(Message message)
        {
            if (Messages.Count == storeGlobalSize)
            {
                List<Message> tmp = new List<Message>();
                tmp = Messages.GetRange(1, storeGlobalSize-1);
                Messages = tmp;
            }
            Messages.Add(message);
        }
        

    }
}