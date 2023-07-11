using Arrowgene.Buffers;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Enums;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Structures;

namespace Arrowgene.MonsterHunterOnline.Service.CsProto.Handler;

public class CsCmdPlayerRegionJumpReqHandler : ICsProtoHandler
{
    public CS_CMD_ID Cmd => CS_CMD_ID.CS_CMD_PLAYER_REGION_JUMP_REQ;

    public void Handle(Client client, CsProtoPacket packet)
    {
        CSPlayerRegionJumpReq req = new CSPlayerRegionJumpReq();
        req.Read(packet.NewBuffer());

        client.State.OnPlayerRegionJumpReq(req);
    }
}