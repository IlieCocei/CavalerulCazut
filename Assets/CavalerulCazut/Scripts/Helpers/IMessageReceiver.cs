using System;

namespace CavalerulCazut
{
    public enum MessageType
    {
        DAMAGED,
        DEAD
    }

    public interface IMessageReceiver
    {
        void OnReceiveMessage(
            MessageType type,
            object sender,
            object msg);
    }
}

