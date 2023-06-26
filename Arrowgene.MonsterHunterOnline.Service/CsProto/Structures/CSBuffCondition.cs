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
    /// 服务器通知condition
    /// </summary>
    public class CSBuffCondition : IStructure
    {

        public CSBuffCondition()
        {
            EntityId = 0;
            UniqueID = 0;
            enable = 0;
        }

        /// <summary>
        /// Entity ID
        /// </summary>
        public uint EntityId;

        /// <summary>
        /// 唯一ID
        /// </summary>
        public int UniqueID;

        /// <summary>
        /// 是否起效
        /// </summary>
        public byte enable;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt32(EntityId, Endianness.Big);
            buffer.WriteInt32(UniqueID, Endianness.Big);
            buffer.WriteByte(enable);
        }

    }
}
