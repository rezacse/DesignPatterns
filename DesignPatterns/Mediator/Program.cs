using Mediator.Colleague;
using Mediator.ConcreteColleague;
using Mediator.ConcreteMediator;
using System;

namespace Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var chatroom = new ChatRoom(1, "Movies");

            Participant george = new Actor(1, "George");
            Participant paul = new Actor(2, "Paul");
            Participant john = new Member(3, "John");

            chatroom.Register(george);
            chatroom.Register(paul);
            chatroom.Register(john);


            paul.Send(george.Id, "All you need is love");
            george.Send(john.Id, "Can't buy me love");
            john.Send(paul.Id, "My sweet love");

            paul.Send(1111, "unknown receiver");

            Participant unregister = new Actor(101, "unregister participant");
            unregister.Send(paul.Id, "Message from unregister participant");


            Console.ReadKey();
        }
    }
}
