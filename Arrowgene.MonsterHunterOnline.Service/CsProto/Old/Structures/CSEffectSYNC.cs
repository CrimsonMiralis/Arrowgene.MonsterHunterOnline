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
    /// 特效同步
    /// </summary>
    public class CSEffectSYNC : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSEffectSYNC));

        public CSEffectSYNC()
        {
            AttachToNetObjId = 0;
            Scale = 0.0f;
            Effect = "";
            LocalDir = new CSVec3();
            Offset = new CSVec3();
            BoneName = "";
            bRemove = 0;
        }

        /// <summary>
        /// 绑定的Entity net ID
        /// </summary>
        public uint AttachToNetObjId;

        /// <summary>
        /// 特效缩放
        /// </summary>
        public float Scale;

        /// <summary>
        /// 特效路径
        /// </summary>
        public string Effect;

        /// <summary>
        /// 在Local下的方向
        /// </summary>
        public CSVec3 LocalDir;

        /// <summary>
        /// 与绑定点的位置偏移
        /// </summary>
        public CSVec3 Offset;

        /// <summary>
        /// 绑定点的骨骼名称（可选）
        /// </summary>
        public string BoneName;

        /// <summary>
        /// 是移除还是添加
        /// </summary>
        public byte bRemove;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt32(AttachToNetObjId, Endianness.Big);
            buffer.WriteFloat(Scale, Endianness.Big);
            buffer.WriteInt32(Effect.Length + 1, Endianness.Big);
            buffer.WriteCString(Effect);
            LocalDir.WriteCs(buffer);
            Offset.WriteCs(buffer);
            buffer.WriteInt32(BoneName.Length + 1, Endianness.Big);
            buffer.WriteCString(BoneName);
            buffer.WriteByte(bRemove);
        }

        public void ReadCs(IBuffer buffer)
        {
            AttachToNetObjId = buffer.ReadUInt32(Endianness.Big);
            Scale = buffer.ReadFloat(Endianness.Big);
            int EffectEntryLen = buffer.ReadInt32(Endianness.Big);
            Effect = buffer.ReadString(EffectEntryLen);
            LocalDir.ReadCs(buffer);
            Offset.ReadCs(buffer);
            int BoneNameEntryLen = buffer.ReadInt32(Endianness.Big);
            BoneName = buffer.ReadString(BoneNameEntryLen);
            bRemove = buffer.ReadByte();
        }

    }
}
