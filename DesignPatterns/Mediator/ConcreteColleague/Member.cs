using Mediator.Colleague;
using System;

namespace Mediator.ConcreteColleague
{
    public class Member : Participant
    {
        public Member(int participantId, string participantName)
            : base(participantId, participantName)
        {
        }

        public override void Receive(string senderName, string message)
        {
            //do extra work for member actor message here
            Console.WriteLine("Send to a member:");
            base.Receive(senderName, message);
        }
    }
}
