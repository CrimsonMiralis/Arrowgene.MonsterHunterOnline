﻿using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;
using Arrowgene.MonsterHunterOnline.Service.TQQApi;

namespace Arrowgene.MonsterHunterOnline.Service.TqqApi;

public abstract class TdpuStructureHandler<TStructure> : ITpduHandler where TStructure : class, IStructure, new()
{
    public abstract TpduCmd Cmd { get; }

    public abstract void Handle(Client client, TStructure req);

    public void Handle(Client client, TpduPacket packet)
    {
        TStructure structure = new TStructure();
        structure.Read(packet.NewHeaderExtBuffer());
        Handle(client, structure);
    }
}