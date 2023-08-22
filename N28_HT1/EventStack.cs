using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT1
{
    public class EventStack<TEvent> where TEvent : IEvent 
    {
        private List<TEvent> _stacks;

        public EventStack()
        {
            _stacks = new List<TEvent>();
        }
        public void Push(TEvent events)
        {
            if(!_stacks.Any(item => item.Date > events.Date))
            {
                _stacks.Add(events);
                return;
            }
            throw new ArgumentException("This event not valid");
        }

        public TEvent Peek()
        {
            return _stacks.Last();
        }

        public TEvent Pop()
        {
            var last = _stacks[_stacks.Count -1];
            _stacks.RemoveAt(_stacks.Count - 1);
            return last;
        }
    }
}
