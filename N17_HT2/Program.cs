using N17_HT2;

var chat = new Chat();
var ch1 = chat.Add("Hi everybody");
var ch2 = chat.Add("Let's get started");
var ch3 = chat.Add("We'll start the meeting in 10 minutes");


chat.Update(ch3, "Sorry guys, we are having technical issues, let's wait for another 10 minutes");

chat.Update(ch3, "I'm really sorry meeting is cancelled");

chat.Display();