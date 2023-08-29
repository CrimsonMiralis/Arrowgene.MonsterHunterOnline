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
    /// 接受好友申请
    /// </summary>
    public class C2SAcceptFriendApply : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(C2SAcceptFriendApply));

        public C2SAcceptFriendApply()
        {
            Apply = 0;
            Dbid = 0;
            svr = 0;
            Name = "";
        }

        /// <summary>
        /// 申请
        /// </summary>
        public int Apply;

        /// <summary>
        /// 源玩家DBID
        /// </summary>
        public ulong Dbid;

        /// <summary>
        /// 源SvrId
        /// </summary>
        public uint svr;

        /// <summary>
        /// 源角色名
        /// </summary>
        public string Name;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(Apply, Endianness.Big);
            buffer.WriteUInt64(Dbid, Endianness.Big);
            buffer.WriteUInt32(svr, Endianness.Big);
            buffer.WriteInt32(Name.Length + 1, Endianness.Big);
            buffer.WriteCString(Name);
        }

        public void ReadCs(IBuffer buffer)
        {
            Apply = buffer.ReadInt32(Endianness.Big);
            Dbid = buffer.ReadUInt64(Endianness.Big);
            svr = buffer.ReadUInt32(Endianness.Big);
            int NameEntryLen = buffer.ReadInt32(Endianness.Big);
            Name = buffer.ReadString(NameEntryLen);
        }

    }
}
