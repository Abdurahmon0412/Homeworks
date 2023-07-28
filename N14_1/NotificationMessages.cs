using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14_1
{
    public class NotificationMessages
    {
        private Dictionary<string, string> MessegeMember = new Dictionary<string, string>();


        public NotificationMessages()
        {
            AddDic();
        }
        private  void AddDic()
        {
            MessegeMember.Add("SuccRegistration", "You successfully registered");
            MessegeMember.Add("AskPassword" , "Enter your password");
            MessegeMember.Add("Blocked" , "Your account has been blocked");

        }

        protected KeyValuePair<string, string>? FindMessage(string messagename)
        {
            foreach (var member in MessegeMember)
            {
                if(member.Key.Contains(messagename))
                {
                    return member;
                }
            }
            return null;
        }
        public string SearchMessage(string messagename)
        {
            var message =  FindMessage(messagename);
            return message == null ? "Message not found" : message.Value.Value;
        }
    }

    
}
