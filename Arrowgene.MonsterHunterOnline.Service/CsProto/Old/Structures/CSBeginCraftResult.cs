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
    /// 开始打造返回
    /// </summary>
    public class CSBeginCraftResult : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSBeginCraftResult));

        public CSBeginCraftResult()
        {
            nCraftID = 0;
            nResult = 0;
            nOrderItemID1 = 0;
            nOrderItemCount1 = 0;
            nOrderItemID2 = 0;
            nOrderItemCount2 = 0;
        }

        /// <summary>
        /// 任务ID
        /// </summary>
        public uint nCraftID;

        /// <summary>
        /// 结果
        /// </summary>
        public uint nResult;

        /// <summary>
        /// 生成物品1ID
        /// </summary>
        public uint nOrderItemID1;

        /// <summary>
        /// 生成数量1
        /// </summary>
        public uint nOrderItemCount1;

        /// <summary>
        /// 生成物品1ID
        /// </summary>
        public uint nOrderItemID2;

        /// <summary>
        /// 生成数量1
        /// </summary>
        public uint nOrderItemCount2;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt32(nCraftID, Endianness.Big);
            buffer.WriteUInt32(nResult, Endianness.Big);
            buffer.WriteUInt32(nOrderItemID1, Endianness.Big);
            buffer.WriteUInt32(nOrderItemCount1, Endianness.Big);
            buffer.WriteUInt32(nOrderItemID2, Endianness.Big);
            buffer.WriteUInt32(nOrderItemCount2, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            nCraftID = buffer.ReadUInt32(Endianness.Big);
            nResult = buffer.ReadUInt32(Endianness.Big);
            nOrderItemID1 = buffer.ReadUInt32(Endianness.Big);
            nOrderItemCount1 = buffer.ReadUInt32(Endianness.Big);
            nOrderItemID2 = buffer.ReadUInt32(Endianness.Big);
            nOrderItemCount2 = buffer.ReadUInt32(Endianness.Big);
        }

    }
}
