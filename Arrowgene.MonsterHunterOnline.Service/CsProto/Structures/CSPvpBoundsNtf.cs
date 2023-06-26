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
    /// PVP分数通知
    /// </summary>
    public class CSPvpBoundsNtf : IStructure
    {

        public CSPvpBoundsNtf()
        {
            TotalBounds = 0;
            RedBounds = 0;
            BlueBounds = 0;
        }

        /// <summary>
        /// PVP总分数
        /// </summary>
        public int TotalBounds;

        /// <summary>
        /// PVP分数通知
        /// </summary>
        public int RedBounds;

        /// <summary>
        /// PVP分数通知
        /// </summary>
        public int BlueBounds;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(TotalBounds, Endianness.Big);
            buffer.WriteInt32(RedBounds, Endianness.Big);
            buffer.WriteInt32(BlueBounds, Endianness.Big);
        }

    }
}
