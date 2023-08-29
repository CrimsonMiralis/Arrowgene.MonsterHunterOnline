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
    /// 角色
    /// </summary>
    public class CSRole : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSRole));

        public CSRole()
        {
            Name = "";
            Dbid = 0;
            Rtid = 0;
            Uin = 0;
            CelebrationReward = 0;
        }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name;

        /// <summary>
        /// Dbid
        /// </summary>
        public ulong Dbid;

        /// <summary>
        /// Rtid
        /// </summary>
        public uint Rtid;

        /// <summary>
        /// Uin
        /// </summary>
        public ulong Uin;

        /// <summary>
        /// 奖励
        /// </summary>
        public int CelebrationReward;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(Name.Length + 1, Endianness.Big);
            buffer.WriteCString(Name);
            buffer.WriteUInt64(Dbid, Endianness.Big);
            buffer.WriteUInt32(Rtid, Endianness.Big);
            buffer.WriteUInt64(Uin, Endianness.Big);
            buffer.WriteInt32(CelebrationReward, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            int NameEntryLen = buffer.ReadInt32(Endianness.Big);
            Name = buffer.ReadString(NameEntryLen);
            Dbid = buffer.ReadUInt64(Endianness.Big);
            Rtid = buffer.ReadUInt32(Endianness.Big);
            Uin = buffer.ReadUInt64(Endianness.Big);
            CelebrationReward = buffer.ReadInt32(Endianness.Big);
        }

    }
}
