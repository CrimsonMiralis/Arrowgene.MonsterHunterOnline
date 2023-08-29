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

    public class GuildWarCommerceInfo : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(GuildWarCommerceInfo));

        public GuildWarCommerceInfo()
        {
            CommerceID = 0;
            GoodsNumber = 0;
            LastChangeTime = 0;
            GuildName = "";
            GuildId = 0;
            IsFinish = 0;
            Rank = 0;
        }

        /// <summary>
        /// 商会ID
        /// </summary>
        public uint CommerceID;

        /// <summary>
        /// 货物数量
        /// </summary>
        public uint GoodsNumber;

        /// <summary>
        /// 货物数量
        /// </summary>
        public uint LastChangeTime;

        /// <summary>
        /// 猎团名字
        /// </summary>
        public string GuildName;

        /// <summary>
        /// 猎团ID
        /// </summary>
        public ulong GuildId;

        /// <summary>
        /// 是否已经完成
        /// </summary>
        public byte IsFinish;

        /// <summary>
        /// 排名
        /// </summary>
        public byte Rank;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt32(CommerceID, Endianness.Big);
            buffer.WriteUInt32(GoodsNumber, Endianness.Big);
            buffer.WriteUInt32(LastChangeTime, Endianness.Big);
            buffer.WriteInt32(GuildName.Length + 1, Endianness.Big);
            buffer.WriteCString(GuildName);
            buffer.WriteUInt64(GuildId, Endianness.Big);
            buffer.WriteByte(IsFinish);
            buffer.WriteByte(Rank);
        }

        public void ReadCs(IBuffer buffer)
        {
            CommerceID = buffer.ReadUInt32(Endianness.Big);
            GoodsNumber = buffer.ReadUInt32(Endianness.Big);
            LastChangeTime = buffer.ReadUInt32(Endianness.Big);
            int GuildNameEntryLen = buffer.ReadInt32(Endianness.Big);
            GuildName = buffer.ReadString(GuildNameEntryLen);
            GuildId = buffer.ReadUInt64(Endianness.Big);
            IsFinish = buffer.ReadByte();
            Rank = buffer.ReadByte();
        }

    }
}
