using Mediator.ConcreteMediator;
using System;

namespace Mediator.Colleague
{
    public abstract class Participant
    {
        public readonly int Id;
        public readonly string Name;
        public ChatRoom ChatRoom;

        protected Participant(int participantId, string participantName)
        {
            Id = participantId;
            Name = participantName;
        }

        public void Send(int recieverId, string message)
        {
            ChatRoom?.Send(Id, recieverId, message);
            //throw new NullReferenceException("User is not register to any Chat Room.");
        }

        public virtual void Receive(string senderName, string message)
        {
            Console.WriteLine($"{Name} to {senderName}: {message}");
        }
    }
}
