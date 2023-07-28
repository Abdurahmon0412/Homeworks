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

        protected string FindMessage(string messagename)
        {
            foreach (var member in MessegeMember)
            {
                if(member.Key.Contains(messagename))
                {
                    return $"{member.Key} - {member.Value}";
                }
            }
            return "This message not found";
        }
        public string SearchMessage(string messagename)
        {
            return FindMessage(messagename);
        }
    }

    
}
