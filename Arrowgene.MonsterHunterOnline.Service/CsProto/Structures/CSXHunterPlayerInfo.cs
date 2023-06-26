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
using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Enums;

namespace Arrowgene.MonsterHunterOnline.Service.CsProto.Structures
{

    /// <summary>
    /// 极限猎人玩家信息
    /// </summary>
    public class CSXHunterPlayerInfo : IStructure
    {

        public CSXHunterPlayerInfo()
        {
            QQ = 0;
            NetId = 0;
            Name = "";
            Level = 0;
            Camp = 0;
            DmgPer = 0;
        }

        /// <summary>
        /// 玩家QQ
        /// </summary>
        public uint QQ;

        /// <summary>
        /// 玩家的NETID
        /// </summary>
        public int NetId;

        /// <summary>
        /// role name
        /// </summary>
        public string Name;

        /// <summary>
        /// 玩家等级
        /// </summary>
        public int Level;

        /// <summary>
        /// 阵营
        /// </summary>
        public int Camp;

        /// <summary>
        /// 伤害占比
        /// </summary>
        public int DmgPer;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt32(QQ, Endianness.Big);
            buffer.WriteInt32(NetId, Endianness.Big);
            buffer.WriteInt32(Name.Length + 1, Endianness.Big);
            buffer.WriteCString(Name);
            buffer.WriteInt32(Level, Endianness.Big);
            buffer.WriteInt32(Camp, Endianness.Big);
            buffer.WriteInt32(DmgPer, Endianness.Big);
        }

    }
}
