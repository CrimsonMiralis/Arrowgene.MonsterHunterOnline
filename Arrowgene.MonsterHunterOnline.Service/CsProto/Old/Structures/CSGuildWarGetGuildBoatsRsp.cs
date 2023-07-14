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

    public class CSGuildWarGetGuildBoatsRsp : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSGuildWarGetGuildBoatsRsp));

        public CSGuildWarGetGuildBoatsRsp()
        {
            ErrCode = 0;
            GuildId = 0;
            GuildName = "";
            GuildBoats = new List<GuildBoatInfo>();
        }

        /// <summary>
        /// 错误码
        /// </summary>
        public uint ErrCode;

        /// <summary>
        /// 猎团ID
        /// </summary>
        public ulong GuildId;

        /// <summary>
        /// 玩家猎团名字
        /// </summary>
        public string GuildName;

        /// <summary>
        /// 商船信息
        /// </summary>
        public List<GuildBoatInfo> GuildBoats;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt32(ErrCode, Endianness.Big);
            buffer.WriteUInt64(GuildId, Endianness.Big);
            buffer.WriteInt32(GuildName.Length + 1, Endianness.Big);
            buffer.WriteCString(GuildName);
            ushort guildBoatsCount = (ushort)GuildBoats.Count;
            buffer.WriteUInt16(guildBoatsCount, Endianness.Big);
            for (int i = 0; i < guildBoatsCount; i++)
            {
                GuildBoats[i].Write(buffer);
            }
        }

        public void Read(IBuffer buffer)
        {
            ErrCode = buffer.ReadUInt32(Endianness.Big);
            GuildId = buffer.ReadUInt64(Endianness.Big);
            int GuildNameEntryLen = buffer.ReadInt32(Endianness.Big);
            GuildName = buffer.ReadString(GuildNameEntryLen);
            GuildBoats.Clear();
            ushort guildBoatsCount = buffer.ReadUInt16(Endianness.Big);
            for (int i = 0; i < guildBoatsCount; i++)
            {
                GuildBoatInfo GuildBoatsEntry = new GuildBoatInfo();
                GuildBoatsEntry.Read(buffer);
                GuildBoats.Add(GuildBoatsEntry);
            }
        }

    }
}