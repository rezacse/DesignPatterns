using Mediator.Colleague;
using Mediator.ConcreteColleague;
using Mediator.Mediator;
using System.Collections.Generic;

namespace Mediator.ConcreteMediator
{
    public class ChatRoom : AbstractChatRoom
    {
        public ChatRoom(int id, string name) : base(id, name)
        {
        }

        private readonly Dictionary<int, Participant> _participants = new Dictionary<int, Participant>();
        public override void Register(Participant participant)
        {
            if (!_participants.ContainsKey(participant.Id))
                _participants.Add(participant.Id, participant);

            participant.ChatRoom = this;
        }

        public override void Send(int senderId, int receiverId, string message)
        {
            var participant = GetParticipant(senderId);
            var reciever = GetParticipant(receiverId);

            participant.Receive(reciever.Name, message);
        }

        public Participant GetParticipant(int participantId)
        {
            return _participants.ContainsKey(participantId) ? _participants[participantId] : new EmptyParticipant(0, "Not Found");
        }
    }
}
