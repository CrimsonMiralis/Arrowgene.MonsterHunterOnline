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
    /// 通知客户端增加交易道具
    /// </summary>
    public class CSTradeAddItemNtf : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSTradeAddItemNtf));

        public CSTradeAddItemNtf()
        {
            Column = 0;
            Grid = 0;
            Count = 0;
            DstGrid = 0;
        }

        /// <summary>
        /// 物品栏
        /// </summary>
        public ushort Column;

        /// <summary>
        /// 格子
        /// </summary>
        public ushort Grid;

        /// <summary>
        /// 物品数量
        /// </summary>
        public ushort Count;

        /// <summary>
        /// 目标格子
        /// </summary>
        public ushort DstGrid;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt16(Column, Endianness.Big);
            buffer.WriteUInt16(Grid, Endianness.Big);
            buffer.WriteUInt16(Count, Endianness.Big);
            buffer.WriteUInt16(DstGrid, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            Column = buffer.ReadUInt16(Endianness.Big);
            Grid = buffer.ReadUInt16(Endianness.Big);
            Count = buffer.ReadUInt16(Endianness.Big);
            DstGrid = buffer.ReadUInt16(Endianness.Big);
        }

    }
}
