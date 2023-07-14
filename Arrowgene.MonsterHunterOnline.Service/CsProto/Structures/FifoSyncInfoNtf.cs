using Arrowgene.Buffers;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;

namespace Arrowgene.MonsterHunterOnline.Service.CsProto.Structures
{
    /// <summary>
    /// FIFO同步信息
    /// </summary>
    public class FifoSyncInfoNtf : Structure
    {
        public FifoSyncInfoNtf()
        {
            EntityId = 0;
            SyncInfo = new FifoSyncInfo();
        }

        /// <summary>
        /// 需要同步的Actor的EntityId
        /// </summary>
        public uint EntityId { get; set; }

        /// <summary>
        /// FIFO同步信息
        /// </summary>
        public FifoSyncInfo SyncInfo { get; set; }

        public override void Write(IBuffer buffer)
        {
            WriteUInt32(buffer, EntityId);
            SyncInfo.Write(buffer);
        }

        public override void Read(IBuffer buffer)
        {
            EntityId = ReadUInt32(buffer);
            SyncInfo = ReadStructure(buffer, SyncInfo);
        }
    }
}