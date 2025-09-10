using Mediator.Colleague;

namespace Mediator.Mediator
{
    public abstract class AbstractChatRoom
    {
        private readonly int _id;
        private readonly string _name;
        protected AbstractChatRoom(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public abstract void Register(Participant participant);
        public abstract void Send(int senderId, int receiverId, string message);
    }
}
