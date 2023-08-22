using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT1
{
    public class Event:IEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Event(string name, DateTime date)
        {
            Id = Guid.NewGuid();
            Name = name;
            Date = date;
        }
    }
}
