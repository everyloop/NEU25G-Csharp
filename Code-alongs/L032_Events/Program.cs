
var publisher = new Publisher();

var subscriber1 = new Subscriber("Adam");
var subscriber2 = new Subscriber("Eva");
var subscriber3 = new Subscriber("Jonas");

publisher.Message += subscriber1.OnMessageRecieved;
publisher.Message += subscriber2.OnMessageRecieved;
publisher.Message += subscriber3.OnMessageRecieved;

// Går inte att göra på event (men på multicast delegates)
// publisher.Message = subscriber3.OnMessageRecieved;

publisher.SendMessage("Hello everyone!");

Console.WriteLine();

publisher.Message -= subscriber2.OnMessageRecieved;

publisher.SendMessage("Hello?");


// Går inte att göra på event (men på multicast delegates)
// publisher.Message.Invoke(5, EventArgs.Empty);
