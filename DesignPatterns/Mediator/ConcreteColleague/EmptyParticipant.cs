using Mediator.Colleague;
using System;

namespace Mediator.ConcreteColleague
{
    public class EmptyParticipant : Participant
    {
        public EmptyParticipant(int participantId, string participantName)
            : base(participantId, participantName)
        {
        }

        public override void Receive(string senderName, string message)
        {
            //do extra work for receive actor message here
            Console.WriteLine("receiver not found");
        }
    }
}