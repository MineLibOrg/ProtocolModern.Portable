using MineLib.Core;
using MineLib.Core.IO;

namespace ProtocolModern.Packets.Server
{
    public struct CollectItemPacket : IPacket
    {
        public int CollectedEntityID;
        public int CollectorEntityID;

        public byte ID { get { return 0x0D; } }

        public IPacket ReadPacket(IProtocolDataReader reader)
        {
            CollectedEntityID = reader.ReadVarInt();
            CollectorEntityID = reader.ReadVarInt();

            return this;
        }

        public IPacket WritePacket(IProtocolStream stream)
        {
            stream.WriteVarInt(CollectedEntityID);
            stream.WriteVarInt(CollectorEntityID);
            
            return this;
        }
    }
}