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

    public class CSGuildGetGuildStatusRsp : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSGuildGetGuildStatusRsp));

        public CSGuildGetGuildStatusRsp()
        {
            ErrCode = 0;
            GuildWarCommerceInfoList = new List<GuildWarCommerceInfo>();
            GuildId = 0;
            CommerceId = 0;
        }

        /// <summary>
        /// 错误码
        /// </summary>
        public uint ErrCode;

        /// <summary>
        /// 商船猎团信息
        /// </summary>
        public List<GuildWarCommerceInfo> GuildWarCommerceInfoList;

        /// <summary>
        /// 请求中猎团ID
        /// </summary>
        public ulong GuildId;

        /// <summary>
        /// 商会ID
        /// </summary>
        public uint CommerceId;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt32(ErrCode, Endianness.Big);
            ushort guildWarCommerceInfoListCount = (ushort)GuildWarCommerceInfoList.Count;
            buffer.WriteUInt16(guildWarCommerceInfoListCount, Endianness.Big);
            for (int i = 0; i < guildWarCommerceInfoListCount; i++)
            {
                GuildWarCommerceInfoList[i].WriteCs(buffer);
            }
            buffer.WriteUInt64(GuildId, Endianness.Big);
            buffer.WriteUInt32(CommerceId, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            ErrCode = buffer.ReadUInt32(Endianness.Big);
            GuildWarCommerceInfoList.Clear();
            ushort guildWarCommerceInfoListCount = buffer.ReadUInt16(Endianness.Big);
            for (int i = 0; i < guildWarCommerceInfoListCount; i++)
            {
                GuildWarCommerceInfo GuildWarCommerceInfoListEntry = new GuildWarCommerceInfo();
                GuildWarCommerceInfoListEntry.ReadCs(buffer);
                GuildWarCommerceInfoList.Add(GuildWarCommerceInfoListEntry);
            }
            GuildId = buffer.ReadUInt64(Endianness.Big);
            CommerceId = buffer.ReadUInt32(Endianness.Big);
        }

    }
}
