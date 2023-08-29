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
    /// 分类素材列表
    /// </summary>
    public class TagItemList : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(TagItemList));

        public TagItemList()
        {
            TagType = 0;
            CreditCnt = 0;
            MaterialType = new List<int>();
            MaterialCnt = new List<int>();
        }

        /// <summary>
        /// tag类型
        /// </summary>
        public int TagType;

        /// <summary>
        /// 代币数量
        /// </summary>
        public int CreditCnt;

        /// <summary>
        /// 素材总类
        /// </summary>
        public List<int> MaterialType;

        /// <summary>
        /// 素材数量
        /// </summary>
        public List<int> MaterialCnt;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(TagType, Endianness.Big);
            buffer.WriteInt32(CreditCnt, Endianness.Big);
            byte materialTypeCount = (byte)MaterialType.Count;
            buffer.WriteByte(materialTypeCount);
            for (int i = 0; i < materialTypeCount; i++)
            {
                buffer.WriteInt32(MaterialType[i], Endianness.Big);
            }
            byte materialCntCount = (byte)MaterialCnt.Count;
            buffer.WriteByte(materialCntCount);
            for (int i = 0; i < materialCntCount; i++)
            {
                buffer.WriteInt32(MaterialCnt[i], Endianness.Big);
            }
        }

        public void ReadCs(IBuffer buffer)
        {
            TagType = buffer.ReadInt32(Endianness.Big);
            CreditCnt = buffer.ReadInt32(Endianness.Big);
            MaterialType.Clear();
            byte materialTypeCount = buffer.ReadByte();
            for (int i = 0; i < materialTypeCount; i++)
            {
                int MaterialTypeEntry = buffer.ReadInt32(Endianness.Big);
                MaterialType.Add(MaterialTypeEntry);
            }
            MaterialCnt.Clear();
            byte materialCntCount = buffer.ReadByte();
            for (int i = 0; i < materialCntCount; i++)
            {
                int MaterialCntEntry = buffer.ReadInt32(Endianness.Big);
                MaterialCnt.Add(MaterialCntEntry);
            }
        }

    }
}
