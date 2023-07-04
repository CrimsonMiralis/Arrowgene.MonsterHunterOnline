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
    /// 怪物尺寸信息
    /// </summary>
    public class CSMonsterSizeInfo : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSMonsterSizeInfo));

        public CSMonsterSizeInfo()
        {
            MonsterID = 0;
            MinSize = 0.0f;
            MaxSize = 0.0f;
            SizeLevel = 0;
        }

        /// <summary>
        /// 怪物ID
        /// </summary>
        public int MonsterID;

        /// <summary>
        /// 怪物尺寸
        /// </summary>
        public float MinSize;

        /// <summary>
        /// 怪物尺寸
        /// </summary>
        public float MaxSize;

        /// <summary>
        /// 怪物尺寸Flag
        /// </summary>
        public int SizeLevel;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(MonsterID, Endianness.Big);
            buffer.WriteFloat(MinSize, Endianness.Big);
            buffer.WriteFloat(MaxSize, Endianness.Big);
            buffer.WriteInt32(SizeLevel, Endianness.Big);
        }

        public void Read(IBuffer buffer)
        {
            MonsterID = buffer.ReadInt32(Endianness.Big);
            MinSize = buffer.ReadFloat(Endianness.Big);
            MaxSize = buffer.ReadFloat(Endianness.Big);
            SizeLevel = buffer.ReadInt32(Endianness.Big);
        }

    }
}