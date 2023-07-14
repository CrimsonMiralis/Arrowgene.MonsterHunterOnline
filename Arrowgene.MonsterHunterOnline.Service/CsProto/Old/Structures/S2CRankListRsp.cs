/*
* This file is part of Arrowgene.MonsterHunterOnline
*
* Arrowgene.MonsterHunterOnline is a server implementation for the game "Monster Hunter Online".
* Copyright (C) 2023-2024 "all contributors"
*
* Github: https://github.com/sebastian-heinz/Arrowgene.MonsterHunterOnline
*
*  This program is free software: you can redistribute it and/or modify
*  it under the terms of the GNU Affero General Public License as published
*  by the Free Software Foundation, either version 3 of the License, or
*  (at your option) any later version.
*
*  This program is distributed in the hope that it will be useful,
*  but WITHOUT ANY WARRANTY; without even the implied warranty of
*  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*  GNU Affero General Public License for more details.
*
*  You should have received a copy of the GNU Affero General Public License
*  along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

/* THIS IS AN AUTOGENERATED FILE. DO NOT EDIT THIS FILE DIRECTLY. */

using System.Collections.Generic;
using Arrowgene.Buffers;
using Arrowgene.Logging;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Enums;

namespace Arrowgene.MonsterHunterOnline.Service.CsProto.Structures
{

    /// <summary>
    /// 获取排行榜列表 from to
    /// </summary>
    public class S2CRankListRsp : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(S2CRankListRsp));

        public S2CRankListRsp()
        {
            rankId = 0;
            pos = 0;
            rankersCount = 0;
            from = 0;
            to = 0;
            rankData = new CSRankData();
        }

        /// <summary>
        /// 榜单ID
        /// </summary>
        public int rankId;

        /// <summary>
        /// 玩家自己在该榜单中的排名（从1开始，0表示不在榜单中）
        /// </summary>
        public int pos;

        /// <summary>
        /// 榜单总名单数目
        /// </summary>
        public int rankersCount;

        public int from;

        public int to;

        public CSRankData rankData;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(rankId, Endianness.Big);
            buffer.WriteInt32(pos, Endianness.Big);
            buffer.WriteInt32(rankersCount, Endianness.Big);
            buffer.WriteInt32(from, Endianness.Big);
            buffer.WriteInt32(to, Endianness.Big);
            rankData.Write(buffer);
        }

        public void Read(IBuffer buffer)
        {
            rankId = buffer.ReadInt32(Endianness.Big);
            pos = buffer.ReadInt32(Endianness.Big);
            rankersCount = buffer.ReadInt32(Endianness.Big);
            from = buffer.ReadInt32(Endianness.Big);
            to = buffer.ReadInt32(Endianness.Big);
            rankData.Read(buffer);
        }

    }
}