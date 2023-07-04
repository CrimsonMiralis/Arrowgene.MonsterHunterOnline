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
    /// 删除交易道具通知
    /// </summary>
    public class CSTradeDelItemNtf : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSTradeDelItemNtf));

        public CSTradeDelItemNtf()
        {
            PlayerId = 0;
            Column = 0;
            Grid = 0;
            Index = 0;
        }

        /// <summary>
        /// 玩家ID
        /// </summary>
        public int PlayerId;

        /// <summary>
        /// 所在栏位
        /// </summary>
        public ushort Column;

        /// <summary>
        /// 所在格子
        /// </summary>
        public ushort Grid;

        /// <summary>
        /// 所在索引 
        /// </summary>
        public ushort Index;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(PlayerId, Endianness.Big);
            buffer.WriteUInt16(Column, Endianness.Big);
            buffer.WriteUInt16(Grid, Endianness.Big);
            buffer.WriteUInt16(Index, Endianness.Big);
        }

        public void Read(IBuffer buffer)
        {
            PlayerId = buffer.ReadInt32(Endianness.Big);
            Column = buffer.ReadUInt16(Endianness.Big);
            Grid = buffer.ReadUInt16(Endianness.Big);
            Index = buffer.ReadUInt16(Endianness.Big);
        }

    }
}