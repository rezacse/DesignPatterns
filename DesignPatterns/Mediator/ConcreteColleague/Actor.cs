using Mediator.Colleague;
using System;

namespace Mediator.ConcreteColleague
{
    public class Actor : Participant
    {
        public Actor(int participantId, string participantName)
            : base(participantId, participantName)
        {
        }

        public override void Receive(string senderName, string message)
        {
            //do extra work for receive actor message here
            Console.WriteLine("Send to a actor:");
            base.Receive(senderName, message);
        }
    }
}
