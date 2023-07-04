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
    /// 场景特效
    /// </summary>
    public class CSSceneEffect : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSSceneEffect));

        public CSSceneEffect()
        {
            EffectID = 0;
            EffectType = 0;
            Pos = new CSVec3();
            OwnerID = 0;
            SpawnTime = 0;
            DurationTime = 0;
            SrcType = 0;
        }

        /// <summary>
        /// 特效ID
        /// </summary>
        public ulong EffectID;

        /// <summary>
        /// 特效类型
        /// </summary>
        public int EffectType;

        /// <summary>
        /// 特效位置
        /// </summary>
        public CSVec3 Pos;

        /// <summary>
        /// 拥有者
        /// </summary>
        public ulong OwnerID;

        /// <summary>
        /// 产生时间
        /// </summary>
        public ulong SpawnTime;

        /// <summary>
        /// 持续时间
        /// </summary>
        public int DurationTime;

        /// <summary>
        /// 来源类型
        /// </summary>
        public byte SrcType;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt64(EffectID, Endianness.Big);
            buffer.WriteInt32(EffectType, Endianness.Big);
            Pos.Write(buffer);
            buffer.WriteUInt64(OwnerID, Endianness.Big);
            buffer.WriteUInt64(SpawnTime, Endianness.Big);
            buffer.WriteInt32(DurationTime, Endianness.Big);
            buffer.WriteByte(SrcType);
        }

        public void Read(IBuffer buffer)
        {
            EffectID = buffer.ReadUInt64(Endianness.Big);
            EffectType = buffer.ReadInt32(Endianness.Big);
            Pos.Read(buffer);
            OwnerID = buffer.ReadUInt64(Endianness.Big);
            SpawnTime = buffer.ReadUInt64(Endianness.Big);
            DurationTime = buffer.ReadInt32(Endianness.Big);
            SrcType = buffer.ReadByte();
        }

    }
}