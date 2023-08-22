using N28_HT1;

var eventStack = new EventStack<IEvent>();
eventStack.Push(new Event("Event1", new DateTime(2023,12,12)));
eventStack.Push(new Event("event2", new DateTime(2024, 11, 12)));
eventStack.Peek();
eventStack.Pop();
eventStack.Pop();

