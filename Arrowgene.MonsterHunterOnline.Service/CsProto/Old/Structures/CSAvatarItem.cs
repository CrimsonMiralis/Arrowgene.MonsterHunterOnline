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
    /// 角色装备显示物品
    /// </summary>
    public class CSAvatarItem : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSAvatarItem));

        public CSAvatarItem()
        {
            ItemType = 0;
            PosIndex = 0;
            Rank = 0;
            EnhanceRule = 0;
            EnhanceLevel = 0;
            SoltCount = 0;
            GemID = 0;
            BreakLevel = 0;
            ColorIndex = 0;
            FakeShow = 0;
            WakeLevel = 0;
        }

        /// <summary>
        /// 物品类型
        /// </summary>
        public int ItemType;

        /// <summary>
        /// 物品位置行
        /// </summary>
        public ushort PosIndex;

        /// <summary>
        /// Rank级别
        /// </summary>
        public uint Rank;

        /// <summary>
        /// 强化规则
        /// </summary>
        public byte EnhanceRule;

        /// <summary>
        /// 强化数据
        /// </summary>
        public byte EnhanceLevel;

        /// <summary>
        /// 插孔数
        /// </summary>
        public byte SoltCount;

        /// <summary>
        /// 插孔宝石物品
        /// </summary>
        public uint GemID;

        /// <summary>
        /// 突破级别
        /// </summary>
        public byte BreakLevel;

        /// <summary>
        /// 染色效果
        /// </summary>
        public byte ColorIndex;

        /// <summary>
        /// 幻化效果
        /// </summary>
        public uint FakeShow;

        /// <summary>
        /// 觉醒层级
        /// </summary>
        public byte WakeLevel;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(ItemType, Endianness.Big);
            buffer.WriteUInt16(PosIndex, Endianness.Big);
            buffer.WriteUInt32(Rank, Endianness.Big);
            buffer.WriteByte(EnhanceRule);
            buffer.WriteByte(EnhanceLevel);
            buffer.WriteByte(SoltCount);
            buffer.WriteUInt32(GemID, Endianness.Big);
            buffer.WriteByte(BreakLevel);
            buffer.WriteByte(ColorIndex);
            buffer.WriteUInt32(FakeShow, Endianness.Big);
            buffer.WriteByte(WakeLevel);
        }

        public void ReadCs(IBuffer buffer)
        {
            ItemType = buffer.ReadInt32(Endianness.Big);
            PosIndex = buffer.ReadUInt16(Endianness.Big);
            Rank = buffer.ReadUInt32(Endianness.Big);
            EnhanceRule = buffer.ReadByte();
            EnhanceLevel = buffer.ReadByte();
            SoltCount = buffer.ReadByte();
            GemID = buffer.ReadUInt32(Endianness.Big);
            BreakLevel = buffer.ReadByte();
            ColorIndex = buffer.ReadByte();
            FakeShow = buffer.ReadUInt32(Endianness.Big);
            WakeLevel = buffer.ReadByte();
        }

    }
}
