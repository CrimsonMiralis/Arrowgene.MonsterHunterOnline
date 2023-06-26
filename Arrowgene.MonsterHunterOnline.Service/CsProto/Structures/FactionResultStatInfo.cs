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
    /// 阵营统计结算信息
    /// </summary>
    public class FactionResultStatInfo : IStructure
    {

        public FactionResultStatInfo()
        {
            FactionID = 0;
            FactionDataType = new List<int>();
            FactionDataValue = new List<int>();
        }

        /// <summary>
        /// 阵营ID
        /// </summary>
        public int FactionID;

        /// <summary>
        /// 关卡副本信息类型
        /// </summary>
        public List<int> FactionDataType;

        /// <summary>
        /// 关卡副本信息值
        /// </summary>
        public List<int> FactionDataValue;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(FactionID, Endianness.Big);
            int factionDataTypeCount = (int)FactionDataType.Count;
            buffer.WriteInt32(factionDataTypeCount, Endianness.Big);
            for (int i = 0; i < factionDataTypeCount; i++)
            {
                buffer.WriteInt32(FactionDataType[i], Endianness.Big);
            }
            int factionDataValueCount = (int)FactionDataValue.Count;
            buffer.WriteInt32(factionDataValueCount, Endianness.Big);
            for (int i = 0; i < factionDataValueCount; i++)
            {
                buffer.WriteInt32(FactionDataValue[i], Endianness.Big);
            }
        }

    }
}
