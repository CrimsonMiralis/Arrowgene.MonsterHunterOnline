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
    /// 猎团摘要
    /// </summary>
    public class CSGuildOutline : IStructure
    {

        public CSGuildOutline()
        {
            Id = 0;
            Name = "";
            Icon = 0;
            Note = "";
            Level = 0;
            Repute = 0;
            Leader = "";
            Guilders = 0;
            GuildersAvgLevel = 0;
            JoinLevel = 0;
            HuntSoul = 0;
        }

        /// <summary>
        /// 标识
        /// </summary>
        public ulong Id;

        /// <summary>
        /// 名字
        /// </summary>
        public string Name;

        /// <summary>
        /// 图标
        /// </summary>
        public int Icon;

        /// <summary>
        /// 注释
        /// </summary>
        public string Note;

        /// <summary>
        /// 等级
        /// </summary>
        public int Level;

        /// <summary>
        /// 声望
        /// </summary>
        public int Repute;

        /// <summary>
        /// 团长
        /// </summary>
        public string Leader;

        /// <summary>
        /// 会员集
        /// </summary>
        public int Guilders;

        /// <summary>
        /// 会员集平均等级
        /// </summary>
        public int GuildersAvgLevel;

        /// <summary>
        /// 加入等级
        /// </summary>
        public int JoinLevel;

        /// <summary>
        /// 勇气印记
        /// </summary>
        public ulong HuntSoul;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt64(Id, Endianness.Big);
            buffer.WriteInt32(Name.Length + 1, Endianness.Big);
            buffer.WriteCString(Name);
            buffer.WriteInt32(Icon, Endianness.Big);
            buffer.WriteInt32(Note.Length + 1, Endianness.Big);
            buffer.WriteCString(Note);
            buffer.WriteInt32(Level, Endianness.Big);
            buffer.WriteInt32(Repute, Endianness.Big);
            buffer.WriteInt32(Leader.Length + 1, Endianness.Big);
            buffer.WriteCString(Leader);
            buffer.WriteInt32(Guilders, Endianness.Big);
            buffer.WriteInt32(GuildersAvgLevel, Endianness.Big);
            buffer.WriteInt32(JoinLevel, Endianness.Big);
            buffer.WriteUInt64(HuntSoul, Endianness.Big);
        }

    }
}
