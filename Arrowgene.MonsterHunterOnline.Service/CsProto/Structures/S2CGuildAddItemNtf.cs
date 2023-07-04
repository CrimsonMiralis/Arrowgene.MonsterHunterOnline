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
    /// 通知客户端添加物品
    /// </summary>
    public class S2CGuildAddItemNtf : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(S2CGuildAddItemNtf));

        public S2CGuildAddItemNtf()
        {
            Reason = 0;
            ItemList = new List<CSItemData>();
        }

        /// <summary>
        /// 原因
        /// </summary>
        public ushort Reason;

        /// <summary>
        /// 物品列表
        /// </summary>
        public List<CSItemData> ItemList;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt16(Reason, Endianness.Big);
            byte itemListCount = (byte)ItemList.Count;
            buffer.WriteByte(itemListCount);
            for (int i = 0; i < itemListCount; i++)
            {
                ItemList[i].Write(buffer);
            }
        }

        public void Read(IBuffer buffer)
        {
            Reason = buffer.ReadUInt16(Endianness.Big);
            ItemList.Clear();
            byte itemListCount = buffer.ReadByte();
            for (int i = 0; i < itemListCount; i++)
            {
                CSItemData ItemListEntry = new CSItemData();
                ItemListEntry.Read(buffer);
                ItemList.Add(ItemListEntry);
            }
        }

    }
}