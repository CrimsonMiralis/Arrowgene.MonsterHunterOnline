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

    public class CSCatCuisineRemainsNtf : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSCatCuisineRemainsNtf));

        public CSCatCuisineRemainsNtf()
        {
            Id = 0;
            Count = 0;
            Level = 0;
            Buffs = 0;
            CatLastTm = 0;
        }

        /// <summary>
        /// 剩余次数的猫饭ID
        /// </summary>
        public int Id;

        /// <summary>
        /// 猫饭的剩余次数
        /// </summary>
        public ushort Count;

        /// <summary>
        /// 剩余次数的猫饭等级
        /// </summary>
        public byte Level;

        /// <summary>
        /// 剩余次数的猫饭效果
        /// </summary>
        public byte Buffs;

        /// <summary>
        /// 最后一次吃猫饭时间
        /// </summary>
        public uint CatLastTm;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(Id, Endianness.Big);
            buffer.WriteUInt16(Count, Endianness.Big);
            buffer.WriteByte(Level);
            buffer.WriteByte(Buffs);
            buffer.WriteUInt32(CatLastTm, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            Id = buffer.ReadInt32(Endianness.Big);
            Count = buffer.ReadUInt16(Endianness.Big);
            Level = buffer.ReadByte();
            Buffs = buffer.ReadByte();
            CatLastTm = buffer.ReadUInt32(Endianness.Big);
        }

    }
}
