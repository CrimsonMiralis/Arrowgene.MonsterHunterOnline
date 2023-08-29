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
    /// 猎团邀请
    /// </summary>
    public class CSGuildInvitation : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSGuildInvitation));

        public CSGuildInvitation()
        {
            Id = 0;
            Guild = 0;
            Name = "";
            Sender = "";
            Time = 0;
        }

        /// <summary>
        /// 标识
        /// </summary>
        public int Id;

        /// <summary>
        /// 猎团
        /// </summary>
        public ulong Guild;

        /// <summary>
        /// 猎团
        /// </summary>
        public string Name;

        /// <summary>
        /// 发送者
        /// </summary>
        public string Sender;

        /// <summary>
        /// 时间
        /// </summary>
        public int Time;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(Id, Endianness.Big);
            buffer.WriteUInt64(Guild, Endianness.Big);
            buffer.WriteInt32(Name.Length + 1, Endianness.Big);
            buffer.WriteCString(Name);
            buffer.WriteInt32(Sender.Length + 1, Endianness.Big);
            buffer.WriteCString(Sender);
            buffer.WriteInt32(Time, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            Id = buffer.ReadInt32(Endianness.Big);
            Guild = buffer.ReadUInt64(Endianness.Big);
            int NameEntryLen = buffer.ReadInt32(Endianness.Big);
            Name = buffer.ReadString(NameEntryLen);
            int SenderEntryLen = buffer.ReadInt32(Endianness.Big);
            Sender = buffer.ReadString(SenderEntryLen);
            Time = buffer.ReadInt32(Endianness.Big);
        }

    }
}
